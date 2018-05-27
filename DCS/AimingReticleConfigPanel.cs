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
        public AimingReticleConfigPanel()
        {
            InitializeComponent();
        }

        private void SizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            this.sizeTrackBarValueLabel.Text = this.sizeTrackBar.Value.ToString();
        }
    }
}
