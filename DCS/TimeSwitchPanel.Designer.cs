namespace DCS
{
    partial class TimeSwitchPanel
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.nowTimeButton = new System.Windows.Forms.Button();
            this.workTimeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nowTimeButton
            // 
            this.nowTimeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.nowTimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nowTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.nowTimeButton.FlatAppearance.BorderSize = 2;
            this.nowTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nowTimeButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nowTimeButton.ForeColor = System.Drawing.Color.White;
            this.nowTimeButton.Location = new System.Drawing.Point(0, 0);
            this.nowTimeButton.Margin = new System.Windows.Forms.Padding(0);
            this.nowTimeButton.Name = "nowTimeButton";
            this.nowTimeButton.Size = new System.Drawing.Size(142, 60);
            this.nowTimeButton.TabIndex = 0;
            this.nowTimeButton.Text = "当前时间 12:00";
            this.nowTimeButton.UseVisualStyleBackColor = false;
            this.nowTimeButton.Click += new System.EventHandler(this.NowTimeButton_Click);
            this.nowTimeButton.MouseEnter += new System.EventHandler(this.NowTimeButton_MouseEnter);
            this.nowTimeButton.MouseLeave += new System.EventHandler(this.NowTimeButton_MouseLeave);
            // 
            // workTimeButton
            // 
            this.workTimeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.workTimeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.workTimeButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.workTimeButton.FlatAppearance.BorderSize = 2;
            this.workTimeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.workTimeButton.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.workTimeButton.ForeColor = System.Drawing.Color.White;
            this.workTimeButton.Location = new System.Drawing.Point(0, 60);
            this.workTimeButton.Margin = new System.Windows.Forms.Padding(0);
            this.workTimeButton.Name = "workTimeButton";
            this.workTimeButton.Size = new System.Drawing.Size(142, 60);
            this.workTimeButton.TabIndex = 1;
            this.workTimeButton.Text = "工作时长 00:00";
            this.workTimeButton.UseVisualStyleBackColor = false;
            this.workTimeButton.Click += new System.EventHandler(this.WorkTimeButton_Click);
            this.workTimeButton.MouseEnter += new System.EventHandler(this.WorkTimeButton_MouseEnter);
            this.workTimeButton.MouseLeave += new System.EventHandler(this.WorkTimeButton_MouseLeave);
            // 
            // TimeSwitchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.workTimeButton);
            this.Controls.Add(this.nowTimeButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TimeSwitchPanel";
            this.Size = new System.Drawing.Size(142, 120);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nowTimeButton;
        private System.Windows.Forms.Button workTimeButton;
    }
}
