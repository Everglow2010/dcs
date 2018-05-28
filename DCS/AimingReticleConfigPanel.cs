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
        private int posX;
        private int posY;
        private int sizePercent;
        //private int height;
        //private int width;

        public AimingReticleConfigPanel(int index)
        {
            InitializeComponent();
            this.indexInList = index;
            this.posX = GlobalVars.aimingReticleConfigs[index].posX;
            this.posY = GlobalVars.aimingReticleConfigs[index].posY;
            this.sizePercent = GlobalVars.aimingReticleConfigs[index].sizePercent;
            Console.WriteLine(this.indexInList + "  " + this.posX + "  " + this.posY + "  " + this.sizePercent);
        }

        private void SizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            this.sizeTrackBarValueLabel.Text = this.sizeTrackBar.Value.ToString();
        }

        private void buttonIncrease_Click(object sender, EventArgs e)
        {
            this.sizeTrackBar.Value = (this.sizeTrackBar.Value + 5) > 100 ? 100 : this.sizeTrackBar.Value + 5;
        }

        private void buttonDecrease_Click(object sender, EventArgs e)
        {
            this.sizeTrackBar.Value = (this.sizeTrackBar.Value - 5) < -100 ? -100 : this.sizeTrackBar.Value - 5;
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            this.posY = (this.posY - 5) < 0 ? 0 : this.posY - 5;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            this.posY = (this.posY + 5) > 720 ? 720 : this.posY + 5;
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            this.posX = (this.posX - 5) < 0 ? 0 : this.posX - 5;
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            this.posX = (this.posX + 5) > 1280 ? 1280 : this.posX + 5;
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.sizePercent = this.sizeTrackBar.Value;
            GlobalVars.aimingReticleConfigs[this.indexInList].posX = this.posX;
            GlobalVars.aimingReticleConfigs[this.indexInList].posY = this.posY;
            GlobalVars.aimingReticleConfigs[this.indexInList].sizePercent = this.sizePercent;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.posX = GlobalVars.aimingReticleConfigs[indexInList].posX;
            this.posY = GlobalVars.aimingReticleConfigs[indexInList].posY;
            this.sizePercent = GlobalVars.aimingReticleConfigs[indexInList].sizePercent;
            this.sizeTrackBar.Value = GlobalVars.aimingReticleConfigs[indexInList].sizePercent;
        }
    }
}
