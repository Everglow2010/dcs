using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCS
{
    public partial class AimingReticleConfigForm0 : Form
    {
        public AimingReticleConfigForm0()
        {
            InitializeComponent();
        }

        private void AimingReticleConfigForm_Load(object sender, EventArgs e)
        {

        }

        private void DialPlateAngleClearButton_Click(object sender, EventArgs e)
        {
            GlobalVars.dialPlateAngleClear = true;
        }

        private void pitchAngleClearButton_Click(object sender, EventArgs e)
        {
            GlobalVars.pitchAngleClear = true;
        }
    }
}
