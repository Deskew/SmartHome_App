namespace SmartHome_App
{
    partial class MonitoringForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MonitoringForm));
            this.Port_textBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IPAdress_textBoxX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.RedBubble_button = new DevComponents.DotNetBar.ButtonX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.superValidator1 = new DevComponents.DotNetBar.Validator.SuperValidator();
            this.requiredFieldValidator2 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("端口号不能为空.");
            this.requiredFieldValidator1 = new DevComponents.DotNetBar.Validator.RequiredFieldValidator("IP地址不能为空.");
            this.highlighter1 = new DevComponents.DotNetBar.Validator.Highlighter();
            this.ConnectToDevice_buttonX = new DevComponents.DotNetBar.ButtonX();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.Interval_NumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.Interval_trackBar = new System.Windows.Forms.TrackBar();
            this.HumidityValue_labelX = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.GasValue_labelX = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.PersonValue_labelX = new DevComponents.DotNetBar.LabelX();
            this.TemperatureValue_labelX = new DevComponents.DotNetBar.LabelX();
            this.StartDetect_buttonX = new DevComponents.DotNetBar.ButtonX();
            this.Gass_labelX = new DevComponents.DotNetBar.LabelX();
            this.Person_labelX = new DevComponents.DotNetBar.LabelX();
            this.Humidity_labelX = new DevComponents.DotNetBar.LabelX();
            this.Temperature_labelX = new DevComponents.DotNetBar.LabelX();
            this.Receive_backgroundWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_NumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // Port_textBoxX
            // 
            this.Port_textBoxX.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.Port_textBoxX.Border.Class = "TextBoxBorder";
            this.Port_textBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Port_textBoxX.DisabledBackColor = System.Drawing.Color.White;
            this.Port_textBoxX.ForeColor = System.Drawing.Color.Black;
            this.Port_textBoxX.Location = new System.Drawing.Point(105, 55);
            this.Port_textBoxX.Name = "Port_textBoxX";
            this.Port_textBoxX.Size = new System.Drawing.Size(166, 21);
            this.Port_textBoxX.TabIndex = 7;
            this.superValidator1.SetValidator1(this.Port_textBoxX, this.requiredFieldValidator2);
            // 
            // IPAdress_textBoxX
            // 
            this.IPAdress_textBoxX.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.IPAdress_textBoxX.Border.Class = "TextBoxBorder";
            this.IPAdress_textBoxX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.IPAdress_textBoxX.DisabledBackColor = System.Drawing.Color.White;
            this.IPAdress_textBoxX.ForeColor = System.Drawing.Color.Black;
            this.IPAdress_textBoxX.Location = new System.Drawing.Point(105, 28);
            this.IPAdress_textBoxX.Name = "IPAdress_textBoxX";
            this.IPAdress_textBoxX.Size = new System.Drawing.Size(166, 21);
            this.IPAdress_textBoxX.TabIndex = 5;
            this.superValidator1.SetValidator1(this.IPAdress_textBoxX, this.requiredFieldValidator1);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(37, 52);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(62, 21);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "端口号:";
            this.labelX2.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(37, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(62, 21);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "IP地址:";
            this.labelX1.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // RedBubble_button
            // 
            this.RedBubble_button.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.RedBubble_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RedBubble_button.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.RedBubble_button.Location = new System.Drawing.Point(537, 35);
            this.RedBubble_button.Name = "RedBubble_button";
            this.RedBubble_button.Shape = new DevComponents.DotNetBar.EllipticalShapeDescriptor();
            this.RedBubble_button.Size = new System.Drawing.Size(75, 71);
            this.RedBubble_button.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.RedBubble_button.Symbol = "";
            this.RedBubble_button.SymbolColor = System.Drawing.Color.Gray;
            this.RedBubble_button.SymbolSize = 40F;
            this.RedBubble_button.TabIndex = 8;
            this.RedBubble_button.TextColor = System.Drawing.Color.Black;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // superValidator1
            // 
            this.superValidator1.ErrorProvider = this.errorProvider1;
            this.superValidator1.Highlighter = this.highlighter1;
            this.superValidator1.ValidationType = DevComponents.DotNetBar.Validator.eValidationType.ValidatingEventPerControl;
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.ErrorMessage = "端口号不能为空.";
            this.requiredFieldValidator2.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.ErrorMessage = "IP地址不能为空.";
            this.requiredFieldValidator1.HighlightColor = DevComponents.DotNetBar.Validator.eHighlightColor.Red;
            // 
            // ConnectToDevice_buttonX
            // 
            this.ConnectToDevice_buttonX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ConnectToDevice_buttonX.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ConnectToDevice_buttonX.Image = global::SmartHome_App.Properties.Resources.Actions_network_disconnect_icon;
            this.ConnectToDevice_buttonX.Location = new System.Drawing.Point(458, 25);
            this.ConnectToDevice_buttonX.Name = "ConnectToDevice_buttonX";
            this.ConnectToDevice_buttonX.Size = new System.Drawing.Size(164, 62);
            this.ConnectToDevice_buttonX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ConnectToDevice_buttonX.TabIndex = 9;
            this.ConnectToDevice_buttonX.Text = "未连接到设备";
            this.ConnectToDevice_buttonX.Click += new System.EventHandler(this.ConnectToDevice_buttonX_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel1.Controls.Add(this.labelX1);
            this.splitContainer1.Panel1.Controls.Add(this.ConnectToDevice_buttonX);
            this.splitContainer1.Panel1.Controls.Add(this.labelX2);
            this.splitContainer1.Panel1.Controls.Add(this.IPAdress_textBoxX);
            this.splitContainer1.Panel1.Controls.Add(this.Port_textBoxX);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.labelX9);
            this.splitContainer1.Panel2.Controls.Add(this.Interval_NumericUpDown);
            this.splitContainer1.Panel2.Controls.Add(this.Interval_trackBar);
            this.splitContainer1.Panel2.Controls.Add(this.HumidityValue_labelX);
            this.splitContainer1.Panel2.Controls.Add(this.labelX4);
            this.splitContainer1.Panel2.Controls.Add(this.GasValue_labelX);
            this.splitContainer1.Panel2.Controls.Add(this.labelX6);
            this.splitContainer1.Panel2.Controls.Add(this.PersonValue_labelX);
            this.splitContainer1.Panel2.Controls.Add(this.TemperatureValue_labelX);
            this.splitContainer1.Panel2.Controls.Add(this.StartDetect_buttonX);
            this.splitContainer1.Panel2.Controls.Add(this.Gass_labelX);
            this.splitContainer1.Panel2.Controls.Add(this.Person_labelX);
            this.splitContainer1.Panel2.Controls.Add(this.Humidity_labelX);
            this.splitContainer1.Panel2.Controls.Add(this.Temperature_labelX);
            this.splitContainer1.Panel2.Controls.Add(this.RedBubble_button);
            this.splitContainer1.Panel2.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.splitContainer1.Size = new System.Drawing.Size(691, 422);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 10;
            // 
            // labelX9
            // 
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX9.Location = new System.Drawing.Point(39, 263);
            this.labelX9.Name = "labelX9";
            this.labelX9.Size = new System.Drawing.Size(96, 21);
            this.labelX9.TabIndex = 23;
            this.labelX9.Text = "采集间隔:";
            this.labelX9.TextAlignment = System.Drawing.StringAlignment.Far;
            this.labelX9.Visible = false;
            // 
            // Interval_NumericUpDown
            // 
            this.Interval_NumericUpDown.Font = new System.Drawing.Font("SimSun", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Interval_NumericUpDown.Increment = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.Interval_NumericUpDown.Location = new System.Drawing.Point(367, 260);
            this.Interval_NumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.Interval_NumericUpDown.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Interval_NumericUpDown.Name = "Interval_NumericUpDown";
            this.Interval_NumericUpDown.Size = new System.Drawing.Size(74, 29);
            this.Interval_NumericUpDown.TabIndex = 21;
            this.Interval_NumericUpDown.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Interval_NumericUpDown.Visible = false;
            this.Interval_NumericUpDown.ValueChanged += new System.EventHandler(this.Interval_NumericUpDown_ValueChanged);
            // 
            // Interval_trackBar
            // 
            this.Interval_trackBar.BackColor = System.Drawing.SystemColors.Window;
            this.Interval_trackBar.Location = new System.Drawing.Point(146, 253);
            this.Interval_trackBar.Maximum = 5000;
            this.Interval_trackBar.Minimum = 1000;
            this.Interval_trackBar.Name = "Interval_trackBar";
            this.Interval_trackBar.Size = new System.Drawing.Size(206, 45);
            this.Interval_trackBar.TabIndex = 22;
            this.Interval_trackBar.TickFrequency = 200;
            this.Interval_trackBar.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.Interval_trackBar.Value = 1000;
            this.Interval_trackBar.Visible = false;
            this.Interval_trackBar.ValueChanged += new System.EventHandler(this.Interval_trackBar_ValueChanged);
            // 
            // HumidityValue_labelX
            // 
            // 
            // 
            // 
            this.HumidityValue_labelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.HumidityValue_labelX.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HumidityValue_labelX.ForeColor = System.Drawing.Color.Red;
            this.HumidityValue_labelX.Location = new System.Drawing.Point(398, 31);
            this.HumidityValue_labelX.Name = "HumidityValue_labelX";
            this.HumidityValue_labelX.Size = new System.Drawing.Size(43, 39);
            this.HumidityValue_labelX.TabIndex = 20;
            this.HumidityValue_labelX.Text = "20";
            // 
            // labelX4
            // 
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX4.ForeColor = System.Drawing.Color.Red;
            this.labelX4.Location = new System.Drawing.Point(447, 31);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(32, 39);
            this.labelX4.TabIndex = 19;
            this.labelX4.Text = "%";
            // 
            // GasValue_labelX
            // 
            // 
            // 
            // 
            this.GasValue_labelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GasValue_labelX.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GasValue_labelX.ForeColor = System.Drawing.Color.Red;
            this.GasValue_labelX.Location = new System.Drawing.Point(270, 159);
            this.GasValue_labelX.Name = "GasValue_labelX";
            this.GasValue_labelX.Size = new System.Drawing.Size(139, 50);
            this.GasValue_labelX.TabIndex = 18;
            this.GasValue_labelX.Text = "气体泄漏";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelX6.ForeColor = System.Drawing.Color.Red;
            this.labelX6.Location = new System.Drawing.Point(196, 35);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(37, 37);
            this.labelX6.TabIndex = 17;
            this.labelX6.Text = "℃";
            // 
            // PersonValue_labelX
            // 
            // 
            // 
            // 
            this.PersonValue_labelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PersonValue_labelX.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.PersonValue_labelX.ForeColor = System.Drawing.Color.Red;
            this.PersonValue_labelX.Location = new System.Drawing.Point(280, 105);
            this.PersonValue_labelX.Name = "PersonValue_labelX";
            this.PersonValue_labelX.Size = new System.Drawing.Size(78, 43);
            this.PersonValue_labelX.TabIndex = 16;
            this.PersonValue_labelX.Text = "无人";
            // 
            // TemperatureValue_labelX
            // 
            // 
            // 
            // 
            this.TemperatureValue_labelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TemperatureValue_labelX.Font = new System.Drawing.Font("SimSun", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TemperatureValue_labelX.ForeColor = System.Drawing.Color.Red;
            this.TemperatureValue_labelX.Location = new System.Drawing.Point(146, 39);
            this.TemperatureValue_labelX.Name = "TemperatureValue_labelX";
            this.TemperatureValue_labelX.Size = new System.Drawing.Size(54, 23);
            this.TemperatureValue_labelX.TabIndex = 14;
            this.TemperatureValue_labelX.Text = "24";
            // 
            // StartDetect_buttonX
            // 
            this.StartDetect_buttonX.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.StartDetect_buttonX.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.StartDetect_buttonX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartDetect_buttonX.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
            this.StartDetect_buttonX.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.StartDetect_buttonX.Location = new System.Drawing.Point(493, 249);
            this.StartDetect_buttonX.Name = "StartDetect_buttonX";
            this.StartDetect_buttonX.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.StartDetect_buttonX.Size = new System.Drawing.Size(186, 57);
            this.StartDetect_buttonX.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.StartDetect_buttonX.Symbol = "";
            this.StartDetect_buttonX.SymbolColor = System.Drawing.Color.White;
            this.StartDetect_buttonX.SymbolSize = 40F;
            this.StartDetect_buttonX.TabIndex = 13;
            this.StartDetect_buttonX.Text = "开始采集";
            this.StartDetect_buttonX.TextColor = System.Drawing.Color.White;
            this.StartDetect_buttonX.Click += new System.EventHandler(this.StartDetect_buttonX_Click);
            // 
            // Gass_labelX
            // 
            this.Gass_labelX.BackColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // 
            // 
            this.Gass_labelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Gass_labelX.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Gass_labelX.ForeColor = System.Drawing.Color.White;
            this.Gass_labelX.Location = new System.Drawing.Point(137, 169);
            this.Gass_labelX.Name = "Gass_labelX";
            this.Gass_labelX.Size = new System.Drawing.Size(108, 27);
            this.Gass_labelX.TabIndex = 12;
            this.Gass_labelX.Text = "气体检测:";
            this.Gass_labelX.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // Person_labelX
            // 
            this.Person_labelX.BackColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // 
            // 
            this.Person_labelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Person_labelX.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Person_labelX.ForeColor = System.Drawing.Color.White;
            this.Person_labelX.Location = new System.Drawing.Point(137, 112);
            this.Person_labelX.Name = "Person_labelX";
            this.Person_labelX.Size = new System.Drawing.Size(108, 27);
            this.Person_labelX.TabIndex = 11;
            this.Person_labelX.Text = "人员检测:";
            this.Person_labelX.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // Humidity_labelX
            // 
            this.Humidity_labelX.BackColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // 
            // 
            this.Humidity_labelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Humidity_labelX.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Humidity_labelX.ForeColor = System.Drawing.Color.White;
            this.Humidity_labelX.Location = new System.Drawing.Point(267, 37);
            this.Humidity_labelX.Name = "Humidity_labelX";
            this.Humidity_labelX.Size = new System.Drawing.Size(108, 26);
            this.Humidity_labelX.TabIndex = 10;
            this.Humidity_labelX.Text = "当前湿度:";
            this.Humidity_labelX.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // Temperature_labelX
            // 
            this.Temperature_labelX.BackColor = System.Drawing.SystemColors.MenuHighlight;
            // 
            // 
            // 
            this.Temperature_labelX.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Temperature_labelX.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Temperature_labelX.ForeColor = System.Drawing.Color.White;
            this.Temperature_labelX.Location = new System.Drawing.Point(18, 35);
            this.Temperature_labelX.Name = "Temperature_labelX";
            this.Temperature_labelX.Size = new System.Drawing.Size(108, 31);
            this.Temperature_labelX.TabIndex = 9;
            this.Temperature_labelX.Text = "当前温度:";
            this.Temperature_labelX.TextAlignment = System.Drawing.StringAlignment.Far;
            // 
            // Receive_backgroundWorker
            // 
            this.Receive_backgroundWorker.WorkerSupportsCancellation = true;
            this.Receive_backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Receive_backgroundWorker_DoWork);
            this.Receive_backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.Receive_backgroundWorker_RunWorkerCompleted);
            // 
            // MonitoringForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 422);
            this.Controls.Add(this.splitContainer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MonitoringForm";
            this.Text = "传感器监测";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Interval_NumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Interval_trackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX Port_textBoxX;
        private DevComponents.DotNetBar.Controls.TextBoxX IPAdress_textBoxX;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX RedBubble_button;
        private DevComponents.DotNetBar.Validator.SuperValidator superValidator1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator1;
        private DevComponents.DotNetBar.Validator.Highlighter highlighter1;
        private DevComponents.DotNetBar.Validator.RequiredFieldValidator requiredFieldValidator2;
        private DevComponents.DotNetBar.ButtonX ConnectToDevice_buttonX;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevComponents.DotNetBar.ButtonX StartDetect_buttonX;
        private DevComponents.DotNetBar.LabelX Gass_labelX;
        private DevComponents.DotNetBar.LabelX Person_labelX;
        private DevComponents.DotNetBar.LabelX Humidity_labelX;
        private DevComponents.DotNetBar.LabelX Temperature_labelX;
        private System.Windows.Forms.NumericUpDown Interval_NumericUpDown;
        private System.Windows.Forms.TrackBar Interval_trackBar;
        private DevComponents.DotNetBar.LabelX HumidityValue_labelX;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX GasValue_labelX;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX PersonValue_labelX;
        private DevComponents.DotNetBar.LabelX TemperatureValue_labelX;
        private DevComponents.DotNetBar.LabelX labelX9;
        private System.ComponentModel.BackgroundWorker Receive_backgroundWorker;
    }
}