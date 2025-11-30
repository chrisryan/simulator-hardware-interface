namespace Simulator_Interface
{
    partial class DebugForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectedIndexInput = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.debugValueInput = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IttLeftMin = new System.Windows.Forms.TextBox();
            this.IttLeftMax = new System.Windows.Forms.TextBox();
            this.IttLeftValue = new System.Windows.Forms.TextBox();
            this.IttLeftConversion = new System.Windows.Forms.TextBox();
            this.IttRightConversion = new System.Windows.Forms.TextBox();
            this.IttRightValue = new System.Windows.Forms.TextBox();
            this.IttRightMax = new System.Windows.Forms.TextBox();
            this.IttRightMin = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TorqueRightConversion = new System.Windows.Forms.TextBox();
            this.TorqueRightValue = new System.Windows.Forms.TextBox();
            this.TorqueRightMax = new System.Windows.Forms.TextBox();
            this.TorqueRightMin = new System.Windows.Forms.TextBox();
            this.TorqueLeftConversion = new System.Windows.Forms.TextBox();
            this.TorqueLeftValue = new System.Windows.Forms.TextBox();
            this.TorqueLeftMax = new System.Windows.Forms.TextBox();
            this.TorqueLeftMin = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PercentRpmRightConversion = new System.Windows.Forms.TextBox();
            this.PercentRpmRightValue = new System.Windows.Forms.TextBox();
            this.PercentRpmRightMax = new System.Windows.Forms.TextBox();
            this.PercentRpmRightMin = new System.Windows.Forms.TextBox();
            this.PercentRpmLeftConversion = new System.Windows.Forms.TextBox();
            this.PercentRpmLeftValue = new System.Windows.Forms.TextBox();
            this.PercentRpmLeftMax = new System.Windows.Forms.TextBox();
            this.PercentRpmLeftMin = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PropRpmRightConversion = new System.Windows.Forms.TextBox();
            this.PropRpmRightValue = new System.Windows.Forms.TextBox();
            this.PropRpmRightMax = new System.Windows.Forms.TextBox();
            this.PropRpmRightMin = new System.Windows.Forms.TextBox();
            this.PropRpmLeftConversion = new System.Windows.Forms.TextBox();
            this.PropRpmLeftValue = new System.Windows.Forms.TextBox();
            this.PropRpmLeftMax = new System.Windows.Forms.TextBox();
            this.PropRpmLeftMin = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.OilPressureRightConversion = new System.Windows.Forms.TextBox();
            this.OilPressureRightValue = new System.Windows.Forms.TextBox();
            this.OilPressureRightMax = new System.Windows.Forms.TextBox();
            this.OilPressureRightMin = new System.Windows.Forms.TextBox();
            this.OilPressureLeftConversion = new System.Windows.Forms.TextBox();
            this.OilPressureLeftValue = new System.Windows.Forms.TextBox();
            this.OilPressureLeftMax = new System.Windows.Forms.TextBox();
            this.OilPressureLeftMin = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.OilTempRightConversion = new System.Windows.Forms.TextBox();
            this.OilTempRightValue = new System.Windows.Forms.TextBox();
            this.OilTempRightMax = new System.Windows.Forms.TextBox();
            this.OilTempRightMin = new System.Windows.Forms.TextBox();
            this.OilTempLeftConversion = new System.Windows.Forms.TextBox();
            this.OilTempLeftValue = new System.Windows.Forms.TextBox();
            this.OilTempLeftMax = new System.Windows.Forms.TextBox();
            this.OilTempLeftMin = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.FuelFlowRightConversion = new System.Windows.Forms.TextBox();
            this.FuelFlowRightValue = new System.Windows.Forms.TextBox();
            this.FuelFlowRightMax = new System.Windows.Forms.TextBox();
            this.FuelFlowRightMin = new System.Windows.Forms.TextBox();
            this.FuelFlowLeftConversion = new System.Windows.Forms.TextBox();
            this.FuelFlowLeftValue = new System.Windows.Forms.TextBox();
            this.FuelFlowLeftMax = new System.Windows.Forms.TextBox();
            this.FuelFlowLeftMin = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.debugValueInput)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectedIndexInput
            // 
            this.selectedIndexInput.FormattingEnabled = true;
            this.selectedIndexInput.Items.AddRange(new object[] {
            "None",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.selectedIndexInput.Location = new System.Drawing.Point(82, 29);
            this.selectedIndexInput.Name = "selectedIndexInput";
            this.selectedIndexInput.Size = new System.Drawing.Size(121, 21);
            this.selectedIndexInput.TabIndex = 1;
            this.selectedIndexInput.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Instrument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Value";
            // 
            // debugValueInput
            // 
            this.debugValueInput.Location = new System.Drawing.Point(83, 56);
            this.debugValueInput.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.debugValueInput.Name = "debugValueInput";
            this.debugValueInput.Size = new System.Drawing.Size(120, 20);
            this.debugValueInput.TabIndex = 4;
            this.debugValueInput.ValueChanged += new System.EventHandler(this.debugValueInput_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.debugValueInput);
            this.groupBox1.Controls.Add(this.selectedIndexInput);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 91);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manual Override";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ITT Left";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "ITT Right";
            // 
            // IttLeftMin
            // 
            this.IttLeftMin.Location = new System.Drawing.Point(112, 131);
            this.IttLeftMin.Name = "IttLeftMin";
            this.IttLeftMin.ReadOnly = true;
            this.IttLeftMin.Size = new System.Drawing.Size(100, 20);
            this.IttLeftMin.TabIndex = 8;
            // 
            // IttLeftMax
            // 
            this.IttLeftMax.Location = new System.Drawing.Point(218, 131);
            this.IttLeftMax.Name = "IttLeftMax";
            this.IttLeftMax.ReadOnly = true;
            this.IttLeftMax.Size = new System.Drawing.Size(100, 20);
            this.IttLeftMax.TabIndex = 9;
            // 
            // IttLeftValue
            // 
            this.IttLeftValue.Location = new System.Drawing.Point(324, 131);
            this.IttLeftValue.Name = "IttLeftValue";
            this.IttLeftValue.ReadOnly = true;
            this.IttLeftValue.Size = new System.Drawing.Size(100, 20);
            this.IttLeftValue.TabIndex = 10;
            // 
            // IttLeftConversion
            // 
            this.IttLeftConversion.Location = new System.Drawing.Point(430, 131);
            this.IttLeftConversion.Name = "IttLeftConversion";
            this.IttLeftConversion.ReadOnly = true;
            this.IttLeftConversion.Size = new System.Drawing.Size(100, 20);
            this.IttLeftConversion.TabIndex = 11;
            // 
            // IttRightConversion
            // 
            this.IttRightConversion.Location = new System.Drawing.Point(430, 158);
            this.IttRightConversion.Name = "IttRightConversion";
            this.IttRightConversion.ReadOnly = true;
            this.IttRightConversion.Size = new System.Drawing.Size(100, 20);
            this.IttRightConversion.TabIndex = 15;
            // 
            // IttRightValue
            // 
            this.IttRightValue.Location = new System.Drawing.Point(324, 158);
            this.IttRightValue.Name = "IttRightValue";
            this.IttRightValue.ReadOnly = true;
            this.IttRightValue.Size = new System.Drawing.Size(100, 20);
            this.IttRightValue.TabIndex = 14;
            // 
            // IttRightMax
            // 
            this.IttRightMax.Location = new System.Drawing.Point(218, 158);
            this.IttRightMax.Name = "IttRightMax";
            this.IttRightMax.ReadOnly = true;
            this.IttRightMax.Size = new System.Drawing.Size(100, 20);
            this.IttRightMax.TabIndex = 13;
            // 
            // IttRightMin
            // 
            this.IttRightMin.Location = new System.Drawing.Point(112, 158);
            this.IttRightMin.Name = "IttRightMin";
            this.IttRightMin.ReadOnly = true;
            this.IttRightMin.Size = new System.Drawing.Size(100, 20);
            this.IttRightMin.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(150, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Value";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(447, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Conversion";
            // 
            // TorqueRightConversion
            // 
            this.TorqueRightConversion.Location = new System.Drawing.Point(429, 211);
            this.TorqueRightConversion.Name = "TorqueRightConversion";
            this.TorqueRightConversion.ReadOnly = true;
            this.TorqueRightConversion.Size = new System.Drawing.Size(100, 20);
            this.TorqueRightConversion.TabIndex = 29;
            // 
            // TorqueRightValue
            // 
            this.TorqueRightValue.Location = new System.Drawing.Point(323, 211);
            this.TorqueRightValue.Name = "TorqueRightValue";
            this.TorqueRightValue.ReadOnly = true;
            this.TorqueRightValue.Size = new System.Drawing.Size(100, 20);
            this.TorqueRightValue.TabIndex = 28;
            // 
            // TorqueRightMax
            // 
            this.TorqueRightMax.Location = new System.Drawing.Point(217, 211);
            this.TorqueRightMax.Name = "TorqueRightMax";
            this.TorqueRightMax.ReadOnly = true;
            this.TorqueRightMax.Size = new System.Drawing.Size(100, 20);
            this.TorqueRightMax.TabIndex = 27;
            // 
            // TorqueRightMin
            // 
            this.TorqueRightMin.Location = new System.Drawing.Point(111, 211);
            this.TorqueRightMin.Name = "TorqueRightMin";
            this.TorqueRightMin.ReadOnly = true;
            this.TorqueRightMin.Size = new System.Drawing.Size(100, 20);
            this.TorqueRightMin.TabIndex = 26;
            // 
            // TorqueLeftConversion
            // 
            this.TorqueLeftConversion.Location = new System.Drawing.Point(429, 184);
            this.TorqueLeftConversion.Name = "TorqueLeftConversion";
            this.TorqueLeftConversion.ReadOnly = true;
            this.TorqueLeftConversion.Size = new System.Drawing.Size(100, 20);
            this.TorqueLeftConversion.TabIndex = 25;
            // 
            // TorqueLeftValue
            // 
            this.TorqueLeftValue.Location = new System.Drawing.Point(323, 184);
            this.TorqueLeftValue.Name = "TorqueLeftValue";
            this.TorqueLeftValue.ReadOnly = true;
            this.TorqueLeftValue.Size = new System.Drawing.Size(100, 20);
            this.TorqueLeftValue.TabIndex = 24;
            // 
            // TorqueLeftMax
            // 
            this.TorqueLeftMax.Location = new System.Drawing.Point(217, 184);
            this.TorqueLeftMax.Name = "TorqueLeftMax";
            this.TorqueLeftMax.ReadOnly = true;
            this.TorqueLeftMax.Size = new System.Drawing.Size(100, 20);
            this.TorqueLeftMax.TabIndex = 23;
            // 
            // TorqueLeftMin
            // 
            this.TorqueLeftMin.Location = new System.Drawing.Point(111, 184);
            this.TorqueLeftMin.Name = "TorqueLeftMin";
            this.TorqueLeftMin.ReadOnly = true;
            this.TorqueLeftMin.Size = new System.Drawing.Size(100, 20);
            this.TorqueLeftMin.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Torque Right";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(41, 187);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Torque Left";
            // 
            // PercentRpmRightConversion
            // 
            this.PercentRpmRightConversion.Location = new System.Drawing.Point(428, 317);
            this.PercentRpmRightConversion.Name = "PercentRpmRightConversion";
            this.PercentRpmRightConversion.ReadOnly = true;
            this.PercentRpmRightConversion.Size = new System.Drawing.Size(100, 20);
            this.PercentRpmRightConversion.TabIndex = 49;
            // 
            // PercentRpmRightValue
            // 
            this.PercentRpmRightValue.Location = new System.Drawing.Point(322, 317);
            this.PercentRpmRightValue.Name = "PercentRpmRightValue";
            this.PercentRpmRightValue.ReadOnly = true;
            this.PercentRpmRightValue.Size = new System.Drawing.Size(100, 20);
            this.PercentRpmRightValue.TabIndex = 48;
            // 
            // PercentRpmRightMax
            // 
            this.PercentRpmRightMax.Location = new System.Drawing.Point(216, 317);
            this.PercentRpmRightMax.Name = "PercentRpmRightMax";
            this.PercentRpmRightMax.ReadOnly = true;
            this.PercentRpmRightMax.Size = new System.Drawing.Size(100, 20);
            this.PercentRpmRightMax.TabIndex = 47;
            // 
            // PercentRpmRightMin
            // 
            this.PercentRpmRightMin.Location = new System.Drawing.Point(110, 317);
            this.PercentRpmRightMin.Name = "PercentRpmRightMin";
            this.PercentRpmRightMin.ReadOnly = true;
            this.PercentRpmRightMin.Size = new System.Drawing.Size(100, 20);
            this.PercentRpmRightMin.TabIndex = 46;
            // 
            // PercentRpmLeftConversion
            // 
            this.PercentRpmLeftConversion.Location = new System.Drawing.Point(428, 290);
            this.PercentRpmLeftConversion.Name = "PercentRpmLeftConversion";
            this.PercentRpmLeftConversion.ReadOnly = true;
            this.PercentRpmLeftConversion.Size = new System.Drawing.Size(100, 20);
            this.PercentRpmLeftConversion.TabIndex = 45;
            // 
            // PercentRpmLeftValue
            // 
            this.PercentRpmLeftValue.Location = new System.Drawing.Point(322, 290);
            this.PercentRpmLeftValue.Name = "PercentRpmLeftValue";
            this.PercentRpmLeftValue.ReadOnly = true;
            this.PercentRpmLeftValue.Size = new System.Drawing.Size(100, 20);
            this.PercentRpmLeftValue.TabIndex = 44;
            // 
            // PercentRpmLeftMax
            // 
            this.PercentRpmLeftMax.Location = new System.Drawing.Point(216, 290);
            this.PercentRpmLeftMax.Name = "PercentRpmLeftMax";
            this.PercentRpmLeftMax.ReadOnly = true;
            this.PercentRpmLeftMax.Size = new System.Drawing.Size(100, 20);
            this.PercentRpmLeftMax.TabIndex = 43;
            // 
            // PercentRpmLeftMin
            // 
            this.PercentRpmLeftMin.Location = new System.Drawing.Point(110, 290);
            this.PercentRpmLeftMin.Name = "PercentRpmLeftMin";
            this.PercentRpmLeftMin.ReadOnly = true;
            this.PercentRpmLeftMin.Size = new System.Drawing.Size(100, 20);
            this.PercentRpmLeftMin.TabIndex = 42;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "% RPM Right";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "% RPM Left";
            // 
            // PropRpmRightConversion
            // 
            this.PropRpmRightConversion.Location = new System.Drawing.Point(429, 264);
            this.PropRpmRightConversion.Name = "PropRpmRightConversion";
            this.PropRpmRightConversion.ReadOnly = true;
            this.PropRpmRightConversion.Size = new System.Drawing.Size(100, 20);
            this.PropRpmRightConversion.TabIndex = 39;
            // 
            // PropRpmRightValue
            // 
            this.PropRpmRightValue.Location = new System.Drawing.Point(323, 264);
            this.PropRpmRightValue.Name = "PropRpmRightValue";
            this.PropRpmRightValue.ReadOnly = true;
            this.PropRpmRightValue.Size = new System.Drawing.Size(100, 20);
            this.PropRpmRightValue.TabIndex = 38;
            // 
            // PropRpmRightMax
            // 
            this.PropRpmRightMax.Location = new System.Drawing.Point(217, 264);
            this.PropRpmRightMax.Name = "PropRpmRightMax";
            this.PropRpmRightMax.ReadOnly = true;
            this.PropRpmRightMax.Size = new System.Drawing.Size(100, 20);
            this.PropRpmRightMax.TabIndex = 37;
            // 
            // PropRpmRightMin
            // 
            this.PropRpmRightMin.Location = new System.Drawing.Point(111, 264);
            this.PropRpmRightMin.Name = "PropRpmRightMin";
            this.PropRpmRightMin.ReadOnly = true;
            this.PropRpmRightMin.Size = new System.Drawing.Size(100, 20);
            this.PropRpmRightMin.TabIndex = 36;
            // 
            // PropRpmLeftConversion
            // 
            this.PropRpmLeftConversion.Location = new System.Drawing.Point(429, 237);
            this.PropRpmLeftConversion.Name = "PropRpmLeftConversion";
            this.PropRpmLeftConversion.ReadOnly = true;
            this.PropRpmLeftConversion.Size = new System.Drawing.Size(100, 20);
            this.PropRpmLeftConversion.TabIndex = 35;
            // 
            // PropRpmLeftValue
            // 
            this.PropRpmLeftValue.Location = new System.Drawing.Point(323, 237);
            this.PropRpmLeftValue.Name = "PropRpmLeftValue";
            this.PropRpmLeftValue.ReadOnly = true;
            this.PropRpmLeftValue.Size = new System.Drawing.Size(100, 20);
            this.PropRpmLeftValue.TabIndex = 34;
            // 
            // PropRpmLeftMax
            // 
            this.PropRpmLeftMax.Location = new System.Drawing.Point(217, 237);
            this.PropRpmLeftMax.Name = "PropRpmLeftMax";
            this.PropRpmLeftMax.ReadOnly = true;
            this.PropRpmLeftMax.Size = new System.Drawing.Size(100, 20);
            this.PropRpmLeftMax.TabIndex = 33;
            // 
            // PropRpmLeftMin
            // 
            this.PropRpmLeftMin.Location = new System.Drawing.Point(111, 237);
            this.PropRpmLeftMin.Name = "PropRpmLeftMin";
            this.PropRpmLeftMin.ReadOnly = true;
            this.PropRpmLeftMin.Size = new System.Drawing.Size(100, 20);
            this.PropRpmLeftMin.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(18, 267);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Prop RPM Right";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 240);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(77, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Prop RPM Left";
            // 
            // OilPressureRightConversion
            // 
            this.OilPressureRightConversion.Location = new System.Drawing.Point(428, 478);
            this.OilPressureRightConversion.Name = "OilPressureRightConversion";
            this.OilPressureRightConversion.ReadOnly = true;
            this.OilPressureRightConversion.Size = new System.Drawing.Size(100, 20);
            this.OilPressureRightConversion.TabIndex = 79;
            // 
            // OilPressureRightValue
            // 
            this.OilPressureRightValue.Location = new System.Drawing.Point(322, 478);
            this.OilPressureRightValue.Name = "OilPressureRightValue";
            this.OilPressureRightValue.ReadOnly = true;
            this.OilPressureRightValue.Size = new System.Drawing.Size(100, 20);
            this.OilPressureRightValue.TabIndex = 78;
            // 
            // OilPressureRightMax
            // 
            this.OilPressureRightMax.Location = new System.Drawing.Point(216, 478);
            this.OilPressureRightMax.Name = "OilPressureRightMax";
            this.OilPressureRightMax.ReadOnly = true;
            this.OilPressureRightMax.Size = new System.Drawing.Size(100, 20);
            this.OilPressureRightMax.TabIndex = 77;
            // 
            // OilPressureRightMin
            // 
            this.OilPressureRightMin.Location = new System.Drawing.Point(110, 478);
            this.OilPressureRightMin.Name = "OilPressureRightMin";
            this.OilPressureRightMin.ReadOnly = true;
            this.OilPressureRightMin.Size = new System.Drawing.Size(100, 20);
            this.OilPressureRightMin.TabIndex = 76;
            // 
            // OilPressureLeftConversion
            // 
            this.OilPressureLeftConversion.Location = new System.Drawing.Point(428, 451);
            this.OilPressureLeftConversion.Name = "OilPressureLeftConversion";
            this.OilPressureLeftConversion.ReadOnly = true;
            this.OilPressureLeftConversion.Size = new System.Drawing.Size(100, 20);
            this.OilPressureLeftConversion.TabIndex = 75;
            // 
            // OilPressureLeftValue
            // 
            this.OilPressureLeftValue.Location = new System.Drawing.Point(322, 451);
            this.OilPressureLeftValue.Name = "OilPressureLeftValue";
            this.OilPressureLeftValue.ReadOnly = true;
            this.OilPressureLeftValue.Size = new System.Drawing.Size(100, 20);
            this.OilPressureLeftValue.TabIndex = 74;
            // 
            // OilPressureLeftMax
            // 
            this.OilPressureLeftMax.Location = new System.Drawing.Point(216, 451);
            this.OilPressureLeftMax.Name = "OilPressureLeftMax";
            this.OilPressureLeftMax.ReadOnly = true;
            this.OilPressureLeftMax.Size = new System.Drawing.Size(100, 20);
            this.OilPressureLeftMax.TabIndex = 73;
            // 
            // OilPressureLeftMin
            // 
            this.OilPressureLeftMin.Location = new System.Drawing.Point(110, 451);
            this.OilPressureLeftMin.Name = "OilPressureLeftMin";
            this.OilPressureLeftMin.ReadOnly = true;
            this.OilPressureLeftMin.Size = new System.Drawing.Size(100, 20);
            this.OilPressureLeftMin.TabIndex = 72;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 481);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 13);
            this.label15.TabIndex = 71;
            this.label15.Text = "Oil Press Right";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(33, 454);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "Oil Press Left";
            // 
            // OilTempRightConversion
            // 
            this.OilTempRightConversion.Location = new System.Drawing.Point(429, 425);
            this.OilTempRightConversion.Name = "OilTempRightConversion";
            this.OilTempRightConversion.ReadOnly = true;
            this.OilTempRightConversion.Size = new System.Drawing.Size(100, 20);
            this.OilTempRightConversion.TabIndex = 69;
            // 
            // OilTempRightValue
            // 
            this.OilTempRightValue.Location = new System.Drawing.Point(323, 425);
            this.OilTempRightValue.Name = "OilTempRightValue";
            this.OilTempRightValue.ReadOnly = true;
            this.OilTempRightValue.Size = new System.Drawing.Size(100, 20);
            this.OilTempRightValue.TabIndex = 68;
            // 
            // OilTempRightMax
            // 
            this.OilTempRightMax.Location = new System.Drawing.Point(217, 425);
            this.OilTempRightMax.Name = "OilTempRightMax";
            this.OilTempRightMax.ReadOnly = true;
            this.OilTempRightMax.Size = new System.Drawing.Size(100, 20);
            this.OilTempRightMax.TabIndex = 67;
            // 
            // OilTempRightMin
            // 
            this.OilTempRightMin.Location = new System.Drawing.Point(111, 425);
            this.OilTempRightMin.Name = "OilTempRightMin";
            this.OilTempRightMin.ReadOnly = true;
            this.OilTempRightMin.Size = new System.Drawing.Size(100, 20);
            this.OilTempRightMin.TabIndex = 66;
            // 
            // OilTempLeftConversion
            // 
            this.OilTempLeftConversion.Location = new System.Drawing.Point(429, 398);
            this.OilTempLeftConversion.Name = "OilTempLeftConversion";
            this.OilTempLeftConversion.ReadOnly = true;
            this.OilTempLeftConversion.Size = new System.Drawing.Size(100, 20);
            this.OilTempLeftConversion.TabIndex = 65;
            // 
            // OilTempLeftValue
            // 
            this.OilTempLeftValue.Location = new System.Drawing.Point(323, 398);
            this.OilTempLeftValue.Name = "OilTempLeftValue";
            this.OilTempLeftValue.ReadOnly = true;
            this.OilTempLeftValue.Size = new System.Drawing.Size(100, 20);
            this.OilTempLeftValue.TabIndex = 64;
            // 
            // OilTempLeftMax
            // 
            this.OilTempLeftMax.Location = new System.Drawing.Point(217, 398);
            this.OilTempLeftMax.Name = "OilTempLeftMax";
            this.OilTempLeftMax.ReadOnly = true;
            this.OilTempLeftMax.Size = new System.Drawing.Size(100, 20);
            this.OilTempLeftMax.TabIndex = 63;
            // 
            // OilTempLeftMin
            // 
            this.OilTempLeftMin.Location = new System.Drawing.Point(111, 398);
            this.OilTempLeftMin.Name = "OilTempLeftMin";
            this.OilTempLeftMin.ReadOnly = true;
            this.OilTempLeftMin.Size = new System.Drawing.Size(100, 20);
            this.OilTempLeftMin.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(25, 428);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(77, 13);
            this.label17.TabIndex = 61;
            this.label17.Text = "Oil Temp Right";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(32, 401);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 60;
            this.label18.Text = "Oil Temp Left";
            // 
            // FuelFlowRightConversion
            // 
            this.FuelFlowRightConversion.Location = new System.Drawing.Point(429, 372);
            this.FuelFlowRightConversion.Name = "FuelFlowRightConversion";
            this.FuelFlowRightConversion.ReadOnly = true;
            this.FuelFlowRightConversion.Size = new System.Drawing.Size(100, 20);
            this.FuelFlowRightConversion.TabIndex = 59;
            // 
            // FuelFlowRightValue
            // 
            this.FuelFlowRightValue.Location = new System.Drawing.Point(323, 372);
            this.FuelFlowRightValue.Name = "FuelFlowRightValue";
            this.FuelFlowRightValue.ReadOnly = true;
            this.FuelFlowRightValue.Size = new System.Drawing.Size(100, 20);
            this.FuelFlowRightValue.TabIndex = 58;
            // 
            // FuelFlowRightMax
            // 
            this.FuelFlowRightMax.Location = new System.Drawing.Point(217, 372);
            this.FuelFlowRightMax.Name = "FuelFlowRightMax";
            this.FuelFlowRightMax.ReadOnly = true;
            this.FuelFlowRightMax.Size = new System.Drawing.Size(100, 20);
            this.FuelFlowRightMax.TabIndex = 57;
            // 
            // FuelFlowRightMin
            // 
            this.FuelFlowRightMin.Location = new System.Drawing.Point(111, 372);
            this.FuelFlowRightMin.Name = "FuelFlowRightMin";
            this.FuelFlowRightMin.ReadOnly = true;
            this.FuelFlowRightMin.Size = new System.Drawing.Size(100, 20);
            this.FuelFlowRightMin.TabIndex = 56;
            // 
            // FuelFlowLeftConversion
            // 
            this.FuelFlowLeftConversion.Location = new System.Drawing.Point(429, 345);
            this.FuelFlowLeftConversion.Name = "FuelFlowLeftConversion";
            this.FuelFlowLeftConversion.ReadOnly = true;
            this.FuelFlowLeftConversion.Size = new System.Drawing.Size(100, 20);
            this.FuelFlowLeftConversion.TabIndex = 55;
            // 
            // FuelFlowLeftValue
            // 
            this.FuelFlowLeftValue.Location = new System.Drawing.Point(323, 345);
            this.FuelFlowLeftValue.Name = "FuelFlowLeftValue";
            this.FuelFlowLeftValue.ReadOnly = true;
            this.FuelFlowLeftValue.Size = new System.Drawing.Size(100, 20);
            this.FuelFlowLeftValue.TabIndex = 54;
            // 
            // FuelFlowLeftMax
            // 
            this.FuelFlowLeftMax.Location = new System.Drawing.Point(217, 345);
            this.FuelFlowLeftMax.Name = "FuelFlowLeftMax";
            this.FuelFlowLeftMax.ReadOnly = true;
            this.FuelFlowLeftMax.Size = new System.Drawing.Size(100, 20);
            this.FuelFlowLeftMax.TabIndex = 53;
            // 
            // FuelFlowLeftMin
            // 
            this.FuelFlowLeftMin.Location = new System.Drawing.Point(111, 345);
            this.FuelFlowLeftMin.Name = "FuelFlowLeftMin";
            this.FuelFlowLeftMin.ReadOnly = true;
            this.FuelFlowLeftMin.Size = new System.Drawing.Size(100, 20);
            this.FuelFlowLeftMin.TabIndex = 52;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(22, 375);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(80, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "Fuel Flow Right";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(29, 348);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "Fuel Flow Left";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(480, 516);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 80;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 551);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.OilPressureRightConversion);
            this.Controls.Add(this.OilPressureRightValue);
            this.Controls.Add(this.OilPressureRightMax);
            this.Controls.Add(this.OilPressureRightMin);
            this.Controls.Add(this.OilPressureLeftConversion);
            this.Controls.Add(this.OilPressureLeftValue);
            this.Controls.Add(this.OilPressureLeftMax);
            this.Controls.Add(this.OilPressureLeftMin);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.OilTempRightConversion);
            this.Controls.Add(this.OilTempRightValue);
            this.Controls.Add(this.OilTempRightMax);
            this.Controls.Add(this.OilTempRightMin);
            this.Controls.Add(this.OilTempLeftConversion);
            this.Controls.Add(this.OilTempLeftValue);
            this.Controls.Add(this.OilTempLeftMax);
            this.Controls.Add(this.OilTempLeftMin);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.FuelFlowRightConversion);
            this.Controls.Add(this.FuelFlowRightValue);
            this.Controls.Add(this.FuelFlowRightMax);
            this.Controls.Add(this.FuelFlowRightMin);
            this.Controls.Add(this.FuelFlowLeftConversion);
            this.Controls.Add(this.FuelFlowLeftValue);
            this.Controls.Add(this.FuelFlowLeftMax);
            this.Controls.Add(this.FuelFlowLeftMin);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.PercentRpmRightConversion);
            this.Controls.Add(this.PercentRpmRightValue);
            this.Controls.Add(this.PercentRpmRightMax);
            this.Controls.Add(this.PercentRpmRightMin);
            this.Controls.Add(this.PercentRpmLeftConversion);
            this.Controls.Add(this.PercentRpmLeftValue);
            this.Controls.Add(this.PercentRpmLeftMax);
            this.Controls.Add(this.PercentRpmLeftMin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.PropRpmRightConversion);
            this.Controls.Add(this.PropRpmRightValue);
            this.Controls.Add(this.PropRpmRightMax);
            this.Controls.Add(this.PropRpmRightMin);
            this.Controls.Add(this.PropRpmLeftConversion);
            this.Controls.Add(this.PropRpmLeftValue);
            this.Controls.Add(this.PropRpmLeftMax);
            this.Controls.Add(this.PropRpmLeftMin);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TorqueRightConversion);
            this.Controls.Add(this.TorqueRightValue);
            this.Controls.Add(this.TorqueRightMax);
            this.Controls.Add(this.TorqueRightMin);
            this.Controls.Add(this.TorqueLeftConversion);
            this.Controls.Add(this.TorqueLeftValue);
            this.Controls.Add(this.TorqueLeftMax);
            this.Controls.Add(this.TorqueLeftMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.IttRightConversion);
            this.Controls.Add(this.IttRightValue);
            this.Controls.Add(this.IttRightMax);
            this.Controls.Add(this.IttRightMin);
            this.Controls.Add(this.IttLeftConversion);
            this.Controls.Add(this.IttLeftValue);
            this.Controls.Add(this.IttLeftMax);
            this.Controls.Add(this.IttLeftMin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "DebugForm";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.debugValueInput)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox selectedIndexInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown debugValueInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IttLeftMin;
        private System.Windows.Forms.TextBox IttLeftMax;
        private System.Windows.Forms.TextBox IttLeftValue;
        private System.Windows.Forms.TextBox IttLeftConversion;
        private System.Windows.Forms.TextBox IttRightConversion;
        private System.Windows.Forms.TextBox IttRightValue;
        private System.Windows.Forms.TextBox IttRightMax;
        private System.Windows.Forms.TextBox IttRightMin;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TorqueRightConversion;
        private System.Windows.Forms.TextBox TorqueRightValue;
        private System.Windows.Forms.TextBox TorqueRightMax;
        private System.Windows.Forms.TextBox TorqueRightMin;
        private System.Windows.Forms.TextBox TorqueLeftConversion;
        private System.Windows.Forms.TextBox TorqueLeftValue;
        private System.Windows.Forms.TextBox TorqueLeftMax;
        private System.Windows.Forms.TextBox TorqueLeftMin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PercentRpmRightConversion;
        private System.Windows.Forms.TextBox PercentRpmRightValue;
        private System.Windows.Forms.TextBox PercentRpmRightMax;
        private System.Windows.Forms.TextBox PercentRpmRightMin;
        private System.Windows.Forms.TextBox PercentRpmLeftConversion;
        private System.Windows.Forms.TextBox PercentRpmLeftValue;
        private System.Windows.Forms.TextBox PercentRpmLeftMax;
        private System.Windows.Forms.TextBox PercentRpmLeftMin;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox PropRpmRightConversion;
        private System.Windows.Forms.TextBox PropRpmRightValue;
        private System.Windows.Forms.TextBox PropRpmRightMax;
        private System.Windows.Forms.TextBox PropRpmRightMin;
        private System.Windows.Forms.TextBox PropRpmLeftConversion;
        private System.Windows.Forms.TextBox PropRpmLeftValue;
        private System.Windows.Forms.TextBox PropRpmLeftMax;
        private System.Windows.Forms.TextBox PropRpmLeftMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox OilPressureRightConversion;
        private System.Windows.Forms.TextBox OilPressureRightValue;
        private System.Windows.Forms.TextBox OilPressureRightMax;
        private System.Windows.Forms.TextBox OilPressureRightMin;
        private System.Windows.Forms.TextBox OilPressureLeftConversion;
        private System.Windows.Forms.TextBox OilPressureLeftValue;
        private System.Windows.Forms.TextBox OilPressureLeftMax;
        private System.Windows.Forms.TextBox OilPressureLeftMin;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox OilTempRightConversion;
        private System.Windows.Forms.TextBox OilTempRightValue;
        private System.Windows.Forms.TextBox OilTempRightMax;
        private System.Windows.Forms.TextBox OilTempRightMin;
        private System.Windows.Forms.TextBox OilTempLeftConversion;
        private System.Windows.Forms.TextBox OilTempLeftValue;
        private System.Windows.Forms.TextBox OilTempLeftMax;
        private System.Windows.Forms.TextBox OilTempLeftMin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox FuelFlowRightConversion;
        private System.Windows.Forms.TextBox FuelFlowRightValue;
        private System.Windows.Forms.TextBox FuelFlowRightMax;
        private System.Windows.Forms.TextBox FuelFlowRightMin;
        private System.Windows.Forms.TextBox FuelFlowLeftConversion;
        private System.Windows.Forms.TextBox FuelFlowLeftValue;
        private System.Windows.Forms.TextBox FuelFlowLeftMax;
        private System.Windows.Forms.TextBox FuelFlowLeftMin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button refreshButton;
    }
}