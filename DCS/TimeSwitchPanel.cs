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
    public partial class TimeSwitchPanel : UserControl
    {
        public TimeSwitchPanel()
        {
            InitializeComponent();
        }
        private int switchType;
        public delegate void SwitchStateChangeHandler(Boolean state);
        public event SwitchStateChangeHandler SwitchStateChange;

        private void NowTimeButton_MouseEnter(object sender, EventArgs e)
        {
            this.nowTimeButton.FlatAppearance.BorderColor = Color.Yellow;
            this.nowTimeButton.Refresh();
        }

        private void NowTimeButton_MouseLeave(object sender, EventArgs e)
        {
            this.nowTimeButton.FlatAppearance.BorderColor = Color.FromArgb(38, 38, 38);
            this.nowTimeButton.Refresh();
        }

        private void WorkTimeButton_MouseEnter(object sender, EventArgs e)
        {
            this.workTimeButton.FlatAppearance.BorderColor = Color.Yellow;
            this.workTimeButton.Refresh();
        }

        private void WorkTimeButton_MouseLeave(object sender, EventArgs e)
        {
            this.workTimeButton.FlatAppearance.BorderColor = Color.FromArgb(38, 38, 38);
            this.workTimeButton.Refresh();
        }

        private void NowTimeButton_Click(object sender, EventArgs e)
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

        private void WorkTimeButton_Click(object sender, EventArgs e)
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
