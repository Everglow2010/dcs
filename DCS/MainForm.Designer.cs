namespace DCS
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.topBar = new System.Windows.Forms.Panel();
            this.laserControlPictureBox = new System.Windows.Forms.PictureBox();
            this.servoControlPictureBox = new System.Windows.Forms.PictureBox();
            this.safeStatusLabel = new System.Windows.Forms.Label();
            this.ammoLoadLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.batteryLabel = new System.Windows.Forms.Label();
            this.batteryBar = new System.Windows.Forms.ProgressBar();
            this.safeStatePitureBox = new System.Windows.Forms.PictureBox();
            this.ammoLoadPictureBox = new System.Windows.Forms.PictureBox();
            this.ammoLeftSetButton = new System.Windows.Forms.Button();
            this.ammoLeftTextBox = new System.Windows.Forms.TextBox();
            this.ammoLeftLabel = new System.Windows.Forms.Label();
            this.parameterConfigButton = new System.Windows.Forms.Button();
            this.parameterConfigLabel = new System.Windows.Forms.Label();
            this.laserControlLabel = new System.Windows.Forms.Label();
            this.servoControlLabel = new System.Windows.Forms.Label();
            this.dialPlateValueLabel = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.pitchAngleValueLabel = new System.Windows.Forms.Label();
            this.dataSendTimer = new System.Windows.Forms.Timer(this.components);
            this.cameraViewImageBox = new Emgu.CV.UI.ImageBox();
            this.aimingReticlePictureBox = new System.Windows.Forms.PictureBox();
            this.dialPlatePictureBox = new System.Windows.Forms.PictureBox();
            this.pitchAngleRulerPictureBox = new System.Windows.Forms.PictureBox();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laserControlPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servoControlPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewImageBox)).BeginInit();
            this.cameraViewImageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aimingReticlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialPlatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchAngleRulerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.topBar.Controls.Add(this.laserControlPictureBox);
            this.topBar.Controls.Add(this.servoControlPictureBox);
            this.topBar.Controls.Add(this.safeStatusLabel);
            this.topBar.Controls.Add(this.ammoLoadLabel);
            this.topBar.Controls.Add(this.label7);
            this.topBar.Controls.Add(this.label6);
            this.topBar.Controls.Add(this.label5);
            this.topBar.Controls.Add(this.label4);
            this.topBar.Controls.Add(this.label3);
            this.topBar.Controls.Add(this.label2);
            this.topBar.Controls.Add(this.label1);
            this.topBar.Controls.Add(this.batteryLabel);
            this.topBar.Controls.Add(this.batteryBar);
            this.topBar.Controls.Add(this.safeStatePitureBox);
            this.topBar.Controls.Add(this.ammoLoadPictureBox);
            this.topBar.Controls.Add(this.ammoLeftSetButton);
            this.topBar.Controls.Add(this.ammoLeftTextBox);
            this.topBar.Controls.Add(this.ammoLeftLabel);
            this.topBar.Controls.Add(this.parameterConfigButton);
            this.topBar.Controls.Add(this.parameterConfigLabel);
            this.topBar.Controls.Add(this.laserControlLabel);
            this.topBar.Controls.Add(this.servoControlLabel);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1280, 80);
            this.topBar.TabIndex = 0;
            // 
            // laserControlPictureBox
            // 
            this.laserControlPictureBox.Image = global::DCS.Properties.Resources.LaserOff;
            this.laserControlPictureBox.Location = new System.Drawing.Point(790, 36);
            this.laserControlPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.laserControlPictureBox.Name = "laserControlPictureBox";
            this.laserControlPictureBox.Size = new System.Drawing.Size(58, 16);
            this.laserControlPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.laserControlPictureBox.TabIndex = 25;
            this.laserControlPictureBox.TabStop = false;
            // 
            // servoControlPictureBox
            // 
            this.servoControlPictureBox.Image = global::DCS.Properties.Resources.SafetyOn;
            this.servoControlPictureBox.Location = new System.Drawing.Point(362, 36);
            this.servoControlPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.servoControlPictureBox.Name = "servoControlPictureBox";
            this.servoControlPictureBox.Size = new System.Drawing.Size(58, 16);
            this.servoControlPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.servoControlPictureBox.TabIndex = 24;
            this.servoControlPictureBox.TabStop = false;
            // 
            // safeStatusLabel
            // 
            this.safeStatusLabel.AutoSize = true;
            this.safeStatusLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.safeStatusLabel.ForeColor = System.Drawing.Color.White;
            this.safeStatusLabel.Location = new System.Drawing.Point(574, 33);
            this.safeStatusLabel.Margin = new System.Windows.Forms.Padding(0);
            this.safeStatusLabel.Name = "safeStatusLabel";
            this.safeStatusLabel.Size = new System.Drawing.Size(74, 22);
            this.safeStatusLabel.TabIndex = 23;
            this.safeStatusLabel.Text = "射击保险";
            // 
            // ammoLoadLabel
            // 
            this.ammoLoadLabel.AutoSize = true;
            this.ammoLoadLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ammoLoadLabel.ForeColor = System.Drawing.Color.White;
            this.ammoLoadLabel.Location = new System.Drawing.Point(435, 33);
            this.ammoLoadLabel.Name = "ammoLoadLabel";
            this.ammoLoadLabel.Size = new System.Drawing.Size(42, 22);
            this.ammoLoadLabel.TabIndex = 22;
            this.ammoLoadLabel.Text = "装填";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(994, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(3, 80);
            this.label7.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(852, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(3, 80);
            this.label6.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(710, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(3, 80);
            this.label5.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(568, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(3, 80);
            this.label4.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(426, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(3, 80);
            this.label3.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(3, 80);
            this.label2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(142, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(3, 80);
            this.label1.TabIndex = 13;
            // 
            // batteryLabel
            // 
            this.batteryLabel.AutoSize = true;
            this.batteryLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.batteryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.batteryLabel.Location = new System.Drawing.Point(1019, 35);
            this.batteryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.batteryLabel.Name = "batteryLabel";
            this.batteryLabel.Size = new System.Drawing.Size(74, 22);
            this.batteryLabel.TabIndex = 12;
            this.batteryLabel.Text = "电池电量";
            // 
            // batteryBar
            // 
            this.batteryBar.ForeColor = System.Drawing.Color.Chartreuse;
            this.batteryBar.Location = new System.Drawing.Point(1096, 35);
            this.batteryBar.Name = "batteryBar";
            this.batteryBar.Size = new System.Drawing.Size(91, 23);
            this.batteryBar.TabIndex = 11;
            this.batteryBar.Value = 50;
            // 
            // safeStatePitureBox
            // 
            this.safeStatePitureBox.Image = global::DCS.Properties.Resources.SafetyOff;
            this.safeStatePitureBox.Location = new System.Drawing.Point(651, 36);
            this.safeStatePitureBox.Margin = new System.Windows.Forms.Padding(0);
            this.safeStatePitureBox.Name = "safeStatePitureBox";
            this.safeStatePitureBox.Size = new System.Drawing.Size(58, 16);
            this.safeStatePitureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.safeStatePitureBox.TabIndex = 10;
            this.safeStatePitureBox.TabStop = false;
            // 
            // ammoLoadPictureBox
            // 
            this.ammoLoadPictureBox.Image = global::DCS.Properties.Resources.AmmoLoadedNotLoaded;
            this.ammoLoadPictureBox.Location = new System.Drawing.Point(480, 34);
            this.ammoLoadPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ammoLoadPictureBox.Name = "ammoLoadPictureBox";
            this.ammoLoadPictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.ammoLoadPictureBox.Size = new System.Drawing.Size(85, 21);
            this.ammoLoadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ammoLoadPictureBox.TabIndex = 9;
            this.ammoLoadPictureBox.TabStop = false;
            // 
            // ammoLeftSetButton
            // 
            this.ammoLeftSetButton.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ammoLeftSetButton.ForeColor = System.Drawing.Color.Red;
            this.ammoLeftSetButton.Location = new System.Drawing.Point(161, 7);
            this.ammoLeftSetButton.Name = "ammoLeftSetButton";
            this.ammoLeftSetButton.Size = new System.Drawing.Size(40, 18);
            this.ammoLeftSetButton.TabIndex = 8;
            this.ammoLeftSetButton.Text = "设置";
            this.ammoLeftSetButton.UseVisualStyleBackColor = true;
            this.ammoLeftSetButton.Click += new System.EventHandler(this.AmmoLeftSetButton_Click);
            // 
            // ammoLeftTextBox
            // 
            this.ammoLeftTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ammoLeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ammoLeftTextBox.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ammoLeftTextBox.ForeColor = System.Drawing.Color.Lime;
            this.ammoLeftTextBox.Location = new System.Drawing.Point(215, 22);
            this.ammoLeftTextBox.Name = "ammoLeftTextBox";
            this.ammoLeftTextBox.ReadOnly = true;
            this.ammoLeftTextBox.Size = new System.Drawing.Size(65, 43);
            this.ammoLeftTextBox.TabIndex = 7;
            this.ammoLeftTextBox.Text = "100";
            this.ammoLeftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ammoLeftTextBox.Click += new System.EventHandler(this.AmmoLeftTextBox_Click);
            // 
            // ammoLeftLabel
            // 
            this.ammoLeftLabel.AutoSize = true;
            this.ammoLeftLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ammoLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ammoLeftLabel.Location = new System.Drawing.Point(143, 33);
            this.ammoLeftLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ammoLeftLabel.Name = "ammoLeftLabel";
            this.ammoLeftLabel.Size = new System.Drawing.Size(74, 22);
            this.ammoLeftLabel.TabIndex = 6;
            this.ammoLeftLabel.Text = "剩余弹量";
            // 
            // parameterConfigButton
            // 
            this.parameterConfigButton.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parameterConfigButton.ForeColor = System.Drawing.Color.Red;
            this.parameterConfigButton.Location = new System.Drawing.Point(908, 7);
            this.parameterConfigButton.Name = "parameterConfigButton";
            this.parameterConfigButton.Size = new System.Drawing.Size(40, 18);
            this.parameterConfigButton.TabIndex = 5;
            this.parameterConfigButton.Text = "设置";
            this.parameterConfigButton.UseVisualStyleBackColor = true;
            this.parameterConfigButton.Click += new System.EventHandler(this.ParameterConfigButton_Click);
            // 
            // parameterConfigLabel
            // 
            this.parameterConfigLabel.AutoSize = true;
            this.parameterConfigLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parameterConfigLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.parameterConfigLabel.Location = new System.Drawing.Point(891, 33);
            this.parameterConfigLabel.Margin = new System.Windows.Forms.Padding(0);
            this.parameterConfigLabel.Name = "parameterConfigLabel";
            this.parameterConfigLabel.Size = new System.Drawing.Size(74, 22);
            this.parameterConfigLabel.TabIndex = 4;
            this.parameterConfigLabel.Text = "系统设置";
            // 
            // laserControlLabel
            // 
            this.laserControlLabel.AutoSize = true;
            this.laserControlLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laserControlLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.laserControlLabel.Location = new System.Drawing.Point(716, 34);
            this.laserControlLabel.Margin = new System.Windows.Forms.Padding(0);
            this.laserControlLabel.Name = "laserControlLabel";
            this.laserControlLabel.Size = new System.Drawing.Size(74, 22);
            this.laserControlLabel.TabIndex = 2;
            this.laserControlLabel.Text = "辅助瞄准";
            // 
            // servoControlLabel
            // 
            this.servoControlLabel.AutoSize = true;
            this.servoControlLabel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.servoControlLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.servoControlLabel.Location = new System.Drawing.Point(290, 33);
            this.servoControlLabel.Margin = new System.Windows.Forms.Padding(0);
            this.servoControlLabel.Name = "servoControlLabel";
            this.servoControlLabel.Size = new System.Drawing.Size(74, 22);
            this.servoControlLabel.TabIndex = 1;
            this.servoControlLabel.Text = "伺服使能";
            // 
            // dialPlateValueLabel
            // 
            this.dialPlateValueLabel.AutoSize = true;
            this.dialPlateValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.dialPlateValueLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dialPlateValueLabel.ForeColor = System.Drawing.Color.Red;
            this.dialPlateValueLabel.Location = new System.Drawing.Point(158, 746);
            this.dialPlateValueLabel.Name = "dialPlateValueLabel";
            this.dialPlateValueLabel.Size = new System.Drawing.Size(15, 14);
            this.dialPlateValueLabel.TabIndex = 4;
            this.dialPlateValueLabel.Text = "0";
            this.dialPlateValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.Parity = System.IO.Ports.Parity.Even;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // pitchAngleValueLabel
            // 
            this.pitchAngleValueLabel.AutoSize = true;
            this.pitchAngleValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.pitchAngleValueLabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pitchAngleValueLabel.ForeColor = System.Drawing.Color.Red;
            this.pitchAngleValueLabel.Location = new System.Drawing.Point(48, 746);
            this.pitchAngleValueLabel.Name = "pitchAngleValueLabel";
            this.pitchAngleValueLabel.Size = new System.Drawing.Size(15, 14);
            this.pitchAngleValueLabel.TabIndex = 3;
            this.pitchAngleValueLabel.Text = "0";
            this.pitchAngleValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataSendTimer
            // 
            this.dataSendTimer.Interval = 1000;
            this.dataSendTimer.Tick += new System.EventHandler(this.DataSendTimer_Tick);
            // 
            // cameraViewImageBox
            // 
            this.cameraViewImageBox.Parent = this.bottomPanel;
            this.cameraViewImageBox.Controls.Add(this.aimingReticlePictureBox);
            this.cameraViewImageBox.Controls.Add(this.dialPlatePictureBox);
            this.cameraViewImageBox.Controls.Add(this.pitchAngleRulerPictureBox);
            this.cameraViewImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            this.cameraViewImageBox.Location = new System.Drawing.Point(0, 80);
            this.cameraViewImageBox.MaximumSize = new System.Drawing.Size(1280, 720);
            this.cameraViewImageBox.MinimumSize = new System.Drawing.Size(1280, 720);
            this.cameraViewImageBox.Name = "cameraViewImageBox";
            this.cameraViewImageBox.Size = new System.Drawing.Size(1280, 720);
            this.cameraViewImageBox.TabIndex = 2;
            this.cameraViewImageBox.TabStop = false;
            // 
            // aimingReticlePictureBox
            // 
            this.aimingReticlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.aimingReticlePictureBox.Image = global::DCS.Properties.Resources.AimingReticle;
            this.aimingReticlePictureBox.Location = new System.Drawing.Point(515, 235);
            this.aimingReticlePictureBox.Name = "aimingReticlePictureBox";
            this.aimingReticlePictureBox.Size = new System.Drawing.Size(280, 177);
            this.aimingReticlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aimingReticlePictureBox.TabIndex = 3;
            this.aimingReticlePictureBox.TabStop = false;
            // 
            // dialPlatePictureBox
            // 
            this.dialPlatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.dialPlatePictureBox.BackgroundImage = global::DCS.Properties.Resources.dialPlate;
            this.dialPlatePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dialPlatePictureBox.Location = new System.Drawing.Point(88, 503);
            this.dialPlatePictureBox.Name = "dialPlatePictureBox";
            this.dialPlatePictureBox.Size = new System.Drawing.Size(160, 160);
            this.dialPlatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dialPlatePictureBox.TabIndex = 0;
            this.dialPlatePictureBox.TabStop = false;
            this.dialPlatePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DialPlatePictureBox_Paint);
            // 
            // pitchAngleRulerPictureBox
            // 
            this.pitchAngleRulerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pitchAngleRulerPictureBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pitchAngleRulerPictureBox.BackgroundImage")));
            this.pitchAngleRulerPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pitchAngleRulerPictureBox.Location = new System.Drawing.Point(29, 503);
            this.pitchAngleRulerPictureBox.Name = "pitchAngleRulerPictureBox";
            this.pitchAngleRulerPictureBox.Size = new System.Drawing.Size(34, 160);
            this.pitchAngleRulerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pitchAngleRulerPictureBox.TabIndex = 2;
            this.pitchAngleRulerPictureBox.TabStop = false;
            this.pitchAngleRulerPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PitchAngleRulerPictureBox_Paint);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Controls.Add(this.cameraViewImageBox);
            this.bottomPanel.Location = new System.Drawing.Point(0, 80);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1280, 720);
            this.bottomPanel.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.pitchAngleValueLabel);
            this.Controls.Add(this.dialPlateValueLabel);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.cameraViewImageBox);
            this.Controls.Add(this.bottomPanel);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "DCS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laserControlPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servoControlPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewImageBox)).EndInit();
            this.cameraViewImageBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aimingReticlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialPlatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchAngleRulerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label servoControlLabel;
        private System.Windows.Forms.Label laserControlLabel;
        private System.Windows.Forms.Button parameterConfigButton;
        private System.Windows.Forms.Label parameterConfigLabel;
        private System.Windows.Forms.Label ammoLeftLabel;
        private System.Windows.Forms.Button ammoLeftSetButton;
        private System.Windows.Forms.TextBox ammoLeftTextBox;
        private System.Windows.Forms.PictureBox ammoLoadPictureBox;
        private System.Windows.Forms.PictureBox safeStatePitureBox;
        private System.Windows.Forms.ProgressBar batteryBar;
        private System.Windows.Forms.Label batteryLabel;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.PictureBox dialPlatePictureBox;
        private System.Windows.Forms.PictureBox aimingReticlePictureBox;
        private Emgu.CV.UI.ImageBox cameraViewImageBox;
        private System.Windows.Forms.Label pitchAngleValueLabel;
        private System.Windows.Forms.Label dialPlateValueLabel;
        private System.Windows.Forms.Timer dataSendTimer;
        private System.Windows.Forms.PictureBox pitchAngleRulerPictureBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label safeStatusLabel;
        private System.Windows.Forms.Label ammoLoadLabel;
        private System.Windows.Forms.PictureBox servoControlPictureBox;
        private System.Windows.Forms.PictureBox laserControlPictureBox;
        private System.Windows.Forms.Panel bottomPanel;
    }
}

