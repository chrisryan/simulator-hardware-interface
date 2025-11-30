using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulator_Interface
{
    public class FloatValue
    {
        private float _value;
        private bool _minSet = false;
        private bool _maxSet = false;

        public float Value
        {
            get => _value;
            set
            {
                _value = value;
                if (value < Min || !_minSet)
                {
                    _minSet = true;
                    Min = value;
                }

                if (value > Max || !_maxSet)
                {
                    _maxSet = true;
                    Max = value;
                }
            }
        }
        public float Min {  get; set; }
        public float Max { get; set; }
    }
}
