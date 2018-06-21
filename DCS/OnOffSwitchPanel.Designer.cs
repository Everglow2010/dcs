namespace DCS
{
    partial class OnOffSwitchPanel
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
            this.turnOnButton = new System.Windows.Forms.Button();
            this.turnOffButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // turnOnButton
            // 
            this.turnOnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.turnOnButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.turnOnButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.turnOnButton.FlatAppearance.BorderSize = 2;
            this.turnOnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnOnButton.Location = new System.Drawing.Point(0, 0);
            this.turnOnButton.Margin = new System.Windows.Forms.Padding(0);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(142, 60);
            this.turnOnButton.TabIndex = 0;
            this.turnOnButton.UseVisualStyleBackColor = false;
            this.turnOnButton.Click += new System.EventHandler(this.TurnOnButton_Click);
            this.turnOnButton.MouseEnter += new System.EventHandler(this.TurnOnButton_MouseEnter);
            this.turnOnButton.MouseLeave += new System.EventHandler(this.TurnOnButton_MouseLeave);
            // 
            // turnOffButton
            // 
            this.turnOffButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.turnOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.turnOffButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.turnOffButton.FlatAppearance.BorderSize = 2;
            this.turnOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.turnOffButton.Location = new System.Drawing.Point(0, 60);
            this.turnOffButton.Margin = new System.Windows.Forms.Padding(0);
            this.turnOffButton.Name = "turnOffButton";
            this.turnOffButton.Size = new System.Drawing.Size(142, 60);
            this.turnOffButton.TabIndex = 1;
            this.turnOffButton.UseVisualStyleBackColor = false;
            this.turnOffButton.Click += new System.EventHandler(this.TurnOffButton_Click);
            this.turnOffButton.MouseEnter += new System.EventHandler(this.TurnOffButton_MouseEnter);
            this.turnOffButton.MouseLeave += new System.EventHandler(this.TurnOffButton_MouseLeave);
            // 
            // OnOffSwitchPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.turnOffButton);
            this.Controls.Add(this.turnOnButton);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "OnOffSwitchPanel";
            this.Size = new System.Drawing.Size(142, 120);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button turnOnButton;
        private System.Windows.Forms.Button turnOffButton;
    }
}
