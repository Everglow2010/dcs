using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCS
{
    public partial class AimingReticleConfigPanel : UserControl
    {
        private int indexInList;
        private int posXModified;
        private int posYModified;
        private int posX;
        private int posY;
        private int sizePercent;
        private int size;
        //private int height;
        //private int width;

        public AimingReticleConfigPanel(int index)
        {
            InitializeComponent();
            this.indexInList = index;
            this.posX = GlobalVars.aimingReticleConfigs[index].posX;
            this.posY = GlobalVars.aimingReticleConfigs[index].posY;
            this.posXModified = this.posX;
            this.posYModified = this.posY;
            this.sizePercent = GlobalVars.aimingReticleConfigs[index].sizePercent;
            Console.WriteLine(this.indexInList + "  " + this.posX + "  " + this.posY + "  " + this.sizePercent);
        }

        private void SizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            this.sizeTrackBarValueLabel.Text = this.sizeTrackBar.Value.ToString()+"%";
        }

        private void ButtonIncrease_Click(object sender, EventArgs e)
        {
            this.sizeTrackBar.Value = (this.sizeTrackBar.Value + 5) > 100 ? 100 : this.sizeTrackBar.Value + 5;
        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            this.sizeTrackBar.Value = (this.sizeTrackBar.Value - 5) < -100 ? -100 : this.sizeTrackBar.Value - 5;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            this.posYModified = (this.posYModified - 5) < 0 ? 0 : this.posYModified - 5;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            this.posYModified = (this.posYModified + 5) > 720 ? 720 : this.posYModified + 5;
        }

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
            this.posXModified = (this.posXModified - 5) < 0 ? 0 : this.posXModified - 5;
        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            this.posXModified = (this.posXModified + 5) > 1280 ? 1280 : this.posXModified + 5;
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            this.sizePercent = this.sizeTrackBar.Value;
            this.size = 250 + (int)((this.sizePercent / 100.0) * 250);
            this.posX = this.posXModified;
            this.posY = this.posYModified;

            GlobalVars.aimingReticleConfigs[this.indexInList].posX = this.posX;
            GlobalVars.aimingReticleConfigs[this.indexInList].posY = this.posY;
            GlobalVars.aimingReticleConfigs[this.indexInList].sizePercent = this.sizePercent;
            GlobalVars.aimingReticleConfigs[this.indexInList].size = this.size;

            //写入配置文件
            AppConfigManager.SetValue("aimingReticleConfig" + this.indexInList + ".posX", this.posX.ToString());
            AppConfigManager.SetValue("aimingReticleConfig" + this.indexInList + ".posY", this.posY.ToString());
            AppConfigManager.SetValue("aimingReticleConfig" + this.indexInList + ".size", this.size.ToString());
            AppConfigManager.SetValue("aimingReticleConfig" + this.indexInList + ".sizePercent", this.sizePercent.ToString());
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            this.posX = GlobalVars.aimingReticleConfigs[indexInList].posX;
            this.posY = GlobalVars.aimingReticleConfigs[indexInList].posY;
            this.sizePercent = GlobalVars.aimingReticleConfigs[indexInList].sizePercent;
            this.sizeTrackBar.Value = GlobalVars.aimingReticleConfigs[indexInList].sizePercent;
        }
    }
}
