/**
 * Control Interface board to Serial Output
 * Flightgear - Aircraft Piper Seneca II
 */

/*
 * Target Refresh rate for output in milliseconds
 */
const uint32_t interval = 100;
uint32_t lastUpdate = 0;

 /*
  * Analog Inputs
  */
const int throttleLeftPin = A0;
const int throttleRightPin = A1;
const int pitchLeftPin = A2;
const int pitchRightPin = A3;
const int mixtureLeftPin = A4;
const int mixtureRightPin = A5;
const int rudderTrimPin = A6;
const int aileronTrimPin = A7;

/*
 * Digital Inputs
 */
const int parkingBrakePin = 2;
const int flapsUpPin = 3;
const int flapsToPin = 4;
const int flapsAppPin = 5;
const int flapsDownPin = 6;
const int fuelLeftMainPin = 7;
const int fuelLeftCrossfeedPin = 8;
const int fuelLeftOffPin = 9;
const int fuelRightMainPin = 10;
const int fuelRightCrossfeedPin = 11;
const int fuelRightOffPin = 12;

const int buttonPins[] = {
  parkingBrakePin,
  flapsUpPin,
  flapsToPin,
  flapsAppPin,
  flapsDownPin,
  fuelLeftMainPin,
  fuelLeftCrossfeedPin,
  fuelLeftOffPin,
  fuelRightMainPin,
  fuelRightCrossfeedPin,
  fuelRightOffPin
};
const int buttonCount = sizeof(buttonPins) / sizeof(int);

/*
 * Throttle, Pitch, Mixture values
 */
const int maxThrottleValue = 760;
const int minThrottleValue = 260;
const float throttleRange = maxThrottleValue - minThrottleValue;
//const double reverseThreshold = 0.18;
//const double featherThreshold = 0.05;

const float flapsUpValue = 0;
const float flapsToValue = 0.25;
const float flapsAppValue = 0.625;
const float flapsDownValue = 1.0;

const int fuelMainValue = 1;
const int fuelOffValue = 0;
const int fuelCrossfeedValue = -1;

const char * separator = ",";

void setup() {
  Serial.begin(9600);
  for (int i = 0; i < buttonCount; i++) {
    pinMode(buttonPins[i], INPUT_PULLUP);
  }

  lastUpdate = millis();
}

void printBoolean(bool b) {
  if (b) {
    Serial.print("1");
  } else {
    Serial.print("0");
  }
}

float readThrottleInput(int pin) {
  return (float)(max(minThrottleValue, min(maxThrottleValue, analogRead(pin))) - minThrottleValue) / throttleRange;
}

float readTrimInput(int pin) {
  return (((float)analogRead(pin) / 512.0) - 1.0) * -1.0;
}

void loop() {
  uint32_t currentTime = millis();
  if (currentTime - lastUpdate < interval) {
    return;
  }

  float throttleLeftValue = readThrottleInput(throttleLeftPin);
  float throttleRightValue = readThrottleInput(throttleRightPin);
  float pitchLeftValue = readThrottleInput(pitchLeftPin);
  float pitchRightValue = readThrottleInput(pitchRightPin);
  float mixtureLeftValue = readThrottleInput(mixtureLeftPin);
  float mixtureRightValue = readThrottleInput(mixtureRightPin);

  bool brakeSet = digitalRead(parkingBrakePin) == LOW;
  
  float flapsValue = flapsUpValue;
  if (digitalRead(flapsUpPin) == LOW) {
    flapsValue = flapsUpValue;
  } else if (digitalRead(flapsToPin) == LOW) {
    flapsValue = flapsToValue;
  } else if (digitalRead(flapsAppPin) == LOW) {
    flapsValue = flapsAppValue;
  } else if (digitalRead(flapsDownPin) == LOW) {
    flapsValue = flapsDownValue;
  }

  float rudderTrimValue = readTrimInput(rudderTrimPin);
  float aileronTrimValue = readTrimInput(aileronTrimPin);

  int fuelLeftValue = fuelMainValue;
  if (digitalRead(fuelLeftMainPin) == LOW) {
    fuelLeftValue = fuelMainValue;
  } else if (digitalRead(fuelLeftCrossfeedPin) == LOW) {
    fuelLeftValue = fuelCrossfeedValue;
  } else if (digitalRead(fuelLeftOffPin) == LOW) {
    fuelLeftValue = fuelOffValue;
  }

  int fuelRightValue = fuelMainValue;
  if (digitalRead(fuelRightMainPin) == LOW) {
    fuelRightValue = fuelMainValue;
  } else if (digitalRead(fuelRightCrossfeedPin) == LOW) {
    fuelRightValue = fuelCrossfeedValue;
  } else if (digitalRead(fuelRightOffPin) == LOW) {
    fuelRightValue = fuelOffValue;
  }

  // Output Serial data line
  Serial.print(throttleLeftValue);
  Serial.print(separator);
  Serial.print(throttleRightValue);
  Serial.print(separator);
  Serial.print(pitchLeftValue);
  Serial.print(separator);
  Serial.print(pitchRightValue);
  Serial.print(separator);
  Serial.print(mixtureLeftValue);
  Serial.print(separator);
  Serial.print(mixtureRightValue);
  Serial.print(separator);

  printBoolean(brakeSet);
  Serial.print(separator);

  Serial.print(flapsValue);
  Serial.print(separator);

  Serial.print(rudderTrimValue);
  Serial.print(separator);
  Serial.print(aileronTrimValue);
  Serial.print(separator);

  Serial.print(fuelLeftValue);
  Serial.print(separator);
  Serial.print(fuelRightValue);
  Serial.print(separator);

  Serial.print("\n");  
}