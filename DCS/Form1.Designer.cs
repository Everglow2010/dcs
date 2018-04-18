namespace DCS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.topBar = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.onOffSwitchButton2 = new DCS.OnOffSwitchButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.onOffSwitchButton1 = new DCS.OnOffSwitchButton();
            this.cameraViewPicturebox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.topBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // topBar
            // 
            this.topBar.BackColor = System.Drawing.Color.Black;
            this.topBar.Controls.Add(this.button2);
            this.topBar.Controls.Add(this.textBox1);
            this.topBar.Controls.Add(this.label4);
            this.topBar.Controls.Add(this.button1);
            this.topBar.Controls.Add(this.label3);
            this.topBar.Controls.Add(this.onOffSwitchButton2);
            this.topBar.Controls.Add(this.label2);
            this.topBar.Controls.Add(this.label1);
            this.topBar.Controls.Add(this.onOffSwitchButton1);
            this.topBar.Location = new System.Drawing.Point(0, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(1280, 80);
            this.topBar.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(386, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 18);
            this.button1.TabIndex = 5;
            this.button1.Text = "设置";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(307, 38);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "参数设置";
            // 
            // onOffSwitchButton2
            // 
            this.onOffSwitchButton2.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitchButton2.Checked = false;
            this.onOffSwitchButton2.CheckStyleX = DCS.SwitchButtonStyle.style1;
            this.onOffSwitchButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onOffSwitchButton2.Location = new System.Drawing.Point(237, 38);
            this.onOffSwitchButton2.Name = "onOffSwitchButton2";
            this.onOffSwitchButton2.Size = new System.Drawing.Size(51, 16);
            this.onOffSwitchButton2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(158, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "激光控制";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "伺服控制";
            // 
            // onOffSwitchButton1
            // 
            this.onOffSwitchButton1.BackColor = System.Drawing.Color.Transparent;
            this.onOffSwitchButton1.Checked = false;
            this.onOffSwitchButton1.CheckStyleX = DCS.SwitchButtonStyle.style1;
            this.onOffSwitchButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.onOffSwitchButton1.Location = new System.Drawing.Point(88, 38);
            this.onOffSwitchButton1.Name = "onOffSwitchButton1";
            this.onOffSwitchButton1.Size = new System.Drawing.Size(51, 16);
            this.onOffSwitchButton1.TabIndex = 0;
            this.onOffSwitchButton1.Load += new System.EventHandler(this.onOffSwitchButton1_Load);
            // 
            // cameraViewPicturebox
            // 
            this.cameraViewPicturebox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cameraViewPicturebox.BackgroundImage")));
            this.cameraViewPicturebox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cameraViewPicturebox.Location = new System.Drawing.Point(0, 80);
            this.cameraViewPicturebox.Name = "cameraViewPicturebox";
            this.cameraViewPicturebox.Size = new System.Drawing.Size(1280, 720);
            this.cameraViewPicturebox.TabIndex = 1;
            this.cameraViewPicturebox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(446, 38);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "剩余弹量";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(525, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(32, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "60";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(563, 38);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 18);
            this.button2.TabIndex = 8;
            this.button2.Text = "设置";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.cameraViewPicturebox);
            this.Controls.Add(this.topBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cameraViewPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.PictureBox cameraViewPicturebox;
        private OnOffSwitchButton onOffSwitchButton1;
        private System.Windows.Forms.Label label1;
        private OnOffSwitchButton onOffSwitchButton2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

