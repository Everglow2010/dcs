using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DCS
{
    class PitchAnglePictureBox : PictureBox
    {
        public PitchAnglePictureBox()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private Image pitchAnglePointerImg = Properties.Resources.pitchAnglePointer;

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);

            Graphics graphics = null;
            graphics = this.CreateGraphics();
            double temp = 166.7 + GlobalVars.pitchAngleWithMil;
            int offsetY = (int)(this.Height - (temp / 1166.7) * this.Height);
            graphics.DrawImage(pitchAnglePointerImg, new Rectangle(0, offsetY, this.Width/2, 5));
            //graphics.Save();
        }
    }
}
