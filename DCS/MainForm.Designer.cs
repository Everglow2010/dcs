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
            this.timeRefreshLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.ammoLeftTextBox = new System.Windows.Forms.TextBox();
            this.ammoLeftLabel = new System.Windows.Forms.Label();
            this.parameterConfigLabel = new System.Windows.Forms.Label();
            this.laserControlLabel = new System.Windows.Forms.Label();
            this.servoControlLabel = new System.Windows.Forms.Label();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.dataSendTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.ammoLeftTextBoxBlinkTimer = new System.Windows.Forms.Timer(this.components);
            this.batterryQueryTimer = new System.Windows.Forms.Timer(this.components);
            this.timeRefreshTimer = new System.Windows.Forms.Timer(this.components);
            this.logoButtonPictureBox = new System.Windows.Forms.PictureBox();
            this.laserControlPictureBox = new System.Windows.Forms.PictureBox();
            this.servoControlPictureBox = new System.Windows.Forms.PictureBox();
            this.safeStatePitureBox = new System.Windows.Forms.PictureBox();
            this.ammoLoadPictureBox = new System.Windows.Forms.PictureBox();
            this.cameraViewImageBox = new Emgu.CV.UI.ImageBox();
            this.aimingReticlePictureBox = new System.Windows.Forms.PictureBox();
            this.logoPictureBox = new System.Windows.Forms.PictureBox();
            this.dialPlatePictureBox = new System.Windows.Forms.PictureBox();
            this.distaneLabel = new System.Windows.Forms.Label();
            this.distanceValueLabel = new System.Windows.Forms.Label();
            this.pitchLabel = new System.Windows.Forms.Label();
            this.pitchValueLabel = new System.Windows.Forms.Label();
            this.herizonLabel = new System.Windows.Forms.Label();
            this.herizonValueLabel = new System.Windows.Forms.Label();
            this.timeSwitchPanel = new DCS.TimeSwitchPanel();
            this.laserControlOnOffSwitchPanel = new DCS.OnOffSwitchPanel();
            this.topBar.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoButtonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserControlPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servoControlPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewImageBox)).BeginInit();
            this.cameraViewImageBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aimingReticlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialPlatePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.topBar.Controls.Add(this.timeRefreshLabel);
            this.topBar.Controls.Add(this.label8);
            this.topBar.Controls.Add(this.logoButtonPictureBox);
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
            this.topBar.Controls.Add(this.ammoLeftTextBox);
            this.topBar.Controls.Add(this.ammoLeftLabel);
            this.topBar.Controls.Add(this.parameterConfigLabel);
            this.topBar.Controls.Add(this.laserControlLabel);
            this.topBar.Controls.Add(this.servoControlLabel);
            resources.ApplyResources(this.topBar, "topBar");
            this.topBar.Name = "topBar";
            // 
            // timeRefreshLabel
            // 
            resources.ApplyResources(this.timeRefreshLabel, "timeRefreshLabel");
            this.timeRefreshLabel.ForeColor = System.Drawing.Color.White;
            this.timeRefreshLabel.Name = "timeRefreshLabel";
            this.timeRefreshLabel.Click += new System.EventHandler(this.TimeRefreshLabel_Click);
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // safeStatusLabel
            // 
            resources.ApplyResources(this.safeStatusLabel, "safeStatusLabel");
            this.safeStatusLabel.ForeColor = System.Drawing.Color.White;
            this.safeStatusLabel.Name = "safeStatusLabel";
            // 
            // ammoLoadLabel
            // 
            resources.ApplyResources(this.ammoLoadLabel, "ammoLoadLabel");
            this.ammoLoadLabel.ForeColor = System.Drawing.Color.White;
            this.ammoLoadLabel.Name = "ammoLoadLabel";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // batteryLabel
            // 
            resources.ApplyResources(this.batteryLabel, "batteryLabel");
            this.batteryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.batteryLabel.Name = "batteryLabel";
            // 
            // batteryBar
            // 
            this.batteryBar.ForeColor = System.Drawing.Color.Chartreuse;
            resources.ApplyResources(this.batteryBar, "batteryBar");
            this.batteryBar.Name = "batteryBar";
            this.batteryBar.Value = 50;
            // 
            // ammoLeftTextBox
            // 
            this.ammoLeftTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ammoLeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ammoLeftTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ammoLeftTextBox, "ammoLeftTextBox");
            this.ammoLeftTextBox.ForeColor = System.Drawing.Color.Lime;
            this.ammoLeftTextBox.Name = "ammoLeftTextBox";
            this.ammoLeftTextBox.ReadOnly = true;
            this.ammoLeftTextBox.TabStop = false;
            this.ammoLeftTextBox.Click += new System.EventHandler(this.AmmoLeftTextBox_Click);
            // 
            // ammoLeftLabel
            // 
            resources.ApplyResources(this.ammoLeftLabel, "ammoLeftLabel");
            this.ammoLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ammoLeftLabel.Name = "ammoLeftLabel";
            // 
            // parameterConfigLabel
            // 
            resources.ApplyResources(this.parameterConfigLabel, "parameterConfigLabel");
            this.parameterConfigLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.parameterConfigLabel.Name = "parameterConfigLabel";
            this.parameterConfigLabel.Click += new System.EventHandler(this.ParameterConfigLabel_Click);
            // 
            // laserControlLabel
            // 
            resources.ApplyResources(this.laserControlLabel, "laserControlLabel");
            this.laserControlLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.laserControlLabel.Name = "laserControlLabel";
            // 
            // servoControlLabel
            // 
            resources.ApplyResources(this.servoControlLabel, "servoControlLabel");
            this.servoControlLabel.ForeColor = System.Drawing.Color.White;
            this.servoControlLabel.Name = "servoControlLabel";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.Parity = System.IO.Ports.Parity.Even;
            this.serialPort.PortName = "COM5";
            this.serialPort.ReceivedBytesThreshold = 12;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // dataSendTimer
            // 
            this.dataSendTimer.Interval = 10;
            this.dataSendTimer.Tick += new System.EventHandler(this.DataSendTimer_Tick);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.timeSwitchPanel);
            this.bottomPanel.Controls.Add(this.laserControlOnOffSwitchPanel);
            resources.ApplyResources(this.bottomPanel, "bottomPanel");
            this.bottomPanel.Name = "bottomPanel";
            // 
            // ammoLeftTextBoxBlinkTimer
            // 
            this.ammoLeftTextBoxBlinkTimer.Interval = 1000;
            this.ammoLeftTextBoxBlinkTimer.Tick += new System.EventHandler(this.AmmoLeftTextBoxBlinkTimer_Tick);
            // 
            // batterryQueryTimer
            // 
            this.batterryQueryTimer.Interval = 60000;
            this.batterryQueryTimer.Tick += new System.EventHandler(this.BatterryQueryTimer_Tick);
            // 
            // timeRefreshTimer
            // 
            this.timeRefreshTimer.Interval = 30000;
            this.timeRefreshTimer.Tick += new System.EventHandler(this.TimeRefreshTimer_Tick);
            // 
            // logoButtonPictureBox
            // 
            this.logoButtonPictureBox.Image = global::DCS.Properties.Resources.LOGOroundsquare;
            resources.ApplyResources(this.logoButtonPictureBox, "logoButtonPictureBox");
            this.logoButtonPictureBox.Name = "logoButtonPictureBox";
            this.logoButtonPictureBox.TabStop = false;
            this.logoButtonPictureBox.Click += new System.EventHandler(this.LogoButtonPictureBox_Click);
            // 
            // laserControlPictureBox
            // 
            this.laserControlPictureBox.Image = global::DCS.Properties.Resources.LaserOff;
            resources.ApplyResources(this.laserControlPictureBox, "laserControlPictureBox");
            this.laserControlPictureBox.Name = "laserControlPictureBox";
            this.laserControlPictureBox.TabStop = false;
            this.laserControlPictureBox.Click += new System.EventHandler(this.LaserControlPictureBox_Click);
            // 
            // servoControlPictureBox
            // 
            this.servoControlPictureBox.Image = global::DCS.Properties.Resources.SafetyOn;
            resources.ApplyResources(this.servoControlPictureBox, "servoControlPictureBox");
            this.servoControlPictureBox.Name = "servoControlPictureBox";
            this.servoControlPictureBox.TabStop = false;
            // 
            // safeStatePitureBox
            // 
            this.safeStatePitureBox.Image = global::DCS.Properties.Resources.SafetyOff;
            resources.ApplyResources(this.safeStatePitureBox, "safeStatePitureBox");
            this.safeStatePitureBox.Name = "safeStatePitureBox";
            this.safeStatePitureBox.TabStop = false;
            // 
            // ammoLoadPictureBox
            // 
            this.ammoLoadPictureBox.Image = global::DCS.Properties.Resources.AmmoLoadedNotLoaded;
            resources.ApplyResources(this.ammoLoadPictureBox, "ammoLoadPictureBox");
            this.ammoLoadPictureBox.Name = "ammoLoadPictureBox";
            this.ammoLoadPictureBox.TabStop = false;
            // 
            // cameraViewImageBox
            // 
            this.cameraViewImageBox.Controls.Add(this.aimingReticlePictureBox);
            this.cameraViewImageBox.Controls.Add(this.logoPictureBox);
            this.cameraViewImageBox.Controls.Add(this.dialPlatePictureBox);
            this.cameraViewImageBox.Controls.Add(this.distaneLabel);
            this.cameraViewImageBox.Controls.Add(this.distanceValueLabel);
            this.cameraViewImageBox.Controls.Add(this.pitchLabel);
            this.cameraViewImageBox.Controls.Add(this.pitchValueLabel);
            this.cameraViewImageBox.Controls.Add(this.herizonLabel);
            this.cameraViewImageBox.Controls.Add(this.herizonValueLabel);
            this.cameraViewImageBox.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
            resources.ApplyResources(this.cameraViewImageBox, "cameraViewImageBox");
            this.cameraViewImageBox.Name = "cameraViewImageBox";
            this.cameraViewImageBox.TabStop = false;
            // 
            // aimingReticlePictureBox
            // 
            this.aimingReticlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.aimingReticlePictureBox.Image = global::DCS.Properties.Resources.AimingReticle;
            resources.ApplyResources(this.aimingReticlePictureBox, "aimingReticlePictureBox");
            this.aimingReticlePictureBox.Name = "aimingReticlePictureBox";
            this.aimingReticlePictureBox.TabStop = false;
            // 
            // logoPictureBox
            // 
            this.logoPictureBox.Image = global::DCS.Properties.Resources.LOGOroundsquare;
            resources.ApplyResources(this.logoPictureBox, "logoPictureBox");
            this.logoPictureBox.Name = "logoPictureBox";
            this.logoPictureBox.TabStop = false;
            // 
            // dialPlatePictureBox
            // 
            this.dialPlatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.dialPlatePictureBox.BackgroundImage = global::DCS.Properties.Resources.DialPlate2;
            resources.ApplyResources(this.dialPlatePictureBox, "dialPlatePictureBox");
            this.dialPlatePictureBox.Name = "dialPlatePictureBox";
            this.dialPlatePictureBox.TabStop = false;
            this.dialPlatePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DialPlatePictureBox_Paint);
            // 
            // distaneLabel
            // 
            resources.ApplyResources(this.distaneLabel, "distaneLabel");
            this.distaneLabel.ForeColor = System.Drawing.Color.Red;
            this.distaneLabel.Name = "distaneLabel";
            // 
            // distanceValueLabel
            // 
            resources.ApplyResources(this.distanceValueLabel, "distanceValueLabel");
            this.distanceValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.distanceValueLabel.ForeColor = System.Drawing.Color.Red;
            this.distanceValueLabel.Name = "distanceValueLabel";
            // 
            // pitchLabel
            // 
            resources.ApplyResources(this.pitchLabel, "pitchLabel");
            this.pitchLabel.ForeColor = System.Drawing.Color.Red;
            this.pitchLabel.Name = "pitchLabel";
            // 
            // pitchValueLabel
            // 
            resources.ApplyResources(this.pitchValueLabel, "pitchValueLabel");
            this.pitchValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.pitchValueLabel.ForeColor = System.Drawing.Color.Red;
            this.pitchValueLabel.Name = "pitchValueLabel";
            // 
            // herizonLabel
            // 
            resources.ApplyResources(this.herizonLabel, "herizonLabel");
            this.herizonLabel.ForeColor = System.Drawing.Color.Red;
            this.herizonLabel.Name = "herizonLabel";
            // 
            // herizonValueLabel
            // 
            resources.ApplyResources(this.herizonValueLabel, "herizonValueLabel");
            this.herizonValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.herizonValueLabel.ForeColor = System.Drawing.Color.Red;
            this.herizonValueLabel.Name = "herizonValueLabel";
            // 
            // timeSwitchPanel
            // 
            this.timeSwitchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.timeSwitchPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.timeSwitchPanel, "timeSwitchPanel");
            this.timeSwitchPanel.Name = "timeSwitchPanel";
            // 
            // laserControlOnOffSwitchPanel
            // 
            this.laserControlOnOffSwitchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.laserControlOnOffSwitchPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.laserControlOnOffSwitchPanel, "laserControlOnOffSwitchPanel");
            this.laserControlOnOffSwitchPanel.Name = "laserControlOnOffSwitchPanel";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.cameraViewImageBox);
            this.Controls.Add(this.bottomPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoButtonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.laserControlPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servoControlPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewImageBox)).EndInit();
            this.cameraViewImageBox.ResumeLayout(false);
            this.cameraViewImageBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aimingReticlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialPlatePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label servoControlLabel;
        private System.Windows.Forms.Label laserControlLabel;
        private System.Windows.Forms.Label parameterConfigLabel;
        private System.Windows.Forms.Label ammoLeftLabel;
        private System.Windows.Forms.TextBox ammoLeftTextBox;
        private System.Windows.Forms.PictureBox ammoLoadPictureBox;
        private System.Windows.Forms.PictureBox safeStatePitureBox;
        private System.Windows.Forms.ProgressBar batteryBar;
        private System.Windows.Forms.Label batteryLabel;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.PictureBox dialPlatePictureBox;
        private System.Windows.Forms.PictureBox aimingReticlePictureBox;
        private Emgu.CV.UI.ImageBox cameraViewImageBox;
        private System.Windows.Forms.Timer dataSendTimer;
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
        private System.Windows.Forms.Timer ammoLeftTextBoxBlinkTimer;
        private OnOffSwitchPanel laserControlOnOffSwitchPanel;
        private System.Windows.Forms.Label distaneLabel;
        private System.Windows.Forms.Label pitchLabel;
        private System.Windows.Forms.Label herizonLabel;
        private System.Windows.Forms.Label distanceValueLabel;
        private System.Windows.Forms.Label pitchValueLabel;
        private System.Windows.Forms.Label herizonValueLabel;
        private System.Windows.Forms.PictureBox logoButtonPictureBox;
        private System.Windows.Forms.PictureBox logoPictureBox;
        private System.Windows.Forms.Timer batterryQueryTimer;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label timeRefreshLabel;
        private System.Windows.Forms.Timer timeRefreshTimer;
        private TimeSwitchPanel timeSwitchPanel;
    }
}

