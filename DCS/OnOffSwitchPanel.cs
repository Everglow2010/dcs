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
    public partial class OnOffSwitchPanel : UserControl
    {
        private int switchType;
        public delegate void SwitchStateChangeHandler(Boolean state);
        public event SwitchStateChangeHandler SwitchStateChange;
        //带参构造函数可以选择伺服开关还是辅助瞄准开关
        public OnOffSwitchPanel(int type)
        {
            InitializeComponent();
            switchType = type;
            if (type == GlobalVars.SERVO_CONTROL)
            {
                this.turnOnButton.BackgroundImage = Properties.Resources.ServoControlTurnOnButtonImage;
                this.turnOffButton.BackgroundImage = Properties.Resources.ServoControlTurnOffButtonImage;
            }
            else if (type == GlobalVars.LASER_CONTROL)
            {
                this.turnOnButton.BackgroundImage = Properties.Resources.LaserControlTurnOnButtonImage;
                this.turnOffButton.BackgroundImage = Properties.Resources.LaserControlTurnOffButtonImage;
            }
        }
        //默认构造函数是辅助瞄准开关
        public OnOffSwitchPanel()
        {
            InitializeComponent();
            this.switchType = GlobalVars.LASER_CONTROL;
            this.turnOnButton.BackgroundImage = Properties.Resources.LaserControlTurnOnButtonImage;
            this.turnOffButton.BackgroundImage = Properties.Resources.LaserControlTurnOffButtonImage;
        }

        private void TurnOnButton_MouseEnter(object sender, EventArgs e)
        {
            this.turnOnButton.FlatAppearance.BorderColor = Color.Yellow;
            this.turnOnButton.Refresh();
        }

        private void TurnOnButton_MouseLeave(object sender, EventArgs e)
        {
            this.turnOnButton.FlatAppearance.BorderColor = Color.FromArgb(38, 38, 38);
            this.turnOnButton.Refresh();
        }

        private void TurnOffButton_MouseEnter(object sender, EventArgs e)
        {
            this.turnOffButton.FlatAppearance.BorderColor = Color.Yellow;
            this.turnOffButton.Refresh();
        }

        private void TurnOffButton_MouseLeave(object sender, EventArgs e)
        {
            this.turnOffButton.FlatAppearance.BorderColor = Color.FromArgb(38, 38, 38);
            this.turnOffButton.Refresh();
        }

        private void TurnOnButton_Click(object sender, EventArgs e)
        {
            if (switchType == GlobalVars.SERVO_CONTROL)
            {
                GlobalVars.servoControlSwitchState = true;
                SwitchStateChange?.Invoke(GlobalVars.servoControlSwitchState);
            }
            else if (switchType == GlobalVars.LASER_CONTROL)
            {
                GlobalVars.laserControlSwitchState = true;
                SwitchStateChange?.Invoke(GlobalVars.laserControlSwitchState);
            }
            this.Enabled = false;
            this.Visible = false;
        }

        private void TurnOffButton_Click(object sender, EventArgs e)
        {
            if (switchType == GlobalVars.SERVO_CONTROL)
            {
                GlobalVars.servoControlSwitchState = false;
                SwitchStateChange?.Invoke(GlobalVars.servoControlSwitchState);
            }
            else if (switchType == GlobalVars.LASER_CONTROL)
            {
                GlobalVars.laserControlSwitchState = false;
                SwitchStateChange?.Invoke(GlobalVars.laserControlSwitchState);
            }
            this.Enabled = false;
            this.Visible = false;
        }
    }
}
