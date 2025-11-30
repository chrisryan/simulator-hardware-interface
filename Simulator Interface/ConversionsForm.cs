using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator_Interface
{
    public partial class ConversionsForm : Form
    {
        private ConfigSettings settings;

        public ConversionsForm(ConfigSettings settings)
        {
            this.settings = settings;
            InitializeComponent();

            ittLeftInputFrom.Text = settings.Components.IttLeft.Input.From.ToString();
            ittLeftInputTo.Text = settings.Components.IttLeft.Input.To.ToString();
            ittLeftOutputFrom.Text = settings.Components.IttLeft.Output.From.ToString();
            ittLeftOutputTo.Text = settings.Components.IttLeft.Output.To.ToString();

            ittRightInputFrom.Text = settings.Components.IttRight.Input.From.ToString();
            ittRightInputTo.Text = settings.Components.IttRight.Input.To.ToString();
            ittRightOutputFrom.Text = settings.Components.IttRight.Output.From.ToString();
            ittRightOutputTo.Text = settings.Components.IttRight.Output.To.ToString();

            torqueLeftInputFrom.Text = settings.Components.TorqueLeft.Input.From.ToString();
            torqueLeftInputTo.Text = settings.Components.TorqueLeft.Input.To.ToString();
            torqueLeftOutputFrom.Text = settings.Components.TorqueLeft.Output.From.ToString();
            torqueLeftOutputTo.Text = settings.Components.TorqueLeft.Output.To.ToString();

            torqueRightInputFrom.Text = settings.Components.TorqueRight.Input.From.ToString();
            torqueRightInputTo.Text = settings.Components.TorqueRight.Input.To.ToString();
            torqueRightOutputFrom.Text = settings.Components.TorqueRight.Output.From.ToString();
            torqueRightOutputTo.Text = settings.Components.TorqueRight.Output.To.ToString();

            propRpmLeftInputFrom.Text = settings.Components.PropRpmLeft.Input.From.ToString();
            propRpmLeftInputTo.Text = settings.Components.PropRpmLeft.Input.To.ToString();
            propRpmLeftOutputFrom.Text = settings.Components.PropRpmLeft.Output.From.ToString();
            propRpmLeftOutputTo.Text = settings.Components.PropRpmLeft.Output.To.ToString();

            propRpmRightInputFrom.Text = settings.Components.PropRpmRight.Input.From.ToString();
            propRpmRightInputTo.Text = settings.Components.PropRpmRight.Input.To.ToString();
            propRpmRightOutputFrom.Text = settings.Components.PropRpmRight.Output.From.ToString();
            propRpmRightOutputTo.Text = settings.Components.PropRpmRight.Output.To.ToString();

            percentRpmLeftInputFrom.Text = settings.Components.TurbineRpmLeft.Input.From.ToString();
            percentRpmLeftInputTo.Text = settings.Components.TurbineRpmLeft.Input.To.ToString();
            percentRpmLeftOutputFrom.Text = settings.Components.TurbineRpmLeft.Output.From.ToString();
            percentRpmLeftOutputTo.Text = settings.Components.TurbineRpmLeft.Output.To.ToString();

            percentRpmRightInputFrom.Text = settings.Components.TurbineRpmRight.Input.From.ToString();
            percentRpmRightInputTo.Text = settings.Components.TurbineRpmRight.Input.To.ToString();
            percentRpmRightOutputFrom.Text = settings.Components.TurbineRpmRight.Output.From.ToString();
            percentRpmRightOutputTo.Text = settings.Components.TurbineRpmRight.Output.To.ToString();

            fuelFlowPphLeftInputFrom.Text = settings.Components.FuelFlowLeft.Input.From.ToString();
            fuelFlowPphLeftInputTo.Text = settings.Components.FuelFlowLeft.Input.To.ToString();
            fuelFlowPphLeftOutputFrom.Text = settings.Components.FuelFlowLeft.Output.From.ToString();
            fuelFlowPphLeftOutputTo.Text = settings.Components.FuelFlowLeft.Output.To.ToString();

            fuelFlowPphRightInputFrom.Text = settings.Components.FuelFlowRight.Input.From.ToString();
            fuelFlowPphRightInputTo.Text = settings.Components.FuelFlowRight.Input.To.ToString();
            fuelFlowPphRightOutputFrom.Text = settings.Components.FuelFlowRight.Output.From.ToString();
            fuelFlowPphRightOutputTo.Text = settings.Components.FuelFlowRight.Output.To.ToString();

            oilTempLeftInputFrom.Text = settings.Components.OilTempLeft.Input.From.ToString();
            oilTempLeftInputTo.Text = settings.Components.OilTempLeft.Input.To.ToString();
            oilTempLeftOutputFrom.Text = settings.Components.OilTempLeft.Output.From.ToString();
            oilTempLeftOutputTo.Text = settings.Components.OilTempLeft.Output.To.ToString();

            oilTempRightInputFrom.Text = settings.Components.OilTempRight.Input.From.ToString();
            oilTempRightInputTo.Text = settings.Components.OilTempRight.Input.To.ToString();
            oilTempRightOutputFrom.Text = settings.Components.OilTempRight.Output.From.ToString();
            oilTempRightOutputTo.Text = settings.Components.OilTempRight.Output.To.ToString();

            oilPressureLeftInputFrom.Text = settings.Components.OilPressLeft.Input.From.ToString();
            oilPressureLeftInputTo.Text = settings.Components.OilPressLeft.Input.To.ToString();
            oilPressureLeftOutputFrom.Text = settings.Components.OilPressLeft.Output.From.ToString();
            oilPressureLeftOutputTo.Text = settings.Components.OilPressLeft.Output.To.ToString();

            oilPressureRightInputFrom.Text = settings.Components.OilPressRight.Input.From.ToString();
            oilPressureRightInputTo.Text = settings.Components.OilPressRight.Input.To.ToString();
            oilPressureRightOutputFrom.Text = settings.Components.OilPressRight.Output.From.ToString();
            oilPressureRightOutputTo.Text = settings.Components.OilPressRight.Output.To.ToString();

            airspeedInputFrom.Text = settings.Components.Airspeed.Input.From.ToString();
            airspeedInputTo.Text = settings.Components.Airspeed.Input.To.ToString();
            airspeedOutputFrom.Text = settings.Components.Airspeed.Output.From.ToString();
            airspeedOutputTo.Text = settings.Components.Airspeed.Output.To.ToString();

            throttleLeftInputFrom.Text = settings.Components.ThrottleLeft.Input.From.ToString();
            throttleLeftInputTo.Text = settings.Components.ThrottleLeft.Input.To.ToString();
            throttleLeftOutputFrom.Text = settings.Components.ThrottleLeft.Output.From.ToString();
            throttleLeftOutputTo.Text = settings.Components.ThrottleLeft.Output.To.ToString();

            throttleRightInputFrom.Text = settings.Components.ThrottleRight.Input.From.ToString();
            throttleRightInputTo.Text = settings.Components.ThrottleRight.Input.To.ToString();
            throttleRightOutputFrom.Text = settings.Components.ThrottleRight.Output.From.ToString();
            throttleRightOutputTo.Text = settings.Components.ThrottleRight.Output.To.ToString();

            pitchLeftInputFrom.Text = settings.Components.PitchLeft.Input.From.ToString();
            pitchLeftInputTo.Text = settings.Components.PitchLeft.Input.To.ToString();
            pitchLeftOutputFrom.Text = settings.Components.PitchLeft.Output.From.ToString();
            pitchLeftOutputTo.Text = settings.Components.PitchLeft.Output.To.ToString();

            pitchRightInputFrom.Text = settings.Components.PitchRight.Input.From.ToString();
            pitchRightInputTo.Text = settings.Components.PitchRight.Input.To.ToString();
            pitchRightOutputFrom.Text = settings.Components.PitchRight.Output.From.ToString();
            pitchRightOutputTo.Text = settings.Components.PitchRight.Output.To.ToString();

            mixtureLeftInputFrom.Text = settings.Components.MixtureLeft.Input.From.ToString();
            mixtureLeftInputTo.Text = settings.Components.MixtureLeft.Input.To.ToString();
            mixtureLeftOutputFrom.Text = settings.Components.MixtureLeft.Output.From.ToString();
            mixtureLeftOutputTo.Text = settings.Components.MixtureLeft.Output.To.ToString();

            mixtureRightInputFrom.Text = settings.Components.MixtureRight.Input.From.ToString();
            mixtureRightInputTo.Text = settings.Components.MixtureRight.Input.To.ToString();
            mixtureRightOutputFrom.Text = settings.Components.MixtureRight.Output.From.ToString();
            mixtureRightOutputTo.Text = settings.Components.MixtureRight.Output.To.ToString();

            rudderTrimInputFrom.Text = settings.Components.RudderTrim.Input.From.ToString();
            rudderTrimInputTo.Text = settings.Components.RudderTrim.Input.To.ToString();
            rudderTrimOutputFrom.Text = settings.Components.RudderTrim.Output.From.ToString();
            rudderTrimOutputTo.Text = settings.Components.RudderTrim.Output.To.ToString();

            aileronTrimInputFrom.Text = settings.Components.AileronTrim.Input.From.ToString();
            aileronTrimInputTo.Text = settings.Components.AileronTrim.Input.To.ToString();
            aileronTrimOutputFrom.Text = settings.Components.AileronTrim.Output.From.ToString();
            aileronTrimOutputTo.Text = settings.Components.AileronTrim.Output.To.ToString();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            settings.Components.IttLeft.Input.From = float.Parse(ittLeftInputFrom.Text);
            settings.Components.IttLeft.Input.To = float.Parse(ittLeftInputTo.Text);
            settings.Components.IttLeft.Output.From = float.Parse(ittLeftOutputFrom.Text);
            settings.Components.IttLeft.Output.To = float.Parse(ittLeftOutputTo.Text);

            settings.Components.IttRight.Input.From = float.Parse(ittRightInputFrom.Text);
            settings.Components.IttRight.Input.To = float.Parse(ittRightInputTo.Text);
            settings.Components.IttRight.Output.From = float.Parse(ittRightOutputFrom.Text);
            settings.Components.IttRight.Output.To = float.Parse(ittRightOutputTo.Text);

            settings.Components.TorqueLeft.Input.From = float.Parse(torqueLeftInputFrom.Text);
            settings.Components.TorqueLeft.Input.To = float.Parse(torqueLeftInputTo.Text);
            settings.Components.TorqueLeft.Output.From = float.Parse(torqueLeftOutputFrom.Text);
            settings.Components.TorqueLeft.Output.To = float.Parse(torqueLeftOutputTo.Text);

            settings.Components.TorqueRight.Input.From = float.Parse(torqueRightInputFrom.Text);
            settings.Components.TorqueRight.Input.To = float.Parse(torqueRightInputTo.Text);
            settings.Components.TorqueRight.Output.From = float.Parse(torqueRightOutputFrom.Text);
            settings.Components.TorqueRight.Output.To = float.Parse(torqueRightOutputTo.Text);

            settings.Components.PropRpmLeft.Input.From = float.Parse(propRpmLeftInputFrom.Text);
            settings.Components.PropRpmLeft.Input.To = float.Parse(propRpmLeftInputTo.Text);
            settings.Components.PropRpmLeft.Output.From = float.Parse(propRpmLeftOutputFrom.Text);
            settings.Components.PropRpmLeft.Output.To = float.Parse(propRpmLeftOutputTo.Text);

            settings.Components.PropRpmRight.Input.From = float.Parse(propRpmRightInputFrom.Text);
            settings.Components.PropRpmRight.Input.To = float.Parse(propRpmRightInputTo.Text);
            settings.Components.PropRpmRight.Output.From = float.Parse(propRpmRightOutputFrom.Text);
            settings.Components.PropRpmRight.Output.To = float.Parse(propRpmRightOutputTo.Text);

            settings.Components.TurbineRpmLeft.Input.From = float.Parse(percentRpmLeftInputFrom.Text);
            settings.Components.TurbineRpmLeft.Input.To = float.Parse(percentRpmLeftInputTo.Text);
            settings.Components.TurbineRpmLeft.Output.From = float.Parse(percentRpmLeftOutputFrom.Text);
            settings.Components.TurbineRpmLeft.Output.To = float.Parse(percentRpmLeftOutputTo.Text);

            settings.Components.TurbineRpmRight.Input.From = float.Parse(percentRpmRightInputFrom.Text);
            settings.Components.TurbineRpmRight.Input.To = float.Parse(percentRpmRightInputTo.Text);
            settings.Components.TurbineRpmRight.Output.From = float.Parse(percentRpmRightOutputFrom.Text);
            settings.Components.TurbineRpmRight.Output.To = float.Parse(percentRpmRightOutputTo.Text);

            settings.Components.FuelFlowLeft.Input.From = float.Parse(fuelFlowPphLeftInputFrom.Text);
            settings.Components.FuelFlowLeft.Input.To = float.Parse(fuelFlowPphLeftInputTo.Text);
            settings.Components.FuelFlowLeft.Output.From = float.Parse(fuelFlowPphLeftOutputFrom.Text);
            settings.Components.FuelFlowLeft.Output.To = float.Parse(fuelFlowPphLeftOutputTo.Text);

            settings.Components.FuelFlowRight.Input.From = float.Parse(fuelFlowPphRightInputFrom.Text);
            settings.Components.FuelFlowRight.Input.To = float.Parse(fuelFlowPphRightInputTo.Text);
            settings.Components.FuelFlowRight.Output.From = float.Parse(fuelFlowPphRightOutputFrom.Text);
            settings.Components.FuelFlowRight.Output.To = float.Parse(fuelFlowPphRightOutputTo.Text);

            settings.Components.OilTempLeft.Input.From = float.Parse(oilTempLeftInputFrom.Text);
            settings.Components.OilTempLeft.Input.To = float.Parse(oilTempLeftInputTo.Text);
            settings.Components.OilTempLeft.Output.From = float.Parse(oilTempLeftOutputFrom.Text);
            settings.Components.OilTempLeft.Output.To = float.Parse(oilTempLeftOutputTo.Text);

            settings.Components.OilTempRight.Input.From = float.Parse(oilTempRightInputFrom.Text);
            settings.Components.OilTempRight.Input.To = float.Parse(oilTempRightInputTo.Text);
            settings.Components.OilTempRight.Output.From = float.Parse(oilTempRightOutputFrom.Text);
            settings.Components.OilTempRight.Output.To = float.Parse(oilTempRightOutputTo.Text);

            settings.Components.OilPressLeft.Input.From = float.Parse(oilPressureLeftInputFrom.Text);
            settings.Components.OilPressLeft.Input.To = float.Parse(oilPressureLeftInputTo.Text);
            settings.Components.OilPressLeft.Output.From = float.Parse(oilPressureLeftOutputFrom.Text);
            settings.Components.OilPressLeft.Output.To = float.Parse(oilPressureLeftOutputTo.Text);

            settings.Components.OilPressRight.Input.From = float.Parse(oilPressureRightInputFrom.Text);
            settings.Components.OilPressRight.Input.To = float.Parse(oilPressureRightInputTo.Text);
            settings.Components.OilPressRight.Output.From = float.Parse(oilPressureRightOutputFrom.Text);
            settings.Components.OilPressRight.Output.To = float.Parse(oilPressureRightOutputTo.Text);

            settings.Components.Airspeed.Input.From = float.Parse(airspeedInputFrom.Text);
            settings.Components.Airspeed.Input.To = float.Parse(airspeedInputTo.Text);
            settings.Components.Airspeed.Output.From = float.Parse(airspeedOutputFrom.Text);
            settings.Components.Airspeed.Output.To = float.Parse(airspeedOutputTo.Text);

            settings.Components.ThrottleLeft.Input.From = float.Parse(throttleLeftInputFrom.Text);
            settings.Components.ThrottleLeft.Input.To = float.Parse(throttleLeftInputTo.Text);
            settings.Components.ThrottleLeft.Output.From = float.Parse(throttleLeftOutputFrom.Text);
            settings.Components.ThrottleLeft.Output.To = float.Parse(throttleLeftOutputTo.Text);

            settings.Components.ThrottleRight.Input.From = float.Parse(throttleRightInputFrom.Text);
            settings.Components.ThrottleRight.Input.To = float.Parse(throttleRightInputTo.Text);
            settings.Components.ThrottleRight.Output.From = float.Parse(throttleRightOutputFrom.Text);
            settings.Components.ThrottleRight.Output.To = float.Parse(throttleRightOutputTo.Text);

            settings.Components.PitchLeft.Input.From = float.Parse(pitchLeftInputFrom.Text);
            settings.Components.PitchLeft.Input.To = float.Parse(pitchLeftInputTo.Text);
            settings.Components.PitchLeft.Output.From = float.Parse(pitchLeftOutputFrom.Text);
            settings.Components.PitchLeft.Output.To = float.Parse(pitchLeftOutputTo.Text);

            settings.Components.PitchRight.Input.From = float.Parse(pitchRightInputFrom.Text);
            settings.Components.PitchRight.Input.To = float.Parse(pitchRightInputTo.Text);
            settings.Components.PitchRight.Output.From = float.Parse(pitchRightOutputFrom.Text);
            settings.Components.PitchRight.Output.To = float.Parse(pitchRightOutputTo.Text);

            settings.Components.MixtureLeft.Input.From = float.Parse(mixtureLeftInputFrom.Text);
            settings.Components.MixtureLeft.Input.To = float.Parse(mixtureLeftInputTo.Text);
            settings.Components.MixtureLeft.Output.From = float.Parse(mixtureLeftOutputFrom.Text);
            settings.Components.MixtureLeft.Output.To = float.Parse(mixtureLeftOutputTo.Text);

            settings.Components.MixtureRight.Input.From = float.Parse(mixtureRightInputFrom.Text);
            settings.Components.MixtureRight.Input.To = float.Parse(mixtureRightInputTo.Text);
            settings.Components.MixtureRight.Output.From = float.Parse(mixtureRightOutputFrom.Text);
            settings.Components.MixtureRight.Output.To = float.Parse(mixtureRightOutputTo.Text);

            settings.Components.RudderTrim.Input.From = float.Parse(rudderTrimInputFrom.Text);
            settings.Components.RudderTrim.Input.To = float.Parse(rudderTrimInputTo.Text);
            settings.Components.RudderTrim.Output.From = float.Parse(rudderTrimOutputFrom.Text);
            settings.Components.RudderTrim.Output.To = float.Parse(rudderTrimOutputTo.Text);

            settings.Components.AileronTrim.Input.From = float.Parse(aileronTrimInputFrom.Text);
            settings.Components.AileronTrim.Input.To = float.Parse(aileronTrimInputTo.Text);
            settings.Components.AileronTrim.Output.From = float.Parse(aileronTrimOutputFrom.Text);
            settings.Components.AileronTrim.Output.To = float.Parse(aileronTrimOutputTo.Text);

            ConfigManager.SaveSettings(settings);
        }
    }
}
