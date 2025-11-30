using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_Interface
{
    public class AircraftData
    {
        public const byte FUEL_POSITION_OFF = 0;
        public const byte FUEL_POSITION_MAIN = 1;
        public const byte FUEL_POSITION_CROSS = 2;

        public const byte FLAPS_POSITION_UP = 0;
        public const byte FLAPS_POSITION_TO = 1;
        public const byte FLAPS_POSITION_APP = 2;
        public const byte FLAPS_POSITION_DOWN = 3;

        // from FlightGear to Arduino
        public FloatValue InterTurbineTempLeft = new FloatValue();
        public FloatValue TorqueLeft = new FloatValue();
        public FloatValue PropRpmLeft = new FloatValue();
        public FloatValue PercentRpmLeft = new FloatValue();
        public FloatValue FuelFlowPphLeft = new FloatValue();
        public FloatValue OilTempLeft = new FloatValue();
        public FloatValue OilPressLeft = new FloatValue();

        public FloatValue InterTurbineTempRight = new FloatValue();
        public FloatValue TorqueRight = new FloatValue();
        public FloatValue PropRpmRight = new FloatValue();
        public FloatValue PercentRpmRight = new FloatValue();
        public FloatValue FuelFlowPphRight = new FloatValue();
        public FloatValue OilTempRight = new FloatValue();
        public FloatValue OilPressRight = new FloatValue();

        public FloatValue Airspeed = new FloatValue();

        public bool LandingGearLightTransition;
        public bool LandingGearLightNose;
        public bool LandingGearLightLeft;
        public bool LandingGearLightRight;

        public bool HobbsRunning;

        // from Arduino to FlightGear
        public float ThrottleLeft;
        public float ThrottleRight;
        public float PitchLeft;
        public float PitchRight;
        public float MixtureLeft;
        public float MixtureRight;
        public float RudderTrim;
        public float AileronTrim;

        public byte FuelLeftPosition;
        public byte FuelRightPosition;
        public byte FlapsPosition;

        public bool LandingGearDown;
        public bool ParkingBrake;
        public bool Silence;
        public bool TestLamp;
        public bool MasterAvionics;
        public bool MasterBattery;
        public bool BleedairRight;
        public bool BleedairLeft;
        public bool IgnitionRight;
        public bool IgnitionLeft;
        public bool StarterRight;
        public bool StarterLeft;

        // Testing
        public int positionToOverride;
        public byte debugValue;
    }
}
