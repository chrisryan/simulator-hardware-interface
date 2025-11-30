/*
 * Arduino Mega 2560
 * Engine and Throttle controller
 *
 * Communicates data in and out to control program for driving
 * Engine instruments and reading Throttle and various controls.
 *
 * Christopher Ryan
 * 2025
 *
 * Bytes In:
 *   1  byte Header 0xFF
 *   15 byte Instrument values
 *      (InterTurbineTempLeft, TorqueLeft, PropRpmLeft, PercentRpmLeft, 
 *       FuelFlowPphLeft, OilTempLeft, OilPressLeft, InterTurbineTempRight, 
 *       TorqueRight, PropRpmRight, PercentRpmRight, FuelFlowPphRigh,
 *       OilTempRight, OilPressRight, Airspeed)
 *   1  byte flags (least significant first)
 *      (Hobbs, Nose Light, Left Light, Right Light, Transition Light) 
 * 
 * Bytes Out:
 *   1  byte Header 0xFF
 *   8  short Control values
 *      (ThrottleLeft, ThrottleRight, PitchLeft, PitchRight,
 *       MixtureLeft, MixtureRight, RudderTrim, AileronTrim)
 *   3  byte flags (least significant first)
 *      (LandingGearDown, ParkingBrake, FuelLeftMain, FuelLeftCross, FuelRightMain, FuelRightCross)
 *      (FlapsTo, FlapsApp, FlapsDown, Silence, TestLamp, MasterAvionics, MasterBattery)
 *      (BleedairRight, BleedairLeft, IgnitionRight, IgnitionLeft, StarterRight, StarterLeft)
 */

 
// Output - Digital
const byte GearDownPin = 41;
const byte FuelLeftMainPin = 30;
const byte FuelLeftCrossPin  = 32;
const byte FuelLeftOffPin = 34;
const byte FuelRightMain = 31;
const byte FuelRightCrossPin  = 33;
const byte FuelRightOffPin = 35;
const byte ParkingBrakePin = 25;
const byte FlapsUpPin = 26;
const byte FlapsTakeoffPin = 27;
const byte FlapsAppPin = 28;
const byte FlapsDownPin = 29;
const byte HornSilencePin = 42;
const byte TestLampPin = 40;
const byte MasterAvionicsPin = A8;
const byte MasterBatteryPin = A9;
const byte BleedairRightPin = A10;
const byte BleedairLeftPin = A11;
const byte IgnitionRightPin = A12;
const byte IgnitionLeftPin = A13;
const byte StarterRightPin = A14;
const byte StarterLeftPin = A15;

// Output - Analog
const byte ThrottleLeftPin = A0;
const byte ThrottleRightPin = A1;
const byte PitchLeftPin = A2;
const byte PitchRightPin = A3;
const byte MixtureLeftPin = A4;
const byte MixtureRightPin = A5;
const byte RudderTrimPin = A6;
const byte AileronTrimPin = A7;

// Input Pins - Digital
const byte LandingGearLightTransitionPin = 39;
const byte LandingGearLightNosePin = 36;
const byte LandingGearLightLeftPin = 37;
const byte LandingGearLightRightPin = 38;
const byte HobbsRunningPin = 24;

// Input Pins - Analog
const byte InterTurbineTempLeftPin = 2;
const byte TorqueLeftPin = 3;
const byte PropRpmLeftPin = 4;
const byte PercentRpmLeftPin = 5;
const byte FuelFlowPphLeftPin = 6;
const byte OilTempLeftPin = 7;
const byte OilPressLeftPin = 8;
const byte InterTurbineTempRightPin = 9;
const byte TorqueRightPin = 10;
const byte PropRpmRightPin = 11;
const byte PercentRpmRightPin = 12;
const byte FuelFlowPphRighPin = 13;
const byte OilTempRightPin = 44;
const byte OilPressRightPin = 46;
const byte AirspeedPin = 45;

// Masks
const byte HobbsRunningMask = 1 << 0;
const byte LandingGearLightNoseMask = 1 << 1;
const byte LandingGearLightLeftMask = 1 << 2;
const byte LandingGearLightRightMask = 1 << 3;
const byte LandingGearLightTransitionMask = 1 << 4;

// Flags Byte A
const byte LandingGearDownFlag = 1 << 0;
const byte ParkingBrakeFlag = 1 << 1;
const byte FuelLeftMainFlag = 1 << 2;
const byte FuelLeftCrossFlag = 1 << 3;
const byte FuelRightMainFlag = 1 << 4;
const byte FuelRightCrossFlag = 1 << 5;

// Flags Byte B
const byte FlapsToFlag = 1 << 0;
const byte FlapsAppFlag = 1 << 1;
const byte FlapsDownFlag = 1 << 2;
const byte HornSilenceFlag = 1 << 3;
const byte TestLampFlag = 1 << 4;
const byte MasterAvionicsFlag = 1 << 5;
const byte MasterBatteryFlag = 1 << 6;

// Flags Byte C
const byte BleedairRightFlag = 1 << 0;
const byte BleedairLeftFlag = 1 << 1;
const byte IgnitionRightFlag = 1 << 2;
const byte IgnitionLeftFlag = 1 << 3;
const byte StarterRightFlag = 1 << 4;
const byte StarterLeftFlag = 1 << 5;

unsigned long lastUpdate;
unsigned long timeBetweenSends = 100;
const unsigned int bytesToRead = 16;
byte dataIn[bytesToRead];

const byte inputMap[] = {
  InterTurbineTempLeftPin,
  TorqueLeftPin,
  PropRpmLeftPin,
  PercentRpmLeftPin,
  FuelFlowPphLeftPin,
  OilTempLeftPin,
  OilPressLeftPin,
  InterTurbineTempRightPin,
  TorqueRightPin,
  PropRpmRightPin,
  PercentRpmRightPin,
  FuelFlowPphRighPin,
  OilTempRightPin,
  OilPressRightPin,
  AirspeedPin
};
const unsigned int inputMapSize = sizeof(inputMap) / sizeof(inputMap[0]);
const unsigned int flagPos = inputMapSize;

const byte outputMap[] = {
  ThrottleLeftPin,
  ThrottleRightPin,
  PitchLeftPin,
  PitchRightPin,
  MixtureLeftPin,
  MixtureRightPin,
  RudderTrimPin,
  AileronTrimPin
};
const unsigned int outputMapSize = sizeof(outputMap) / sizeof(outputMap[0]);
const unsigned int outputFlagStartPos = outputMapSize * 2;
const unsigned int outputFlagByteCount = 3;
const unsigned int bytesToWrite = (outputMapSize * 2) + outputFlagByteCount;
byte dataOut[bytesToWrite];

byte previousLampState = 0;
bool testLampEnabled = false;
bool noseLampEnabled = false;
bool leftLampEnabled = false;
bool rightLampEnabled = false;
bool errorLampEnabled = false;

bool lookingForStartBytes = true;

void setup() {
  // put your setup code here, to run once:
  Serial.begin(115200);

  for (int i = 0; i < inputMapSize; i++) {
    pinMode(inputMap[i], OUTPUT);
  }

  pinMode(LandingGearLightTransitionPin, OUTPUT);
  pinMode(LandingGearLightNosePin, OUTPUT);
  pinMode(LandingGearLightLeftPin, OUTPUT);
  pinMode(LandingGearLightRightPin, OUTPUT);
  pinMode(HobbsRunningPin, OUTPUT);

  // Output - Digital
  pinMode(GearDownPin, INPUT_PULLUP);
  pinMode(FuelLeftMainPin, INPUT_PULLUP);
  pinMode(FuelLeftCrossPin, INPUT_PULLUP);
  //pinMode(FuelLeftOffPin, INPUT_PULLUP);
  pinMode(FuelRightMain, INPUT_PULLUP);
  pinMode(FuelRightCrossPin, INPUT_PULLUP);
  //pinMode(FuelRightOffPin, INPUT_PULLUP);
  pinMode(ParkingBrakePin, INPUT_PULLUP);
  //pinMode(FlapsUpPin, INPUT_PULLUP);
  pinMode(FlapsTakeoffPin, INPUT_PULLUP);
  pinMode(FlapsAppPin, INPUT_PULLUP);
  pinMode(FlapsDownPin, INPUT_PULLUP);
  pinMode(HornSilencePin, INPUT_PULLUP);
  pinMode(TestLampPin, INPUT_PULLUP);
  pinMode(MasterAvionicsPin, INPUT_PULLUP);
  pinMode(MasterBatteryPin, INPUT_PULLUP);
  pinMode(BleedairRightPin, INPUT_PULLUP);
  pinMode(BleedairLeftPin, INPUT_PULLUP);
  pinMode(IgnitionRightPin, INPUT_PULLUP);
  pinMode(IgnitionLeftPin, INPUT_PULLUP);
  pinMode(StarterRightPin, INPUT_PULLUP);
  pinMode(StarterLeftPin, INPUT_PULLUP);

  // Output - Analog
  for (int i = 0; i < outputMapSize; i++) {
    pinMode(outputMap[i], INPUT);
  }
}

void loop() {
  writeData();
  readData();
  updateLights();
}

void writeData()
{
  unsigned long currentUpdate = millis();
  if (currentUpdate - lastUpdate < timeBetweenSends) {
    return;
  }

  lastUpdate = currentUpdate;

  short value;
  for (int i = 0; i < outputMapSize; i++) {
    value = analogRead(outputMap[i]);
    dataOut[(i * 2)] = highByte(value);
    dataOut[(i * 2) + 1] = lowByte(value);
  }

  byte flagA = getFlagA();
  byte flagB = getFlagB();
  byte flagC = getFlagC();
    
  testLampEnabled = flagB & TestLampFlag;

  dataOut[outputFlagStartPos + 0] = flagA;
  dataOut[outputFlagStartPos + 1] = flagB;
  dataOut[outputFlagStartPos + 2] = flagC;

  Serial.write(0xFF);
  Serial.write(dataOut, bytesToWrite);
}

void readData()
{
  if (lookingForStartBytes){
    if (Serial.available() < 1) {
      return;
    }

    byte headerByte = Serial.read();
    if (headerByte != 0xFF) {
      return;
    }

    lookingForStartBytes = false;
  }

  if (Serial.available() >= bytesToRead) {
    lookingForStartBytes = true;

    size_t byteCount = Serial.readBytes(dataIn, bytesToRead);
    if (byteCount != bytesToRead) {
      return;
    }

    for (int i = 0; i < inputMapSize; i++) {
      analogWrite(inputMap[i], dataIn[i]);
    }

    byte flag = dataIn[flagPos];
    noseLampEnabled = flag & LandingGearLightNoseMask;
    leftLampEnabled = flag & LandingGearLightLeftMask;
    rightLampEnabled = flag & LandingGearLightRightMask;
    errorLampEnabled = flag & LandingGearLightTransitionMask;

    digitalWrite(HobbsRunningPin, flag & HobbsRunningMask);
  }
}

void updateLights()
{
  byte currentLampState = 0;
  if (testLampEnabled) currentLampState |= 0x10;
  if (errorLampEnabled) currentLampState |= 0x08;
  if (noseLampEnabled) currentLampState |= 0x04;
  if (leftLampEnabled) currentLampState |= 0x02;
  if (rightLampEnabled) currentLampState |= 0x01;

  if (currentLampState == previousLampState) {
    return;
  }

  previousLampState = currentLampState;
  digitalWrite(LandingGearLightTransitionPin, testLampEnabled || errorLampEnabled);
  digitalWrite(LandingGearLightNosePin, testLampEnabled || noseLampEnabled);
  digitalWrite(LandingGearLightLeftPin, testLampEnabled || leftLampEnabled);
  digitalWrite(LandingGearLightRightPin, testLampEnabled || rightLampEnabled);
}

byte getFlagA()
{
  byte flag = 0;
  short value;

  value = digitalRead(GearDownPin);
  if (value == LOW) flag |= LandingGearDownFlag;
   
  value = digitalRead(ParkingBrakePin);
  if (value == LOW) flag |= ParkingBrakeFlag;

  value = digitalRead(FuelLeftMainPin);
  if (value == LOW) flag |= FuelLeftMainFlag;

  value = digitalRead(FuelLeftCrossPin);
  if (value == LOW) flag |= FuelLeftCrossFlag;

  value = digitalRead(FuelRightMain);
  if (value == LOW) flag |= FuelRightMainFlag;

  value = digitalRead(FuelRightCrossPin);
  if (value == LOW) flag |= FuelRightCrossFlag;

  return flag;
}

byte getFlagB()
{
  byte flag = 0;
  short value;

  value = digitalRead(FlapsTakeoffPin);
  if (value == LOW) flag |= FlapsToFlag;
    
  value = digitalRead(FlapsAppPin);
  if (value == LOW) flag |= FlapsAppFlag;
    
  value = digitalRead(FlapsDownPin);
  if (value == LOW) flag |= FlapsDownFlag;
    
  value = digitalRead(HornSilencePin);
  if (value == LOW) flag |= HornSilenceFlag;
    
  value = digitalRead(TestLampPin);
  if (value == LOW) flag |= TestLampFlag;

  value = digitalRead(MasterAvionicsPin);
  if (value == LOW) flag |= MasterAvionicsFlag;

  value = digitalRead(MasterBatteryPin);
  if (value == LOW) flag |= MasterBatteryFlag;

  return flag;
}

byte getFlagC()
{
  byte flag = 0;
  short value;

  value = digitalRead(BleedairRightPin);
  if (value == LOW) flag |= BleedairRightFlag;

  value = digitalRead(BleedairLeftPin);
  if (value == LOW) flag |= BleedairLeftFlag;

  value = digitalRead(IgnitionRightPin);
  if (value == LOW) flag |= IgnitionRightFlag;

  value = digitalRead(IgnitionLeftPin);
  if (value == LOW) flag |= IgnitionLeftFlag;

  value = digitalRead(StarterRightPin);
  if (value == LOW) flag |= StarterRightFlag;

  value = digitalRead(StarterLeftPin);
  if (value == LOW) flag |= StarterLeftFlag;

  return flag;
}
