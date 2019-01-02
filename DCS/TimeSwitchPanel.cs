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
            System.DateTime currentTime = DateTime.Now;
            string nowTimeStr = currentTime.ToString("HH:mm");
            this.nowTimeButton.Text = "当前时间 " + nowTimeStr;

            TimeSpan ts = currentTime.Subtract(GlobalVars.startTime);
            int minutes = (int)(ts.TotalMinutes + 1);
            int HH = minutes / 60;
            int mm = minutes % 60;
            string workTimeStr = string.Format("{0:D2}:{1:D2}", HH, mm);
            Console.WriteLine("面板初始化时的工作时间：" + workTimeStr);
            this.workTimeButton.Text = "工作时间 " + workTimeStr;
        }
        public delegate void SwitchStateChangeHandler(int type);
        public event SwitchStateChangeHandler TimeTypeChange;

        public void InitialTime()
        {
            System.DateTime currentTime = DateTime.Now;
            string nowTimeStr = currentTime.ToString("HH:mm");
            this.nowTimeButton.Text = "当前时间 " + nowTimeStr;

            TimeSpan ts = currentTime.Subtract(GlobalVars.startTime);
            int minutes = (int)(ts.TotalMinutes + 1);
            int HH = minutes / 60;
            int mm = minutes % 60;
            string workTimeStr = string.Format("{0:D2}:{1:D2}", HH, mm);
            Console.WriteLine("面板初始化时的工作时间：" + workTimeStr);
            this.workTimeButton.Text = "工作时间 " + workTimeStr;
        }

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
            //显示当前时间
            GlobalVars.timeChosen = 0;
            TimeTypeChange?.Invoke(GlobalVars.timeChosen);
            this.Enabled = false;
            this.Visible = false;
        }

        private void WorkTimeButton_Click(object sender, EventArgs e)
        {
            //显示工作时间
            GlobalVars.timeChosen = 1;
            TimeTypeChange?.Invoke(GlobalVars.timeChosen);
            this.Enabled = false;
            this.Visible = false;
        }
    }
}
