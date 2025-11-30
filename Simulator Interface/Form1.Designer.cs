namespace Simulator_Interface
{
    partial class Form1
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
            this.textBoxLogs = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRunStop = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBoxReceiveHost = new System.Windows.Forms.TextBox();
            this.textBoxReceivePort = new System.Windows.Forms.TextBox();
            this.textBoxTransmitHost = new System.Windows.Forms.TextBox();
            this.textBoxTransmitPort = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelSerialPort = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.serialPort = new System.Windows.Forms.ComboBox();
            this.debugButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.textBoxLogs, 4);
            this.textBoxLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxLogs.Location = new System.Drawing.Point(3, 103);
            this.textBoxLogs.MinimumSize = new System.Drawing.Size(100, 100);
            this.textBoxLogs.Multiline = true;
            this.textBoxLogs.Name = "textBoxLogs";
            this.textBoxLogs.ReadOnly = true;
            this.textBoxLogs.Size = new System.Drawing.Size(694, 222);
            this.textBoxLogs.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Receive On";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Location = new System.Drawing.Point(27, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Transmit To";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(96, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(505, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Port";
            // 
            // buttonRunStop
            // 
            this.buttonRunStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunStop.Location = new System.Drawing.Point(622, 45);
            this.buttonRunStop.Name = "buttonRunStop";
            this.buttonRunStop.Size = new System.Drawing.Size(75, 23);
            this.buttonRunStop.TabIndex = 5;
            this.buttonRunStop.Text = "Run";
            this.buttonRunStop.UseVisualStyleBackColor = true;
            this.buttonRunStop.Click += new System.EventHandler(this.buttonRunStop_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.buttonClear, 2);
            this.buttonClear.Location = new System.Drawing.Point(592, 331);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(105, 24);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBoxReceiveHost
            // 
            this.textBoxReceiveHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceiveHost.Location = new System.Drawing.Point(96, 16);
            this.textBoxReceiveHost.Name = "textBoxReceiveHost";
            this.textBoxReceiveHost.ReadOnly = true;
            this.textBoxReceiveHost.Size = new System.Drawing.Size(403, 20);
            this.textBoxReceiveHost.TabIndex = 1;
            this.textBoxReceiveHost.Text = "Any";
            // 
            // textBoxReceivePort
            // 
            this.textBoxReceivePort.Location = new System.Drawing.Point(505, 16);
            this.textBoxReceivePort.Name = "textBoxReceivePort";
            this.textBoxReceivePort.Size = new System.Drawing.Size(111, 20);
            this.textBoxReceivePort.TabIndex = 2;
            this.textBoxReceivePort.Text = "6789";
            // 
            // textBoxTransmitHost
            // 
            this.textBoxTransmitHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTransmitHost.Location = new System.Drawing.Point(96, 45);
            this.textBoxTransmitHost.Name = "textBoxTransmitHost";
            this.textBoxTransmitHost.Size = new System.Drawing.Size(403, 20);
            this.textBoxTransmitHost.TabIndex = 3;
            this.textBoxTransmitHost.Text = "localhost";
            // 
            // textBoxTransmitPort
            // 
            this.textBoxTransmitPort.Location = new System.Drawing.Point(505, 45);
            this.textBoxTransmitPort.Name = "textBoxTransmitPort";
            this.textBoxTransmitPort.Size = new System.Drawing.Size(111, 20);
            this.textBoxTransmitPort.TabIndex = 4;
            this.textBoxTransmitPort.Text = "6790";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelSerialPort, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.buttonRunStop, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxLogs, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTransmitHost, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.buttonClear, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.textBoxTransmitPort, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxReceiveHost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxReceivePort, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.settingsButton, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.serialPort, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.debugButton, 3, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(700, 358);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // labelSerialPort
            // 
            this.labelSerialPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSerialPort.AutoSize = true;
            this.labelSerialPort.Enabled = false;
            this.labelSerialPort.Location = new System.Drawing.Point(3, 71);
            this.labelSerialPort.Name = "labelSerialPort";
            this.labelSerialPort.Size = new System.Drawing.Size(87, 29);
            this.labelSerialPort.TabIndex = 8;
            this.labelSerialPort.Text = "Serial Comm Port";
            this.labelSerialPort.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.Location = new System.Drawing.Point(622, 16);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(75, 23);
            this.settingsButton.TabIndex = 7;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // serialPort
            // 
            this.serialPort.FormattingEnabled = true;
            this.serialPort.Location = new System.Drawing.Point(96, 74);
            this.serialPort.Name = "serialPort";
            this.serialPort.Size = new System.Drawing.Size(121, 21);
            this.serialPort.TabIndex = 9;
            this.serialPort.SelectedIndexChanged += new System.EventHandler(this.serialPort_SelectedIndexChanged);
            // 
            // debugButton
            // 
            this.debugButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.debugButton.Location = new System.Drawing.Point(622, 74);
            this.debugButton.Name = "debugButton";
            this.debugButton.Size = new System.Drawing.Size(75, 23);
            this.debugButton.TabIndex = 10;
            this.debugButton.Text = "Debug";
            this.debugButton.UseVisualStyleBackColor = true;
            this.debugButton.Click += new System.EventHandler(this.debugButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 358);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Simulator Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRunStop;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBoxReceiveHost;
        private System.Windows.Forms.TextBox textBoxReceivePort;
        private System.Windows.Forms.TextBox textBoxTransmitHost;
        private System.Windows.Forms.TextBox textBoxTransmitPort;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label labelSerialPort;
        private System.Windows.Forms.ComboBox serialPort;
        private System.Windows.Forms.Button debugButton;
    }
}

