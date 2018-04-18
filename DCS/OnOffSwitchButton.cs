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

    public enum SwitchButtonStyle
    {
        style1 = 1,
        style2 = 2,
        style3 = 3,
        style4 = 4,
        style5 = 5,
        style6 = 6
    };

    public partial class OnOffSwitchButton : UserControl
    {
        public OnOffSwitchButton()
        {
            InitializeComponent();

            //设置Style支持透明背景色并且双缓冲
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.Selectable, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.SetStyle(ControlStyles.UserPaint, true);

            this.BackColor = Color.Transparent;
            this.Cursor = Cursors.Hand;
            this.Size = new Size(87, 27);
        }

        bool isChecked = false;

        /// <summary>
        /// 是否选中
        /// </summary>
        public bool Checked
        {
            set { isChecked = value; this.Invalidate(); }
            get { return isChecked; }
        }

        SwitchButtonStyle checkStyle = SwitchButtonStyle.style1;

        /// <summary>
        /// 样式
        /// </summary>
        public SwitchButtonStyle CheckStyleX
        {
            set { checkStyle = value; this.Invalidate(); }
            get { return checkStyle; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Bitmap bitMapOn = null;
            Bitmap bitMapOff = null;

            if (checkStyle == SwitchButtonStyle.style1)
            {
                bitMapOn = global::DCS.Properties.Resources.btncheckon1;
                bitMapOff = global::DCS.Properties.Resources.btncheckoff1;
            }
            else if (checkStyle == SwitchButtonStyle.style2)
            {
                bitMapOn = global::DCS.Properties.Resources.btncheckon2;
                bitMapOff = global::DCS.Properties.Resources.btncheckoff2;
            }
            else if (checkStyle == SwitchButtonStyle.style3)
            {
                bitMapOn = global::DCS.Properties.Resources.btncheckon3;
                bitMapOff = global::DCS.Properties.Resources.btncheckoff3;
            }
            else if (checkStyle == SwitchButtonStyle.style4)
            {
                bitMapOn = global::DCS.Properties.Resources.btncheckon4;
                bitMapOff = global::DCS.Properties.Resources.btncheckoff4;
            }
            else if (checkStyle == SwitchButtonStyle.style5)
            {
                bitMapOn = global::DCS.Properties.Resources.btncheckon5;
                bitMapOff = global::DCS.Properties.Resources.btncheckoff5;
            }
            else if (checkStyle == SwitchButtonStyle.style6)
            {
                bitMapOn = global::DCS.Properties.Resources.btncheckon6;
                bitMapOff = global::DCS.Properties.Resources.btncheckoff6;
            }

            Graphics g = e.Graphics;
            Rectangle rec = new Rectangle(0, 0, this.Size.Width, this.Size.Height);

            if (isChecked)
            {
                g.DrawImage(bitMapOn, rec);
            }
            else
            {
                g.DrawImage(bitMapOff, rec);
            }
        }

        private void OnOffSwitchButton_Click(object sender, EventArgs e)
        {
            isChecked = !isChecked;
            this.Invalidate();
        }
    }
}
