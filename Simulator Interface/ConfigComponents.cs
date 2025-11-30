using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_Interface
{
    public class ConfigComponents
    {
        public ConfigComponentItem IttLeft { get; set; }
        public ConfigComponentItem IttRight { get; set; }

        public ConfigComponentItem TorqueLeft { get; set; }
        public ConfigComponentItem TorqueRight { get; set; }

        public ConfigComponentItem PropRpmLeft { get; set; }
        public ConfigComponentItem PropRpmRight { get; set; }

        public ConfigComponentItem TurbineRpmLeft { get; set; }
        public ConfigComponentItem TurbineRpmRight { get; set; }

        public ConfigComponentItem FuelFlowLeft { get; set; }
        public ConfigComponentItem FuelFlowRight { get; set; }

        public ConfigComponentItem OilTempLeft { get; set; }
        public ConfigComponentItem OilTempRight { get; set; }

        public ConfigComponentItem OilPressLeft { get; set; }
        public ConfigComponentItem OilPressRight { get; set; }

        public ConfigComponentItem Airspeed { get; set; }

        public ConfigComponentItem ThrottleLeft { get; set; }
        public ConfigComponentItem ThrottleRight { get; set; }

        public ConfigComponentItem PitchLeft { get; set; }
        public ConfigComponentItem PitchRight { get; set; }

        public ConfigComponentItem MixtureLeft { get; set; }
        public ConfigComponentItem MixtureRight { get; set; }

        public ConfigComponentItem RudderTrim { get; set; }

        public ConfigComponentItem AileronTrim { get; set; }
    }
}
