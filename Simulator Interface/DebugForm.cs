using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator_Interface
{
    public partial class DebugForm : Form
    {
        private AircraftData data = null;
        private ConfigSettings settings = null;

        public DebugForm(AircraftData data, ConfigSettings settings)
        {
            InitializeComponent();

            this.data = data;
            this.settings = settings;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                data.positionToOverride = Convert.ToByte(selectedIndexInput.Text);
            }
            catch (Exception ex)
            {
                data.positionToOverride = 0;
            }
        }

        private void debugValueInput_ValueChanged(object sender, EventArgs e)
        {
            data.debugValue = Convert.ToByte(debugValueInput.Text);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void RefreshData()
        {
            IttLeftMax.Text = Convert.ToString(data.InterTurbineTempLeft.Max);
            IttRightMax.Text = Convert.ToString(data.InterTurbineTempRight.Max);
            TorqueLeftMax.Text = Convert.ToString(data.TorqueLeft.Max);
            TorqueRightMax.Text = Convert.ToString(data.TorqueRight.Max);
            PropRpmLeftMax.Text = Convert.ToString(data.PropRpmLeft.Max);
            PropRpmRightMax.Text = Convert.ToString(data.PropRpmRight.Max);
            PercentRpmLeftMax.Text = Convert.ToString(data.PercentRpmLeft.Max);
            PercentRpmRightMax.Text = Convert.ToString(data.PercentRpmRight.Max);
            FuelFlowLeftMax.Text = Convert.ToString(data.FuelFlowPphLeft.Max);
            FuelFlowRightMax.Text = Convert.ToString(data.FuelFlowPphRight.Max);
            OilTempLeftMax.Text = Convert.ToString(data.OilTempLeft.Max);
            OilTempRightMax.Text = Convert.ToString(data.OilTempRight.Max);
            OilPressureLeftMax.Text = Convert.ToString(data.OilPressLeft.Max);
            OilPressureRightMax.Text = Convert.ToString(data.OilPressRight.Max);

            IttLeftMin.Text = Convert.ToString(data.InterTurbineTempLeft.Min);
            IttRightMin.Text = Convert.ToString(data.InterTurbineTempRight.Min);
            TorqueLeftMin.Text = Convert.ToString(data.TorqueLeft.Min);
            TorqueRightMin.Text = Convert.ToString(data.TorqueRight.Min);
            PropRpmLeftMin.Text = Convert.ToString(data.PropRpmLeft.Min);
            PropRpmRightMin.Text = Convert.ToString(data.PropRpmRight.Min);
            PercentRpmLeftMin.Text = Convert.ToString(data.PercentRpmLeft.Min);
            PercentRpmRightMin.Text = Convert.ToString(data.PercentRpmRight.Min);
            FuelFlowLeftMin.Text = Convert.ToString(data.FuelFlowPphLeft.Min);
            FuelFlowRightMin.Text = Convert.ToString(data.FuelFlowPphRight.Min);
            OilTempLeftMin.Text = Convert.ToString(data.OilTempLeft.Min);
            OilTempRightMin.Text = Convert.ToString(data.OilTempRight.Min);
            OilPressureLeftMin.Text = Convert.ToString(data.OilPressLeft.Min);
            OilPressureRightMin.Text = Convert.ToString(data.OilPressRight.Min);

            IttLeftValue.Text = Convert.ToString(data.InterTurbineTempLeft.Value);
            IttRightValue.Text = Convert.ToString(data.InterTurbineTempRight.Value);
            TorqueLeftValue.Text = Convert.ToString(data.TorqueLeft.Value);
            TorqueRightValue.Text = Convert.ToString(data.TorqueRight.Value);
            PropRpmLeftValue.Text = Convert.ToString(data.PropRpmLeft.Value);
            PropRpmRightValue.Text = Convert.ToString(data.PropRpmRight.Value);
            PercentRpmLeftValue.Text = Convert.ToString(data.PercentRpmLeft.Value);
            PercentRpmRightValue.Text = Convert.ToString(data.PercentRpmRight.Value);
            FuelFlowLeftValue.Text = Convert.ToString(data.FuelFlowPphLeft.Value);
            FuelFlowRightValue.Text = Convert.ToString(data.FuelFlowPphRight.Value);
            OilTempLeftValue.Text = Convert.ToString(data.OilTempLeft.Value);
            OilTempRightValue.Text = Convert.ToString(data.OilTempRight.Value);
            OilPressureLeftValue.Text = Convert.ToString(data.OilPressLeft.Value);
            OilPressureRightValue.Text = Convert.ToString(data.OilPressRight.Value);

            ConfigComponentItem component = settings.Components.IttLeft;
            IttLeftConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.InterTurbineTempLeft.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.IttRight;
            IttRightConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.InterTurbineTempRight.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.ThrottleLeft;
            TorqueLeftConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.TorqueLeft.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.TorqueRight;
            TorqueRightConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.TorqueRight.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.PropRpmLeft;
            PropRpmLeftConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.PropRpmLeft.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.PropRpmRight;
            PropRpmRightConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.PropRpmRight.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.TurbineRpmLeft;
            PercentRpmLeftConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.PercentRpmLeft.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.TurbineRpmRight;
            PercentRpmRightConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.PercentRpmRight.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.FuelFlowLeft;
            FuelFlowLeftConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.FuelFlowPphLeft.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.FuelFlowRight;
            FuelFlowRightConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.FuelFlowPphRight.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.OilTempLeft;
            OilTempLeftConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.OilTempLeft.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.OilTempRight;
            OilTempRightConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.OilTempRight.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.OilPressLeft;
            OilPressureLeftConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.OilPressLeft.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
            component = settings.Components.OilPressRight;
            OilPressureRightConversion.Text = Convert.ToString(ArduinoSerialProcessor.MapToByte(data.OilPressRight.Value, component.Input.From, component.Input.To, component.Output.From, component.Output.To));
        }
    }
}
