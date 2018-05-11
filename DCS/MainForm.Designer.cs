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
            this.topBar = new System.Windows.Forms.Panel();
            this.servoControlSwitchButton = new DCS.OnOffSwitchButton();
            this.batteryLabel = new System.Windows.Forms.Label();
            this.batteryBar = new System.Windows.Forms.ProgressBar();
            this.safeStatePitureBox = new System.Windows.Forms.PictureBox();
            this.ammoLoadPictureBox = new System.Windows.Forms.PictureBox();
            this.ammoLeftSetButton = new System.Windows.Forms.Button();
            this.ammoLeftTextBox = new System.Windows.Forms.TextBox();
            this.ammoLeftLabel = new System.Windows.Forms.Label();
            this.parameterConfigButton = new System.Windows.Forms.Button();
            this.parameterConfigLabel = new System.Windows.Forms.Label();
            this.laserControlSwitchButton = new DCS.OnOffSwitchButton();
            this.laserControlLabel = new System.Windows.Forms.Label();
            this.servoControlLabel = new System.Windows.Forms.Label();
            this.aimingReticlePictureBox = new System.Windows.Forms.PictureBox();
            this.dialPlatePictureBox = new System.Windows.Forms.PictureBox();
            this.pitchAngleRulerPictureBox = new System.Windows.Forms.PictureBox();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.cameraViewImageBox = new Emgu.CV.UI.ImageBox();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimingReticlePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialPlatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchAngleRulerPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewImageBox)).BeginInit();
            this.cameraViewImageBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Black;
            this.topBar.Controls.Add(this.servoControlSwitchButton);
            this.topBar.Controls.Add(this.batteryLabel);
            this.topBar.Controls.Add(this.batteryBar);
            this.topBar.Controls.Add(this.safeStatePitureBox);
            this.topBar.Controls.Add(this.ammoLoadPictureBox);
            this.topBar.Controls.Add(this.ammoLeftSetButton);
            this.topBar.Controls.Add(this.ammoLeftTextBox);
            this.topBar.Controls.Add(this.ammoLeftLabel);
            this.topBar.Controls.Add(this.parameterConfigButton);
            this.topBar.Controls.Add(this.parameterConfigLabel);
            this.topBar.Controls.Add(this.laserControlSwitchButton);
            this.topBar.Controls.Add(this.laserControlLabel);
            this.topBar.Controls.Add(this.servoControlLabel);
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1280, 80);
            this.topBar.TabIndex = 0;
            // 
            // servoControlSwitchButton
            // 
            this.servoControlSwitchButton.BackColor = System.Drawing.Color.Transparent;
            this.servoControlSwitchButton.Checked = false;
            this.servoControlSwitchButton.CheckStyleX = DCS.SwitchButtonStyle.style1;
            this.servoControlSwitchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.servoControlSwitchButton.Location = new System.Drawing.Point(88, 38);
            this.servoControlSwitchButton.Name = "servoControlSwitchButton";
            this.servoControlSwitchButton.Size = new System.Drawing.Size(51, 16);
            this.servoControlSwitchButton.TabIndex = 0;
            // 
            // batteryLabel
            // 
            this.batteryLabel.AutoSize = true;
            this.batteryLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.batteryLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.batteryLabel.Location = new System.Drawing.Point(947, 40);
            this.batteryLabel.Margin = new System.Windows.Forms.Padding(0);
            this.batteryLabel.Name = "batteryLabel";
            this.batteryLabel.Size = new System.Drawing.Size(76, 16);
            this.batteryLabel.TabIndex = 12;
            this.batteryLabel.Text = "电池电量";
            // 
            // batteryBar
            // 
            this.batteryBar.ForeColor = System.Drawing.Color.Chartreuse;
            this.batteryBar.Location = new System.Drawing.Point(1026, 38);
            this.batteryBar.Name = "batteryBar";
            this.batteryBar.Size = new System.Drawing.Size(91, 23);
            this.batteryBar.TabIndex = 11;
            this.batteryBar.Value = 50;
            // 
            // safeStatePitureBox
            // 
            this.safeStatePitureBox.Image = global::DCS.Properties.Resources.safetyOff;
            this.safeStatePitureBox.Location = new System.Drawing.Point(808, 38);
            this.safeStatePitureBox.Name = "safeStatePitureBox";
            this.safeStatePitureBox.Size = new System.Drawing.Size(119, 21);
            this.safeStatePitureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.safeStatePitureBox.TabIndex = 10;
            this.safeStatePitureBox.TabStop = false;
            // 
            // ammoLoadPictureBox
            // 
            this.ammoLoadPictureBox.Image = global::DCS.Properties.Resources.ammoNotLoaded;
            this.ammoLoadPictureBox.Location = new System.Drawing.Point(630, 38);
            this.ammoLoadPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.ammoLoadPictureBox.Name = "ammoLoadPictureBox";
            this.ammoLoadPictureBox.Size = new System.Drawing.Size(154, 21);
            this.ammoLoadPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ammoLoadPictureBox.TabIndex = 9;
            this.ammoLoadPictureBox.TabStop = false;
            // 
            // ammoLeftSetButton
            // 
            this.ammoLeftSetButton.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ammoLeftSetButton.ForeColor = System.Drawing.Color.Red;
            this.ammoLeftSetButton.Location = new System.Drawing.Point(563, 38);
            this.ammoLeftSetButton.Name = "ammoLeftSetButton";
            this.ammoLeftSetButton.Size = new System.Drawing.Size(40, 18);
            this.ammoLeftSetButton.TabIndex = 8;
            this.ammoLeftSetButton.Text = "设置";
            this.ammoLeftSetButton.UseVisualStyleBackColor = true;
            this.ammoLeftSetButton.Click += new System.EventHandler(this.AmmoLeftSetButton_Click);
            // 
            // ammoLeftTextBox
            // 
            this.ammoLeftTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.ammoLeftTextBox.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ammoLeftTextBox.Location = new System.Drawing.Point(525, 36);
            this.ammoLeftTextBox.Name = "ammoLeftTextBox";
            this.ammoLeftTextBox.ReadOnly = true;
            this.ammoLeftTextBox.Size = new System.Drawing.Size(32, 23);
            this.ammoLeftTextBox.TabIndex = 7;
            this.ammoLeftTextBox.Text = "60";
            this.ammoLeftTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ammoLeftLabel
            // 
            this.ammoLeftLabel.AutoSize = true;
            this.ammoLeftLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ammoLeftLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ammoLeftLabel.Location = new System.Drawing.Point(446, 38);
            this.ammoLeftLabel.Margin = new System.Windows.Forms.Padding(0);
            this.ammoLeftLabel.Name = "ammoLeftLabel";
            this.ammoLeftLabel.Size = new System.Drawing.Size(76, 16);
            this.ammoLeftLabel.TabIndex = 6;
            this.ammoLeftLabel.Text = "剩余弹量";
            // 
            // parameterConfigButton
            // 
            this.parameterConfigButton.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parameterConfigButton.ForeColor = System.Drawing.Color.Red;
            this.parameterConfigButton.Location = new System.Drawing.Point(386, 38);
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
            this.parameterConfigLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.parameterConfigLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.parameterConfigLabel.Location = new System.Drawing.Point(307, 38);
            this.parameterConfigLabel.Margin = new System.Windows.Forms.Padding(0);
            this.parameterConfigLabel.Name = "parameterConfigLabel";
            this.parameterConfigLabel.Size = new System.Drawing.Size(76, 16);
            this.parameterConfigLabel.TabIndex = 4;
            this.parameterConfigLabel.Text = "参数设置";
            // 
            // laserControlSwitchButton
            // 
            this.laserControlSwitchButton.BackColor = System.Drawing.Color.Transparent;
            this.laserControlSwitchButton.Checked = false;
            this.laserControlSwitchButton.CheckStyleX = DCS.SwitchButtonStyle.style1;
            this.laserControlSwitchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.laserControlSwitchButton.Location = new System.Drawing.Point(237, 38);
            this.laserControlSwitchButton.Name = "laserControlSwitchButton";
            this.laserControlSwitchButton.Size = new System.Drawing.Size(51, 16);
            this.laserControlSwitchButton.TabIndex = 3;
            // 
            // laserControlLabel
            // 
            this.laserControlLabel.AutoSize = true;
            this.laserControlLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.laserControlLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.laserControlLabel.Location = new System.Drawing.Point(158, 38);
            this.laserControlLabel.Margin = new System.Windows.Forms.Padding(0);
            this.laserControlLabel.Name = "laserControlLabel";
            this.laserControlLabel.Size = new System.Drawing.Size(76, 16);
            this.laserControlLabel.TabIndex = 2;
            this.laserControlLabel.Text = "激光控制";
            // 
            // servoControlLabel
            // 
            this.servoControlLabel.AutoSize = true;
            this.servoControlLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.servoControlLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.servoControlLabel.Location = new System.Drawing.Point(9, 38);
            this.servoControlLabel.Margin = new System.Windows.Forms.Padding(0);
            this.servoControlLabel.Name = "servoControlLabel";
            this.servoControlLabel.Size = new System.Drawing.Size(76, 16);
            this.servoControlLabel.TabIndex = 1;
            this.servoControlLabel.Text = "伺服控制";
            // 
            // aimingReticlePictureBox
            // 
            this.aimingReticlePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.aimingReticlePictureBox.Image = global::DCS.Properties.Resources.aimingDivision;
            this.aimingReticlePictureBox.Location = new System.Drawing.Point(515, 235);
            this.aimingReticlePictureBox.Name = "aimingReticlePictureBox";
            this.aimingReticlePictureBox.Size = new System.Drawing.Size(250, 250);
            this.aimingReticlePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.aimingReticlePictureBox.TabIndex = 3;
            this.aimingReticlePictureBox.TabStop = false;
            // 
            // dialPlatePictureBox
            // 
            this.dialPlatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.dialPlatePictureBox.Image = global::DCS.Properties.Resources.dialPlate;
            this.dialPlatePictureBox.Location = new System.Drawing.Point(88, 503);
            this.dialPlatePictureBox.Name = "dialPlatePictureBox";
            this.dialPlatePictureBox.Size = new System.Drawing.Size(160, 160);
            this.dialPlatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dialPlatePictureBox.TabIndex = 0;
            this.dialPlatePictureBox.TabStop = false;
            // 
            // pitchAngleRulerPictureBox
            // 
            this.pitchAngleRulerPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pitchAngleRulerPictureBox.Image = global::DCS.Properties.Resources.pitchAngleRuler;
            this.pitchAngleRulerPictureBox.Location = new System.Drawing.Point(29, 503);
            this.pitchAngleRulerPictureBox.Name = "pitchAngleRulerPictureBox";
            this.pitchAngleRulerPictureBox.Size = new System.Drawing.Size(34, 160);
            this.pitchAngleRulerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pitchAngleRulerPictureBox.TabIndex = 2;
            this.pitchAngleRulerPictureBox.TabStop = false;
            // 
            // serialPort
            // 
            this.serialPort.BaudRate = 115200;
            this.serialPort.Parity = System.IO.Ports.Parity.Even;
            this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.SerialPort_DataReceived);
            // 
            // cameraViewImageBox
            // 
            this.cameraViewImageBox.Controls.Add(this.aimingReticlePictureBox);
            this.cameraViewImageBox.Controls.Add(this.dialPlatePictureBox);
            this.cameraViewImageBox.Controls.Add(this.pitchAngleRulerPictureBox);
            this.cameraViewImageBox.Location = new System.Drawing.Point(0, 80);
            this.cameraViewImageBox.MaximumSize = new System.Drawing.Size(1280, 720);
            this.cameraViewImageBox.MinimumSize = new System.Drawing.Size(1280, 720);
            this.cameraViewImageBox.Name = "cameraViewImageBox";
            this.cameraViewImageBox.Size = new System.Drawing.Size(1280, 720);
            this.cameraViewImageBox.TabIndex = 2;
            this.cameraViewImageBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.cameraViewImageBox);
            this.Controls.Add(this.topBar);
            this.Name = "MainForm";
            this.Text = "DCS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aimingReticlePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialPlatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pitchAngleRulerPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewImageBox)).EndInit();
            this.cameraViewImageBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private OnOffSwitchButton servoControlSwitchButton;
        private System.Windows.Forms.Label servoControlLabel;
        private OnOffSwitchButton laserControlSwitchButton;
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
        private System.Windows.Forms.PictureBox pitchAngleRulerPictureBox;
        private System.Windows.Forms.PictureBox dialPlatePictureBox;
        private System.Windows.Forms.PictureBox aimingReticlePictureBox;
        private Emgu.CV.UI.ImageBox cameraViewImageBox;
    }
}

