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
    public partial class AimingRecticleConfigForm : Form
    {
        private const int FOCAL_LEVEL_NUM = 20;
        public AimingRecticleConfigForm()
        {
            InitializeComponent();
        }

        private void AimingRecticleConfigForm_Load(object sender, EventArgs e)
        {

        }
        //当前选中的要调整的焦距级别的瞄准分划
        private int focalLevelSlected = 0;


        private void Button1_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 1;
            this.button1.FlatAppearance.BorderColor = Color.Yellow;
        }
    }
}
