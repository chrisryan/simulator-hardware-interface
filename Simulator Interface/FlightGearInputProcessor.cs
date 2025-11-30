using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulator_Interface
{
    internal class FlightGearInputProcessor
    {
        private UdpClient udpClient = null;
        private IPEndPoint ipEndpoint = null;
        private IAsyncResult syncResult = null;
        private bool stopReading = true;
        private TextBox textBoxLogs = null;
        private AircraftData data = null;

        public FlightGearInputProcessor(AircraftData data, TextBox textBoxLogs)
        {
            this.textBoxLogs = textBoxLogs;
            this.data = data;
        }

        public void ReceiveCallback(IAsyncResult result)
        {
            if (udpClient == null || stopReading)
            {
                return;
            }

            byte[] receiveBytes = udpClient.EndReceive(syncResult, ref ipEndpoint);
            string receiveString = Encoding.ASCII.GetString(receiveBytes);

            Action safeWrite = delegate { textBoxLogs.AppendText(receiveString + Environment.NewLine); };
            textBoxLogs.Invoke(safeWrite);

            string[] items = receiveString.Split(',');
            float[] values = new float[items.Length];
            for (int i = 0; i < items.Length; i++)
            {
                float f = 0;
                if (float.TryParse(items[i], out f)) {
                    values[i] = f;
                }
            }

            data.InterTurbineTempLeft.Value = values[0];
            data.TorqueLeft.Value = values[1];
            data.PropRpmLeft.Value = values[2];
            data.PercentRpmLeft.Value = values[3];
            data.FuelFlowPphLeft.Value = values[4];
            data.OilTempLeft.Value = values[5];
            data.OilPressLeft.Value = values[6];
            data.InterTurbineTempRight.Value = values[7];
            data.TorqueRight.Value = values[8];
            data.PropRpmRight.Value = values[9];
            data.PercentRpmRight.Value = values[10];
            data.FuelFlowPphRight.Value = values[11];
            data.OilTempRight.Value = values[12];
            data.OilPressRight.Value = values[13];
            data.Airspeed.Value = values[14];
            data.LandingGearLightTransition = Convert.ToBoolean(values[15]);
            data.LandingGearLightNose = Convert.ToBoolean(values[16]);
            data.LandingGearLightLeft = Convert.ToBoolean(values[17]);
            data.LandingGearLightRight = Convert.ToBoolean(values[18]);
            data.HobbsRunning = Convert.ToBoolean(values[19]);

            syncResult = udpClient.BeginReceive(ReceiveCallback, null);
        }

        public void Start(int port)
        {
            if (Running())
            {
                return;
            }

            stopReading = false;
            
            //IPAddress[] ipAddresses = Dns.GetHostAddresses(textBoxReceiveHost.Text);
            //ipEndpoint = new IPEndPoint(ipAddresses[0], port);
            ipEndpoint = new IPEndPoint(IPAddress.Any, port);
            udpClient = new UdpClient(ipEndpoint);
            syncResult = udpClient.BeginReceive(ReceiveCallback, null);            
        }

        public void Stop()
        {
            if (!Running())
            {
                return;
            }

            stopReading = true;
            
            udpClient.Close();
            ipEndpoint = null;
            udpClient = null;
        }

        public bool Running()
        {
            return udpClient != null;
        }
    }
}
