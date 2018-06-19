using System;
using System.Windows.Forms;
using System.IO.Ports;
using Emgu.CV;
using System.Collections.Generic;
using System.Drawing;
using Emgu.CV.Structure;

namespace DCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.UserPaint, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

            //初始化全局变量，从配置文件中读取
            GlobalVars.cameraIP = AppConfigManager.GetValue("cameraIP");
            GlobalVars.cameraPort = AppConfigManager.GetValue("cameraPort");
            GlobalVars.userName = AppConfigManager.GetValue("userName");
            GlobalVars.userPassword = AppConfigManager.GetValue("userPassword");
            GlobalVars.cameraRTSPPath = AppConfigManager.GetValue("cameraRTSPPath");

            //GlobalVars.cameraIP = "178.178.1.131";
            //GlobalVars.cameraPort = "554";
            //GlobalVars.userName = "admin";
            //GlobalVars.userPassword = "abcd1234";
            //GlobalVars.cameraRTSPPath = "rtsp://" + GlobalVars.userName + ":" + GlobalVars.userPassword + "@" + GlobalVars.cameraIP + ":" + GlobalVars.cameraPort + "/mpeg4/ch33/main/av_stream";

            GlobalVars.servoControlSwitchState = true;//伺服使能开关默认为开
            GlobalVars.laserControlSwitchState = false;//激光控制开关默认为关闭

            GlobalVars.ammoLoadNum = 200;
            GlobalVars.ammoLeftNum = 200;
            GlobalVars.projectileCount = 0;
            GlobalVars.projectileCountClear = false;

            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_NOT_LOADED;
            GlobalVars.safeState = true;

            GlobalVars.pitchAngleWithMil = 0;
            GlobalVars.pitchAngleWithDegree = 0;
            GlobalVars.pitchAngleClear = false;

            GlobalVars.dialPlateAngleWithMil = 0;
            GlobalVars.dialPlateAngleWithDegree = 0;
            GlobalVars.dialPlateAngleClear = false;

            this.dialPlateValueLabel.Text = Convert.ToString(GlobalVars.dialPlateAngleWithDegree);
            this.pitchAngleValueLabel.Text = Convert.ToString(GlobalVars.pitchAngleWithMil);
            this.ammoLeftTextBox.Text = Convert.ToString(GlobalVars.ammoLeftNum);
            //初始化20个焦距档位对应的瞄准分划大小和位置
            for (int i = 0; i < 20; i++)
            {
                GlobalVars.aimingReticleConfigs[i].posX = 515;
                GlobalVars.aimingReticleConfigs[i].posY = 235;
                GlobalVars.aimingReticleConfigs[i].sizePercent = 0;
                GlobalVars.aimingReticleConfigs[i].size = 250 + (int)((GlobalVars.aimingReticleConfigs[i].sizePercent / 100.0) * 250);

                AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".posX", "515");
                AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".posY", "235");
                AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".sizePercent", "0");
                AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".size", GlobalVars.aimingReticleConfigs[i].size.ToString());
            }
            //实例化委托
            flushAllUI = new FreshUIDisplay(DisplayToUI);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(GlobalVars.cameraRTSPPath);
            //启动emgucv视频捕捉显示
            PlayVideo();

            //byte[] c = new byte[2];
            //c[0] = 0x79;
            //c[1] = 0xfd;
            //short x = BitConverter.ToInt16(c, 0);
            //Console.WriteLine(x);
            //short a = -1667;
            //byte[] b = new byte[2];
            //b = BitConverter.GetBytes(a);
            //Console.WriteLine(BitConverter.ToString(b));

            String[] portsNames = SerialPort.GetPortNames();
            if (portsNames == null)
            {
                MessageBox.Show("本机没有串口！", "error");
                return;
            }
            else
            {
                //打开串口
                serialPort.Open();
                Console.WriteLine(portsNames[0]);
                Console.WriteLine("serialPort is opened.");
            }
            //启动数据发送定时器
            dataSendTimer.Start();
        }



        public delegate void FreshUIDisplay();
        public void DisplayToUI()
        {
            //更新UI状态
            //更新保险开关状态
            this.safeStatePitureBox.Image = GlobalVars.safeState ? Properties.Resources.SafetyOn : Properties.Resources.SafetyOff;
            //更新装填指示状态
            switch (GlobalVars.ammoLoadState)
            {
                case GlobalVars.AMMOLOAD_LOADED:
                    this.ammoLoadPictureBox.Image = Properties.Resources.AmmoLoadedReady;
                    break;

                case GlobalVars.AMMOLOAD_NOT_LOADED:
                    this.ammoLoadPictureBox.Image = Properties.Resources.AmmoLoadedNotLoaded;
                    break;

                case GlobalVars.AMMOLOAD_OPEN:
                    this.ammoLoadPictureBox.Image = Properties.Resources.AmmoLoadedOpen;
                    break;

                default:
                    break;
            }
            //更新剩余弹量文本框
            this.ammoLeftTextBox.Text = GlobalVars.ammoLeftNum.ToString();
            //更新俯仰角度显示值            
            this.pitchAngleValueLabel.Text = Convert.ToString(GlobalVars.pitchAngleWithMil) + "mil";
            //更新仪表盘角度显示值
            this.dialPlateValueLabel.Text = Convert.ToString(GlobalVars.dialPlateAngleWithDegree) + "°";
            //更新仪表盘指针图像
            this.dialPlatePictureBox.Invalidate();
            //更新俯仰角指针图像
            this.pitchAngleRulerPictureBox.Invalidate();
        }


        VideoCapture camCapter = null;
        Mat frame = new Mat();
        //private string videoPath = "rtsp://admin:abcd1234@178.178.1.131:554/mpeg4/ch33/main/av_stream";
        private void PlayVideo()
        {
            string videoPath = GlobalVars.cameraRTSPPath;
            Console.WriteLine(videoPath);
            camCapter = new VideoCapture(videoPath);
            camCapter.ImageGrabbed += Cam_ImageGrabbed;
            camCapter.Start();
        }
        /// <summary>
        /// Emgcv捕捉视频流每一帧显示在窗口上
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //将捕捉到的视频帧显示到ImageBox上
        private void Cam_ImageGrabbed(object sender, EventArgs e)
        {
            try
            {
                camCapter.Retrieve(frame);
                if (camCapter != null)
                {
                    if (!camCapter.Retrieve(frame))
                    {
                        frame.Dispose();
                        return;
                    }
                    if (frame.IsEmpty) return;
                    //Image<Bgr, Byte> image = frame.ToImage<Bgr,Byte>();
                    this.cameraViewImageBox.Image = frame;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Cam_ImageGrabbed exception");
                throw;
            }
        }


        /// <summary>
        /// 串口接收数据的处理过程
        /// </summary>
        //刷新界面显示的委托
        FreshUIDisplay flushAllUI = null;

        //接收字节的缓存队列
        private List<byte> buffer = new List<byte>(4096);
        //串口接收数据以后的委托方法
        private void SerialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口未打开！", "error");
            }
            else //端口打开
            {
                try
                {
                    Byte[] receivedData = new Byte[serialPort.BytesToRead];//暂存串口取出的字节
                    serialPort.Read(receivedData, 0, receivedData.Length);//读取字节数据
                    serialPort.DiscardInBuffer();
                    //缓存接收到的数据
                    buffer.AddRange(receivedData);

                    while (buffer.Count >= 10)
                    {
                        Byte[] receivedBytes = new Byte[10];//暂存一次接收的一个完整数据包
                        if (buffer[0] == 0xFF)//数据帧头第一字节检测
                        {
                            if (buffer[1] == 0xC3)
                            {
                                Console.WriteLine("数据帧头正确，准备解析数据包");
                                buffer.CopyTo(0, receivedBytes, 0, 10);//取出数据
                                string strReceived = BitConverter.ToString(receivedBytes);
                                Console.WriteLine(strReceived);
                                bool checkSumIsRight = CalculateChecksumForReceivedData(receivedBytes);
                                if (!checkSumIsRight)//校验不正确
                                {
                                    buffer.RemoveRange(0, 10);
                                    Console.WriteLine("数据包校验和出错！丢弃10个字节");
                                    continue;
                                }
                                else
                                {
                                    buffer.RemoveRange(0, 10);
                                    //解析数据并更新界面控件显示参数
                                    byte byte3 = receivedBytes[2];
                                    GlobalVars.safeState = (byte3 & 0x20) == 32 ? true : false;
                                    switch (byte3 & 0x07)
                                    {
                                        case 4:
                                            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_LOADED;
                                            break;
                                        case 2:
                                            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_OPEN;
                                            break;
                                        case 1:
                                            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_NOT_LOADED;
                                            break;

                                        default:
                                            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_NOT_LOADED;
                                            break;
                                    }
                                    byte[] bytes45 = new byte[2] { receivedBytes[3], receivedBytes[4] };
                                    GlobalVars.dialPlateAngleWithMil = BitConverter.ToInt16(receivedBytes, 3);
                                    Console.WriteLine(GlobalVars.dialPlateAngleWithMil);
                                    GlobalVars.dialPlateAngleWithDegree = (int)((GlobalVars.dialPlateAngleWithMil / 6000.0) * 360);
                                    Console.WriteLine(GlobalVars.dialPlateAngleWithDegree);
                                    GlobalVars.pitchAngleWithMil = BitConverter.ToInt16(receivedBytes, 5);
                                    GlobalVars.pitchAngleWithDegree = (int)((GlobalVars.pitchAngleWithMil + 166.7) / 1166.7 * 70 - 10);
                                    GlobalVars.projectileCount = receivedBytes[7];
                                    GlobalVars.ammoLeftNum = GlobalVars.ammoLoadNum - GlobalVars.projectileCount;
                                    GlobalVars.focalDistanceMultiple = receivedBytes[8];

                                    //调用委托更新UI界面显示                                    
                                    this.Invoke(flushAllUI);
                                }
                            }
                            else
                            {
                                buffer.RemoveAt(0);
                                buffer.RemoveAt(1);
                                Console.WriteLine("数据帧头第一字节正确而第二字节不正确，丢弃前两字节");
                                continue;
                            }
                        }
                        else
                        {//帧头第一字节不正确时
                            buffer.RemoveAt(0);
                            Console.WriteLine("数据帧头第一字节不正确，丢弃");
                            continue;
                        }
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("串口接收数据处理函数SerialPort_DataReceived出现异常");
                    throw;
                }
            }
        }

        //接收数据的校验函数
        private bool CalculateChecksumForReceivedData(byte[] receivedBytes)
        {
            short checksum = 0;
            for (int i = 2; i < 9; i++)
            {
                checksum += receivedBytes[i];
            }
            byte checksumL = (byte)(checksum >> 8);//取低字节
            checksumL = (byte)(checksumL & 0x7f);//取低字节的低七位
            if (checksumL == receivedBytes[9])
            {
                return true;
            }
            //测试！全返回ture
            return true;
        }
        //为准备好的待发送数据计算校验和字节
        private byte CalculateChecksumForDataToSend(byte[] data)
        {
            short checksum = 0;
            for (int i = 2; i < 7; i++)
            {
                checksum += data[i];
            }
            byte checksumL = (byte)(checksum >> 8);//取低字节
            checksumL = (byte)(checksumL & 0x7f);//取低字节的低七位
            return checksumL;
        }



        /// <summary>
        /// 定时用串口发送数据
        /// </summary>
        Byte[] dataToSend = new Byte[8];
        private void DataSendTimer_Tick(object sender, EventArgs e)
        {
            dataToSend[0] = 0xff;
            dataToSend[1] = 0x81;
            //伺服开关
            if (GlobalVars.servoControlSwitchState)
            {
                dataToSend[2] = 0xAA;
            }
            else
            {
                dataToSend[2] = 0x55;              
            }
            //激光开关
            if (GlobalVars.laserControlSwitchState)
            {
                dataToSend[3] = 0xAA;
            }
            else
            {
                dataToSend[3] = 0x55;           
            }
            //射弹计数清零
            if (GlobalVars.projectileCountClear)
            {
                dataToSend[4] = 0xAA;
                GlobalVars.projectileCountClear = false;
            }
            else
            {
                dataToSend[4] = 0x55;
            }
            //方位清零
            if (GlobalVars.dialPlateAngleClear)
            {
                dataToSend[5] = 0xAA;
                GlobalVars.dialPlateAngleClear = false;
            }
            else
            {
                dataToSend[5] = 0x55;
            }
            //俯仰清零
            if (GlobalVars.pitchAngleClear)
            {
                dataToSend[6] = 0xAA;
                GlobalVars.pitchAngleClear = false;
            }
            else
            {
                dataToSend[6] = 0x55;
            }
            //校验和
            byte checksum = CalculateChecksumForDataToSend(dataToSend);
            dataToSend[7] = checksum;
            //发送数据
            serialPort.Write(dataToSend, 0, 8);
        }

        private void ServoControlSwitchButton_Click(object sender, EventArgs e)
        {
            GlobalVars.servoControlSwitchState = !GlobalVars.servoControlSwitchState;
        }

        private void LaserControlSwitchButton_Click(object sender, EventArgs e)
        {
            GlobalVars.laserControlSwitchState = !GlobalVars.laserControlSwitchState;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.camCapter.Stop();
        }

        private void ParameterConfigButton_Click(object sender, EventArgs e)
        {
            AimingReticleConfigForm aimingReticleConfigForm = new AimingReticleConfigForm();
            aimingReticleConfigForm.ShowDialog();
        }

        private void AmmoLeftSetButton_Click(object sender, EventArgs e)
        {
            AmmoLoadConfigForm ammoLoadConfigForm = new AmmoLoadConfigForm();
            //ammoLoadConfigForm.IsMdiContainer
            ammoLoadConfigForm.MdiParent = this;
            ammoLoadConfigForm.Parent = this.cameraViewImageBox;
            ammoLoadConfigForm.TopMost = true;
            ammoLoadConfigForm.Show();

            //更新设置后的参数
            if (ammoLoadConfigForm.DialogResult==DialogResult.OK)
            {
                GlobalVars.ammoLeftNum = GlobalVars.ammoLoadNum - GlobalVars.projectileCount;
                Console.WriteLine(GlobalVars.ammoLeftNum);
                this.ammoLeftTextBox.Text = GlobalVars.ammoLeftNum.ToString();
            }
        }

        //俯仰角度标尺的指针
        private Image pitchAnglePointerImg = Properties.Resources.pitchAnglePointer;
        //方位角度表盘的指针
        private Image dialPlatePointerImg = Properties.Resources.dialPointer;

        /// <summary>
        /// 为俯仰角度标尺上画对应角度的指针
        /// </summary>
        /// <param name="gp"></param>
        private void DrawPitchAnglePointerImg(Graphics gp)
        {
            Bitmap bitmap = new Bitmap(this.pitchAngleRulerPictureBox.Width,this.pitchAngleRulerPictureBox.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //开始画俯仰角度标尺上的指针
            double temp = 166.7 + GlobalVars.pitchAngleWithMil;
            int offsetY = (int)(160 - (temp / 1166.7) * 160);
            //将指针画在bitmap上
            g.DrawImage(pitchAnglePointerImg, new Rectangle(0, offsetY-3, 25, 5));
            
            //将bitmap上的指针画在标尺的picturebox上
            gp.DrawImage(bitmap, new Point(0, 0));

            //释放资源
            g.Dispose();
            bitmap.Dispose();
        }
        private void PitchAngleRulerPictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawPitchAnglePointerImg(e.Graphics);
        }

        /// <summary>
        /// 为仪表盘画对应度数的方位角指针
        /// </summary>
        /// <param name="gp"></param>
        private void DrawDialPlatePointerImg(Graphics gp)
        {
            Bitmap bitmap = new Bitmap(this.dialPlatePictureBox.Width, this.dialPlatePictureBox.Height);
            Graphics g = Graphics.FromImage(bitmap);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            //开始画方位角表盘上的指针
            int dialPlateWidth = this.dialPlatePictureBox.Width;
            int dialPlateHeight = this.dialPlatePictureBox.Height;
            int angle = GlobalVars.dialPlateAngleWithDegree;
            //将graphics平移原点
            g.TranslateTransform(dialPlateWidth / 2, dialPlateHeight / 2);
            //将graphics旋转相应角度(绕当前原点)
            g.RotateTransform(angle);
            //将graphics恢复在水平和垂直方向上的平移（沿当前原点）
            g.TranslateTransform(-dialPlateWidth / 2, -dialPlateHeight / 2);
            g.DrawImage(dialPlatePointerImg, new Rectangle(0, dialPlateHeight / 2, dialPlateWidth / 2, 5));

            //将bitmap上的指针画在方位表盘的picturebox上
            gp.DrawImage(bitmap, new Point(0, 0));

            //释放资源
            g.Dispose();
            bitmap.Dispose();
        }
        private void DialPlatePictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawDialPlatePointerImg(e.Graphics);
        }

        private void AmmoLeftTextBox_Click(object sender, EventArgs e)
        {
            AmmoLoadConfigForm ammoLoadConfigForm = new AmmoLoadConfigForm();
            ammoLoadConfigForm.MdiParent = this;
            ammoLoadConfigForm.TopMost = true;
            ammoLoadConfigForm.Show();

            //更新设置后的参数
            if (ammoLoadConfigForm.DialogResult == DialogResult.OK)
            {
                GlobalVars.ammoLeftNum = GlobalVars.ammoLoadNum - GlobalVars.projectileCount;
                Console.WriteLine(GlobalVars.ammoLeftNum);
                this.ammoLeftTextBox.Text = GlobalVars.ammoLeftNum.ToString();
            }
        }
    }
}
