using System;
using System.Windows.Forms;

namespace DCS
{
    public partial class AmmoLoadConfigForm : Form
    {
        public AmmoLoadConfigForm()
        {
            InitializeComponent();
        }

        private string ammoLoadNumStr = "";
        private int ammoLoadNumInt;

        private void AmmoLoadConfigForm_Load(object sender, EventArgs e)
        {
            //ammoLoadNumTextbox.Text = Convert.ToString(GlobalVars.ammoLoadNum);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "1";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "2";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "3";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "4";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "5";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "6";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "7";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "8";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "9";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr += "0";
            ammoLoadNumTextbox.Text = ammoLoadNumStr;
        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            ammoLoadNumStr = "";
            ammoLoadNumTextbox.Clear();
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            try
            {
                ammoLoadNumInt = Convert.ToInt32(ammoLoadNumStr);
                ammoLoadNumTextbox.Text = ammoLoadNumStr;
                GlobalVars.ammoLoadNum = ammoLoadNumInt;
                MessageBox.Show("装弹数量已成功设置为：" + ammoLoadNumInt);
                ammoLoadNumStr = "";
                DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {
                MessageBox.Show("输入数字不正确，请重新输入！");
                ammoLoadNumTextbox.Clear();
            }
            
        }
        //射弹计数清零按钮点击触发
        private void ProjectileCountClearButton_Click(object sender, EventArgs e)
        {
            GlobalVars.projectileCountClear = true;
        }
    }
}
