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
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.ammoLeftTextBoxBlinkTimer = new System.Windows.Forms.Timer(this.components);
            this.cameraViewImageBox = new Emgu.CV.UI.ImageBox();
            this.aimingReticlePictureBox = new System.Windows.Forms.PictureBox();
            this.dialPlatePictureBox = new System.Windows.Forms.PictureBox();
            this.pitchAngleRulerPictureBox = new System.Windows.Forms.PictureBox();
            this.servoControlOnOffSwitchPanel = new OnOffSwitchPanel(GlobalVars.SERVO_CONTROL);
            this.laserControlOnOffSwitchPanel = new OnOffSwitchPanel(GlobalVars.LASER_CONTROL);
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laserControlPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servoControlPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).BeginInit();
            this.bottomPanel.SuspendLayout();
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
            this.topBar.Controls.Add(this.ammoLeftTextBox);
            this.topBar.Controls.Add(this.ammoLeftLabel);
            this.topBar.Controls.Add(this.parameterConfigButton);
            this.topBar.Controls.Add(this.parameterConfigLabel);
            this.topBar.Controls.Add(this.laserControlLabel);
            this.topBar.Controls.Add(this.servoControlLabel);
            resources.ApplyResources(this.topBar, "topBar");
            this.topBar.Name = "topBar";
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
            this.servoControlPictureBox.Click += new System.EventHandler(this.ServoControlPictureBox_Click);
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
            // ammoLeftTextBox
            // 
            this.ammoLeftTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ammoLeftTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ammoLeftTextBox.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.ammoLeftTextBox, "ammoLeftTextBox");
            this.ammoLeftTextBox.ForeColor = System.Drawing.Color.Lime;
            this.ammoLeftTextBox.Name = "ammoLeftTextBox";
            this.ammoLeftTextBox.ReadOnly = true;
            this.ammoLeftTextBox.Click += new System.EventHandler(this.AmmoLeftTextBox_Click);
            // 
            // ammoLeftLabel
            // 
            resources.ApplyResources(this.ammoLeftLabel, "ammoLeftLabel");
            this.ammoLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ammoLeftLabel.Name = "ammoLeftLabel";
            // 
            // parameterConfigButton
            // 
            resources.ApplyResources(this.parameterConfigButton, "parameterConfigButton");
            this.parameterConfigButton.ForeColor = System.Drawing.Color.Red;
            this.parameterConfigButton.Name = "parameterConfigButton";
            this.parameterConfigButton.UseVisualStyleBackColor = true;
            this.parameterConfigButton.Click += new System.EventHandler(this.ParameterConfigButton_Click);
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
            this.servoControlLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.servoControlLabel.Name = "servoControlLabel";
            // 
            // dialPlateValueLabel
            // 
            resources.ApplyResources(this.dialPlateValueLabel, "dialPlateValueLabel");
            this.dialPlateValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.dialPlateValueLabel.ForeColor = System.Drawing.Color.Red;
            this.dialPlateValueLabel.Name = "dialPlateValueLabel";
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.Parity = System.IO.Ports.Parity.Even;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // pitchAngleValueLabel
            // 
            resources.ApplyResources(this.pitchAngleValueLabel, "pitchAngleValueLabel");
            this.pitchAngleValueLabel.BackColor = System.Drawing.Color.Transparent;
            this.pitchAngleValueLabel.ForeColor = System.Drawing.Color.Red;
            this.pitchAngleValueLabel.Name = "pitchAngleValueLabel";
            // 
            // dataSendTimer
            // 
            this.dataSendTimer.Interval = 1000;
            this.dataSendTimer.Tick += new System.EventHandler(this.DataSendTimer_Tick);
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.laserControlOnOffSwitchPanel);
            this.bottomPanel.Controls.Add(this.servoControlOnOffSwitchPanel);
            resources.ApplyResources(this.bottomPanel, "bottomPanel");
            this.bottomPanel.Name = "bottomPanel";
            // 
            // laserControlOnOffSwitchPanel
            // 
            this.laserControlOnOffSwitchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.laserControlOnOffSwitchPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.laserControlOnOffSwitchPanel, "laserControlOnOffSwitchPanel");
            this.laserControlOnOffSwitchPanel.Name = "laserControlOnOffSwitchPanel";
            // 
            // servoControlOnOffSwitchPanel
            // 
            this.servoControlOnOffSwitchPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.servoControlOnOffSwitchPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            resources.ApplyResources(this.servoControlOnOffSwitchPanel, "servoControlOnOffSwitchPanel");
            this.servoControlOnOffSwitchPanel.Name = "servoControlOnOffSwitchPanel";
            // 
            // ammoLeftTextBoxBlinkTimer
            // 
            this.ammoLeftTextBoxBlinkTimer.Interval = 1000;
            this.ammoLeftTextBoxBlinkTimer.Tick += new System.EventHandler(this.AmmoLeftTextBoxBlinkTimer_Tick);
            // 
            // cameraViewImageBox
            // 
            this.cameraViewImageBox.Controls.Add(this.aimingReticlePictureBox);
            this.cameraViewImageBox.Controls.Add(this.dialPlatePictureBox);
            this.cameraViewImageBox.Controls.Add(this.pitchAngleRulerPictureBox);
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
            // dialPlatePictureBox
            // 
            this.dialPlatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.dialPlatePictureBox.BackgroundImage = global::DCS.Properties.Resources.dialPlate;
            resources.ApplyResources(this.dialPlatePictureBox, "dialPlatePictureBox");
            this.dialPlatePictureBox.Name = "dialPlatePictureBox";
            this.dialPlatePictureBox.TabStop = false;
            this.dialPlatePictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.DialPlatePictureBox_Paint);
            // 
            // pitchAngleRulerPictureBox
            // 
            this.pitchAngleRulerPictureBox.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.pitchAngleRulerPictureBox, "pitchAngleRulerPictureBox");
            this.pitchAngleRulerPictureBox.Name = "pitchAngleRulerPictureBox";
            this.pitchAngleRulerPictureBox.TabStop = false;
            this.pitchAngleRulerPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PitchAngleRulerPictureBox_Paint);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pitchAngleValueLabel);
            this.Controls.Add(this.dialPlateValueLabel);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.cameraViewImageBox);
            this.Controls.Add(this.bottomPanel);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.laserControlPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servoControlPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).EndInit();
            this.bottomPanel.ResumeLayout(false);
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
        private System.Windows.Forms.Timer ammoLeftTextBoxBlinkTimer;
        private OnOffSwitchPanel servoControlOnOffSwitchPanel;
        private OnOffSwitchPanel laserControlOnOffSwitchPanel;
    }
}

