using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator_Interface
{
    internal class ArduinoSerialProcessor
    {
        const byte HOBBS_RUNNING_FLAG = 1 << 0;
        const byte GEAR_LIGHT_NOSE_FLAG = 1 << 1;
        const byte GEAR_LIGHT_LEFT_FLAG = 1 << 2;
        const byte GEAR_LIGHT_RIGHT_FLAG = 1 << 3;
        const byte GEAR_LIGHT_ERROR_FLAG = 1 << 4;

        private SerialPort _serialPort = null;
        private AircraftData data = null;
        private TextBox textBoxLogs = null;
        private Thread readThread = null;
        private Thread writeThread = null;
        private ConfigSettings settings = null;

        private volatile bool _continue = false;

        public ArduinoSerialProcessor(AircraftData data, TextBox textBoxLogs, ConfigSettings settings)
        {
            this.data = data;
            this.textBoxLogs = textBoxLogs;
            this.settings = settings;
            _serialPort = new SerialPort();
            _serialPort.PortName = settings.Communications.SerialPort;
            _serialPort.BaudRate = 115200;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
            readThread = new Thread(Read);
            readThread.IsBackground = true;
            readThread.Start();
            writeThread = new Thread(Write);
            writeThread.IsBackground = true;
            writeThread.Start();
        }

        public void Start()
        {
            _continue = true;
            _serialPort.Open();
        }

        public void Stop()
        {
            _continue = false;
            _serialPort.DiscardInBuffer();
            _serialPort.DiscardOutBuffer();
            Thread.Sleep(1000);
            //readThread.Join(500);
            //writeThread.Join(500);
            _serialPort.Close();
        }

        /*
         * Bytes In:
         *   1  byte Header 0xFF
         *   8  short Control values
         *      (ThrottleLeft, ThrottleRight, PitchLeft, PitchRight,
         *       MixtureLeft, MixtureRight, RudderTrim, AileronTrim)
         *   3  byte flags (least significant first)
         *      (LandingGearDown, ParkingBrake, FuelLeftMain, FuelLeftCross, FuelRightMain, FuelRightCross)
         *      (FlapsTo, FlapsApp, FlapsDown, Silence, TestLamp, MasterAvionics, MasterBattery)
         *      (BleedairRight, BleedairLeft, IgnitionRight, IgnitionLeft, StarterRight, StarterLeft)
         */
        public void Read()
        {
            bool seekingHeader = true;
            while (true)
            {
                if (_continue)
                {
                    try
                    {
                        if (seekingHeader)
                        {
                            int headerByte = _serialPort.ReadByte();
                            if (headerByte != 0xFF)
                            {
                                Thread.Sleep(50);
                                continue;
                            }

                            seekingHeader = false;
                        }

                        int inputBytes = 19;
                        if (_serialPort.BytesToRead < inputBytes)
                        {
                            Thread.Sleep(10);
                            continue;
                        }

                        seekingHeader = true;

                        byte[] dataIn = new byte[inputBytes];
                        int bytesRead = _serialPort.Read(dataIn, 0, inputBytes);

                        if (bytesRead != inputBytes)
                        {
                            continue;    
                        }

                        int value = 0;

                        value = dataIn[0] << 8 | dataIn[1];
                        ConfigComponentItem item = settings.Components.ThrottleLeft;
                        data.ThrottleLeft = MapToFloat(value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        value = dataIn[2] << 8 | dataIn[3];
                        item = settings.Components.ThrottleRight;
                        data.ThrottleRight = MapToFloat(value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        value = dataIn[4] << 8 | dataIn[5];
                        item = settings.Components.PitchLeft;
                        data.PitchLeft = MapToFloat(value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        value = dataIn[6] << 8 | dataIn[7];
                        item = settings.Components.PitchRight;
                        data.PitchRight = MapToFloat(value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        value = dataIn[8] << 8 | dataIn[9];
                        item = settings.Components.MixtureLeft;
                        data.MixtureLeft = MapToFloat(value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        value = dataIn[10] << 8 | dataIn[11];
                        item = settings.Components.MixtureRight;
                        data.MixtureRight = MapToFloat(value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        value = dataIn[12] << 8 | dataIn[13];
                        item = settings.Components.RudderTrim;
                        data.RudderTrim = MapToFloat(value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        value = dataIn[14] << 8 | dataIn[15];
                        item = settings.Components.AileronTrim;
                        data.AileronTrim = MapToFloat(value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        byte flag = dataIn[16];
                        data.LandingGearDown = (flag & (1 << 0)) != 0;
                        data.ParkingBrake = (flag & (1 << 1)) != 0;

                        byte fuelPos = AircraftData.FUEL_POSITION_OFF;
                        if ((flag & (1 << 2)) != 0) fuelPos = AircraftData.FUEL_POSITION_MAIN;
                        if ((flag & (1 << 3)) != 0) fuelPos = AircraftData.FUEL_POSITION_CROSS;
                        data.FuelLeftPosition = fuelPos;
                        
                        fuelPos = AircraftData.FUEL_POSITION_OFF;
                        if ((flag & (1 << 4)) != 0) fuelPos = AircraftData.FUEL_POSITION_MAIN;
                        if ((flag & (1 << 5)) != 0) fuelPos = AircraftData.FUEL_POSITION_CROSS;
                        data.FuelRightPosition = fuelPos;

                        flag = dataIn[17];
                        byte flapsPos = AircraftData.FLAPS_POSITION_UP;
                        if ((flag & (1 << 0)) != 0) flapsPos = AircraftData.FLAPS_POSITION_TO;
                        if ((flag & (1 << 1)) != 0) flapsPos = AircraftData.FLAPS_POSITION_APP;
                        if ((flag & (1 << 2)) != 0) flapsPos = AircraftData.FLAPS_POSITION_DOWN;
                        data.FlapsPosition = flapsPos;

                        data.Silence = (flag & (1 << 3)) != 0;
                        data.TestLamp = (flag & (1 << 4)) != 0;
                        data.MasterAvionics = (flag & (1 << 5)) != 0;
                        data.MasterBattery = (flag & (1 << 6)) != 0;

                        flag = dataIn[18];
                        data.BleedairRight = (flag & (1 << 0)) != 0;
                        data.BleedairLeft = (flag & (1 << 1)) != 0;
                        data.IgnitionRight = (flag & (1 << 2)) != 0;
                        data.IgnitionLeft = (flag & (1 << 3)) != 0;
                        data.StarterRight = (flag & (1 << 4)) != 0;
                        data.StarterLeft = (flag & (1 << 5)) != 0;


                        string message = data.ThrottleLeft.ToString() + ",";
                        message += data.ThrottleRight.ToString() + ",";
                        message += data.PitchLeft.ToString() + ",";
                        message += data.PitchRight.ToString() + ",";
                        message += data.MixtureLeft.ToString() + ",";
                        message += data.MixtureRight.ToString() + ",";
                        message += data.RudderTrim.ToString() + ",";
                        message += data.AileronTrim.ToString();

                        message += "FuelL(";
                        if (data.FuelLeftPosition == AircraftData.FUEL_POSITION_MAIN)
                        {
                            message += "M";
                        }
                        if (data.FuelLeftPosition == AircraftData.FUEL_POSITION_CROSS)
                        {
                            message += "C";
                        }
                        if (data.FuelLeftPosition == AircraftData.FUEL_POSITION_OFF)
                        {
                            message += "O";
                        }

                        message += "),FuelR(";
                        if (data.FuelRightPosition == AircraftData.FUEL_POSITION_MAIN)
                        {
                            message += "M";
                        }
                        if (data.FuelRightPosition == AircraftData.FUEL_POSITION_CROSS)
                        {
                            message += "C";
                        }
                        if (data.FuelRightPosition == AircraftData.FUEL_POSITION_OFF)
                        {
                            message += "O";
                        }
                        message += "),Flap(";
                        if (data.FlapsPosition == AircraftData.FLAPS_POSITION_UP) {
                            message += "U";
                        }
                        if (data.FlapsPosition == AircraftData.FLAPS_POSITION_TO)
                        {
                            message += "T";
                        }
                        if (data.FlapsPosition == AircraftData.FLAPS_POSITION_APP)
                        {
                            message += "A";
                        }
                        if (data.FlapsPosition == AircraftData.FLAPS_POSITION_DOWN)
                        {
                            message += "D";
                        }
                        message += ")";

                        if (data.LandingGearDown)
                        {
                            message += ",GearDown";
                        }

                        if (data.ParkingBrake)
                        {
                            message += ",Brake";
                        }

                        if (data.Silence)
                        {
                            message += ",Silence";
                        }

                        if (data.TestLamp)
                        {
                            message += ",TestLamp";
                        }

                        Action safeWrite = delegate { textBoxLogs.AppendText(message + Environment.NewLine); };
                        textBoxLogs.Invoke(safeWrite);
                    }
                    catch (TimeoutException) { }
                    catch (Exception) { }
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        /*
         * Bytes Out:
         *   1  byte Header 0xFF
         *   15 byte Instrument values
         *      (InterTurbineTempLeft, TorqueLeft, PropRpmLeft, PercentRpmLeft,
         *       FuelFlowPphLeft, OilTempLeft, OilPressLeft, InterTurbineTempRight,
         *       TorqueRight, PropRpmRight, PercentRpmRight, FuelFlowPphRigh,
         *       OilTempRight, OilPressRight, Airspeed)
         *   1  byte flags(least significant first)
         *      (Hobbs, Nose Light, Left Light, Right Light, Transition Light)
         */
        public void Write() {
            while (true)
            {
                if (_continue)
                {
                    try
                    {
                        const int itemCount = 17;
                        byte[] bytes = new byte[itemCount];

                        bytes[0] = 0xFF;

                        ConfigComponentItem item = settings.Components.IttLeft;
                        bytes[1] = MapToByte(data.InterTurbineTempLeft.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);
                        
                        item = settings.Components.TorqueLeft;
                        bytes[2] = MapToByte(data.TorqueLeft.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.PropRpmLeft;
                        bytes[3] = MapToByte(data.PropRpmLeft.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.TurbineRpmLeft;
                        bytes[4] = MapToByte(data.PercentRpmLeft.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.FuelFlowLeft;
                        bytes[5] = MapToByte(data.FuelFlowPphLeft.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.OilTempLeft;
                        bytes[6] = MapToByte(data.OilTempLeft.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.OilPressLeft;
                        bytes[7] = MapToByte(data.OilPressLeft.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.IttRight;
                        bytes[8] = MapToByte(data.InterTurbineTempRight.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.TorqueRight;
                        bytes[9] = MapToByte(data.TorqueRight.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.PropRpmRight;
                        bytes[10] = MapToByte(data.PropRpmRight.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.TurbineRpmRight;
                        bytes[11] = MapToByte(data.PercentRpmRight.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.FuelFlowRight;
                        bytes[12] = MapToByte(data.FuelFlowPphRight.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.OilTempRight;
                        bytes[13] = MapToByte(data.OilTempRight.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.OilPressRight;
                        bytes[14] = MapToByte(data.OilPressRight.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        item = settings.Components.Airspeed;
                        bytes[15] = MapToByte(data.Airspeed.Value, item.Input.From, item.Input.To, item.Output.From, item.Output.To);

                        if (data.positionToOverride > 0 && data.positionToOverride < 16)
                        {
                            bytes[data.positionToOverride] = data.debugValue;
                        }

                        byte compositeByte = 0;
                        if (data.HobbsRunning)
                        {
                            compositeByte |= HOBBS_RUNNING_FLAG;
                        }

                        if (data.LandingGearLightNose)
                        {
                            compositeByte |= GEAR_LIGHT_NOSE_FLAG;
                        }

                        if (data.LandingGearLightLeft)
                        {
                            compositeByte |= GEAR_LIGHT_LEFT_FLAG;
                        }

                        if (data.LandingGearLightRight)
                        {
                            compositeByte |= GEAR_LIGHT_RIGHT_FLAG;
                        }

                        if (data.LandingGearLightTransition)
                        {
                            compositeByte |= GEAR_LIGHT_ERROR_FLAG;
                        }

                        bytes[16] = compositeByte;
                        _serialPort.Write(bytes, 0, itemCount);

                        Thread.Sleep(100);
                    }
                    catch (TimeoutException) { }
                }
                else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        public static byte MapToByte(float value, float fromLow, float fromHigh, float toLow, float toHigh)
        {
            return Convert.ToByte(Math.Max(0, Math.Min(255, MapToFloat(value, fromLow, fromHigh, toLow, toHigh))));
        }

        public static float MapToFloat(float value, float fromLow, float fromHigh, float toLow, float toHigh)
        {
            return (value - fromLow) * (toHigh - toLow) / (fromHigh - fromLow) + toLow;
        }
    }
}
