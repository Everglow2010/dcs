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
    public partial class AimingReticleConfigForm : Form
    {
        private const int FOCAL_LEVEL_NUM = 20;
        private List<Button> buttonList = new List<Button>(FOCAL_LEVEL_NUM);
        public AimingReticleConfigForm()
        {
            InitializeComponent();
            buttonList.Add(this.button1);
            buttonList.Add(this.button2);
            buttonList.Add(this.button3);
            buttonList.Add(this.button4);
            buttonList.Add(this.button5);
            buttonList.Add(this.button6);
            buttonList.Add(this.button7);
            buttonList.Add(this.button8);
            buttonList.Add(this.button9);
            buttonList.Add(this.button10);
            buttonList.Add(this.button11);
            buttonList.Add(this.button12);
            buttonList.Add(this.button13);
            buttonList.Add(this.button14);
            buttonList.Add(this.button15);
            buttonList.Add(this.button16);
            buttonList.Add(this.button17);
            buttonList.Add(this.button18);
            buttonList.Add(this.button19);
            buttonList.Add(this.button20);
        }

        private void AimingRecticleConfigForm_Load(object sender, EventArgs e)
        {

        }
        //当前选中的要调整的焦距级别的瞄准分划
        private int focalLevelSlected = 0;
        //调整前位置记录
        private Point originalPosition = new Point(0, 0);
        //调整后位置记录
        private Point adjustedPosition = new Point(0, 0);

        public delegate void AimingReticlePositionChangeHandler(Point pos);
        public event AimingReticlePositionChangeHandler AimingReticlePositionChange;

        private void LightOnlyOneButton(int index)
        {
            for (int i = 0; i < FOCAL_LEVEL_NUM; i++)
            {
                if (i+1 == index)
                {
                    buttonList[i].FlatAppearance.BorderColor = Color.Yellow;
                }
                else
                {
                    buttonList[i].FlatAppearance.BorderColor = Color.White;
                }
                buttonList[i].Refresh();
            }
            originalPosition.X = GlobalVars.aimingReticleConfigs[index-1].posX;
            originalPosition.Y = GlobalVars.aimingReticleConfigs[index-1].posY;
            adjustedPosition.X = originalPosition.X;
            adjustedPosition.Y = originalPosition.Y;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 1;
            LightOnlyOneButton(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 2;
            LightOnlyOneButton(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 3;
            LightOnlyOneButton(3);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 4;
            LightOnlyOneButton(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 5;
            LightOnlyOneButton(5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 6;
            LightOnlyOneButton(6);
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 7;
            LightOnlyOneButton(7);
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 8;
            LightOnlyOneButton(8);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 9;
            LightOnlyOneButton(9);
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 10;
            LightOnlyOneButton(10);
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 11;
            LightOnlyOneButton(11);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 12;
            LightOnlyOneButton(12);
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 13;
            LightOnlyOneButton(13);
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 14;
            LightOnlyOneButton(14);
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 15;
            LightOnlyOneButton(15);
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 16;
            LightOnlyOneButton(16);
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 17;
            LightOnlyOneButton(17);
        }

        private void Button18_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 18;
            LightOnlyOneButton(18);
        }

        private void Button19_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 19;
            LightOnlyOneButton(19);
        }

        private void Button20_Click(object sender, EventArgs e)
        {
            this.focalLevelSlected = 20;
            LightOnlyOneButton(20);
        }

        private void RecticleResetButton_Click(object sender, EventArgs e)
        {
            if (focalLevelSlected==0)
            {
                MessageBox.Show("请先选定焦距级别！");
            }
            else
            {
                //复位
                adjustedPosition.X = originalPosition.X;
                adjustedPosition.Y = originalPosition.Y;
                //触发事件
                this.AimingReticlePositionChange?.Invoke(new Point(adjustedPosition.X, adjustedPosition.Y));
            }
        }

        private void RecticleApplyButton_Click(object sender, EventArgs e)
        {
            if (focalLevelSlected == 0)
            {
                MessageBox.Show("请先选定焦距级别！");
            }
            else
            {
                //应用位置
                GlobalVars.aimingReticleConfigs[focalLevelSlected - 1].posX = adjustedPosition.X;
                GlobalVars.aimingReticleConfigs[focalLevelSlected - 1].posY = adjustedPosition.Y;
                //写入配置文件
                AppConfigManager.SetValue("aimingReticleConfig" + focalLevelSlected + ".posX", adjustedPosition.X.ToString());
                AppConfigManager.SetValue("aimingReticleConfig" + focalLevelSlected + ".posY", adjustedPosition.Y.ToString());
                //触发事件
                this.AimingReticlePositionChange?.Invoke(new Point(adjustedPosition.X, adjustedPosition.Y));
            }
        }

        private void RecticleQuitButton_Click(object sender, EventArgs e)
        {
            //更新配置文件
            for (int i = 0; i < FOCAL_LEVEL_NUM; i++)
            {
                AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".posX", GlobalVars.aimingReticleConfigs[i].posX.ToString());
                AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".posY", GlobalVars.aimingReticleConfigs[i].posY.ToString());
            }
            this.Close();
        }
    }
}
