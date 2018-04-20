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
            this.topBar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.servoControlSwitchButton = new DCS.OnOffSwitchButton();
            this.cameraViewPicturebox = new System.Windows.Forms.PictureBox();
            this.dialPlatePictureBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewPicturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialPlatePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Black;
            this.topBar.Controls.Add(this.servoControlSwitchButton);
            this.topBar.Controls.Add(this.label1);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(947, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "电池电量";
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
            this.safeStatePitureBox.Image = global::DCS.Properties.Resources.保险关;
            this.safeStatePitureBox.Location = new System.Drawing.Point(808, 38);
            this.safeStatePitureBox.Name = "safeStatePitureBox";
            this.safeStatePitureBox.Size = new System.Drawing.Size(119, 21);
            this.safeStatePitureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.safeStatePitureBox.TabIndex = 10;
            this.safeStatePitureBox.TabStop = false;
            // 
            // ammoLoadPictureBox
            // 
            this.ammoLoadPictureBox.Image = global::DCS.Properties.Resources.未装;
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
            this.parameterConfigButton.Click += new System.EventHandler(this.button1_Click);
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
            this.servoControlSwitchButton.Load += new System.EventHandler(this.onOffSwitchButton1_Load);
            // 
            // cameraViewPicturebox
            // 
            this.cameraViewPicturebox.BackColor = System.Drawing.Color.Transparent;
            this.cameraViewPicturebox.BackgroundImage = global::DCS.Properties.Resources.监控背景画面;
            this.cameraViewPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraViewPicturebox.Image = global::DCS.Properties.Resources.监控背景画面;
            this.cameraViewPicturebox.Location = new System.Drawing.Point(0, 80);
            this.cameraViewPicturebox.Name = "cameraViewPicturebox";
            this.cameraViewPicturebox.Size = new System.Drawing.Size(1280, 720);
            this.cameraViewPicturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cameraViewPicturebox.TabIndex = 1;
            this.cameraViewPicturebox.TabStop = false;
            // 
            // dialPlatePictureBox
            // 
            this.dialPlatePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.dialPlatePictureBox.Image = global::DCS.Properties.Resources.仪表盘表盘;
            this.dialPlatePictureBox.Location = new System.Drawing.Point(88, 583);
            this.dialPlatePictureBox.Name = "dialPlatePictureBox";
            this.dialPlatePictureBox.Size = new System.Drawing.Size(160, 160);
            this.dialPlatePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dialPlatePictureBox.TabIndex = 0;
            this.dialPlatePictureBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DCS.Properties.Resources.俯仰角度标尺;
            this.pictureBox1.Location = new System.Drawing.Point(24, 583);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dialPlatePictureBox);
            this.Controls.Add(this.cameraViewPicturebox);
            this.Controls.Add(this.topBar);
            this.Name = "MainForm";
            this.Text = "DCS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.safeStatePitureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ammoLoadPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewPicturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dialPlatePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.PictureBox cameraViewPicturebox;
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
        private System.Windows.Forms.PictureBox dialPlatePictureBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar batteryBar;
        private System.Windows.Forms.Label label1;
    }
}

