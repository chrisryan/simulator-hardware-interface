using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Simulator_Interface
{
    public partial class Form1 : Form
    {
        private FlightGearInputProcessor fgInputProcessor;
        private ArduinoSerialProcessor arduinoProcessor;
        private AircraftData data = null;
        private ConfigSettings settings = null;

        public Form1()
        {
            InitializeComponent();
            data = new AircraftData();
            settings = ConfigManager.LoadSettings();
            fgInputProcessor = new FlightGearInputProcessor(data, textBoxLogs);
            arduinoProcessor = new ArduinoSerialProcessor(data, textBoxLogs, settings);
            populateSerialCommPortValues();
        }

        private void populateSerialCommPortValues()
        {
            string[] ports = SerialPort.GetPortNames();
            if (settings.Communications != null && settings.Communications.SerialPort != null && settings.Communications.SerialPort.Length > 0)
            {
                serialPort.Text = settings.Communications.SerialPort;
            }

            foreach (string port in ports)
            {
                serialPort.Items.Add(port);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxLogs.AppendText("Waiting..." + Environment.NewLine);
        }

        private void buttonRunStop_Click(object sender, EventArgs e)
        {
            if (fgInputProcessor.Running())
            {
                textBoxLogs.AppendText("Closing connection..." + Environment.NewLine);
                fgInputProcessor.Stop();
                arduinoProcessor.Stop();
                buttonRunStop.Text = "Run";
            } else
            {
                textBoxLogs.AppendText("Starting connection..." + Environment.NewLine); 
                fgInputProcessor.Start(Convert.ToInt32(textBoxReceivePort.Text));
                arduinoProcessor.Start();
                buttonRunStop.Text = "Stop";
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxLogs.Clear();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            ConversionsForm form = new ConversionsForm(settings);
            form.ShowDialog();
        }

        private void serialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            settings.Communications.SerialPort = serialPort.Text;
        }

        private void debugButton_Click(object sender, EventArgs e)
        {
            DebugForm form = new DebugForm(data, settings);
            form.ShowDialog();
        }
    }
}
