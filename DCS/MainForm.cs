using System;
using System.Windows.Forms;
using System.IO.Ports;
using Emgu.CV;
using System.Collections.Generic;
using System.Drawing;
using static DCS.AmmoLoadConfigForm;

namespace DCS
{
    public partial class MainForm : Form
    {
        //协议接收的数据包的字节大小
        public const int RECEIVE_DATA_PACKAGE_SIZE = 12;
        //协议发送的数据包的字节大小
        public const int SEND_DATA_PACKAGE_SIZE = 7;

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
            GlobalVars.serialPortName = AppConfigManager.GetValue("serialPortName");
            serialPort.PortName = GlobalVars.serialPortName;

            //GlobalVars.cameraIP = "178.178.1.131";
            //GlobalVars.cameraPort = "554";
            //GlobalVars.userName = "admin";
            //GlobalVars.userPassword = "abcd1234";
            //GlobalVars.cameraRTSPPath = "rtsp://" + GlobalVars.userName + ":" + GlobalVars.userPassword + "@" + GlobalVars.cameraIP + ":" + GlobalVars.cameraPort + "/mpeg4/ch33/main/av_stream";

            GlobalVars.servoControlSwitchState = true;//伺服使能开关默认为开
            GlobalVars.laserControlSwitchState = false;//辅助瞄准开关默认为关闭

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
                //GlobalVars.aimingReticleConfigs[i].sizePercent = 0;
                //GlobalVars.aimingReticleConfigs[i].size = 250 + (int)((GlobalVars.aimingReticleConfigs[i].sizePercent / 100.0) * 250);

                AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".posX", "515");
                AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".posY", "235");
                //AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".sizePercent", "0");
                //AppConfigManager.SetValue("aimingReticleConfig" + (i + 1) + ".size", GlobalVars.aimingReticleConfigs[i].size.ToString());
            }
            //初始化各种弹出窗口面板和事件订阅
            //实例化更新UI界面委托
            flushAllUI = new FreshUIDisplay(DisplayToUI);
            //初始化伺服使能开关面板控件（弃用）
            //.servoControlOnOffSwitchPanel.Parent = this.cameraViewImageBox;
            //this.servoControlOnOffSwitchPanel.SwitchStateChange += new OnOffSwitchPanel.SwitchStateChangeHandler(ChangeServoControlPictureBox);
            //this.servoControlOnOffSwitchPanel.Enabled = false;
            //this.servoControlOnOffSwitchPanel.Visible = false;
            //初始化辅助瞄准开关面板控件
            this.laserControlOnOffSwitchPanel.Parent = this.cameraViewImageBox;
            this.laserControlOnOffSwitchPanel.SwitchStateChange += new OnOffSwitchPanel.SwitchStateChangeHandler(ChangeLaserControlPictureBox);
            this.laserControlOnOffSwitchPanel.Enabled = false;
            this.laserControlOnOffSwitchPanel.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Console.WriteLine(GlobalVars.cameraRTSPPath);
            //启动emgucv视频捕捉显示
            //PlayVideo();

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
                Console.WriteLine("打开的串口为：" + serialPort.PortName);
                Console.WriteLine("serialPort is opened.");
            }
            //启动数据发送定时器
            dataSendTimer.Start();
        }

        public delegate void FreshUIDisplay();
        public void DisplayToUI()
        {
            //更新UI状态
            //更新辅助瞄准指示灯状态
            this.laserControlPictureBox.Image = GlobalVars.laserControlSwitchState ? Properties.Resources.LaserOn : Properties.Resources.LaserOff;
            //更新伺服使能指示灯状态
            this.servoControlPictureBox.Image = GlobalVars.servoControlSwitchState ? Properties.Resources.ServoOn : Properties.Resources.ServoOff;
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
            if (GlobalVars.ammoLeftNum >= 100)
            {
                this.ammoLeftTextBoxBlinkTimer.Stop();
                this.ammoLeftTextBox.ForeColor = Color.LimeGreen;
            }
            else if (GlobalVars.ammoLeftNum >= 30)
            {
                this.ammoLeftTextBoxBlinkTimer.Stop();
                this.ammoLeftTextBox.ForeColor = Color.Yellow;
            }
            else if (GlobalVars.ammoLeftNum < 30)
            {
                this.ammoLeftTextBox.ForeColor = Color.Red;
                this.ammoLeftTextBoxBlinkTimer.Start();
            }
            //更新距离数值显示值
            this.distanceValueLabel.Text = Convert.ToString(GlobalVars.distanceMeter) + "m";
            //更新俯仰角度显示值和水平数值显示值            
            this.pitchAngleValueLabel.Text = Convert.ToString(GlobalVars.pitchAngleWithMil) + "mil";
            if (GlobalVars.degreeOrMil)//true表示用度数
            {
                this.pitchValueLabel.Text = Convert.ToString(GlobalVars.pitchAngleWithDegree) + "°";
                this.herizonValueLabel.Text = Convert.ToString(GlobalVars.dialPlateAngleWithDegree) + "°";
            }
            else//false表示用密位单位
            {
                this.pitchValueLabel.Text = Convert.ToString(GlobalVars.pitchAngleWithMil) + "mil";
                this.herizonValueLabel.Text = Convert.ToString(GlobalVars.dialPlateAngleWithMil) + "mil";
            }
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

                    while (buffer.Count >= RECEIVE_DATA_PACKAGE_SIZE)
                    {
                        Byte[] receivedBytes = new Byte[RECEIVE_DATA_PACKAGE_SIZE];//暂存一次接收的一个完整数据包
                        if ((buffer[0] == 0xFF) && (buffer[1] == 0xC3))//数据帧头检测是否出错
                        {
                            //if (buffer[1] == 0xC3)//数据帧头第二字节标志位检查
                            {
                                Console.WriteLine("数据帧头正确，准备解析数据包");
                                buffer.CopyTo(0, receivedBytes, 0, RECEIVE_DATA_PACKAGE_SIZE);//取出数据包
                                string strReceived = BitConverter.ToString(receivedBytes);
                                Console.WriteLine("取出的数据包原始数据为：" + strReceived);
                                bool checkSumIsRight = CalculateChecksumForReceivedData(receivedBytes);
                                if (!checkSumIsRight)//校验不正确
                                {
                                    buffer.RemoveRange(0, RECEIVE_DATA_PACKAGE_SIZE);
                                    Console.WriteLine("数据包校验和出错！丢弃整个数据包");
                                    continue;
                                }
                                else
                                {
                                    //读取完一个包，删除缓存中这个包数据
                                    buffer.RemoveRange(0, RECEIVE_DATA_PACKAGE_SIZE);
                                    //解析数据并更新界面控件显示参数
                                    //第三字节，控制各种指示灯
                                    byte byte3 = receivedBytes[2];

                                    //辅助瞄准Bit7、Bit6：00灰色，11绿色
                                    if ((byte3 & 192) == 192) GlobalVars.laserControlSwitchState = true;
                                    else if ((byte3 & 192) == 0) GlobalVars.laserControlSwitchState = false;
                                    else
                                    {
                                        Console.WriteLine("辅助瞄准指示位出错");
                                    }

                                    //伺服使能Bit5、Bit4：00红色，11绿色
                                    if ((byte3 & 48) == 48) GlobalVars.servoControlSwitchState = true;
                                    else if ((byte3 & 48) == 0) GlobalVars.servoControlSwitchState = false;
                                    else
                                    {
                                        Console.WriteLine("伺服使能指示位出错");
                                    }

                                    //射击保险Bit3、Bit2：00红，11绿
                                    if ((byte3 & 12) == 12) GlobalVars.safeState = true;
                                    else if ((byte3 & 12) == 0) GlobalVars.safeState = false;
                                    else
                                    {
                                        Console.WriteLine("射击保险指示位出错");
                                    }

                                    //装填状态Bit1、Bit0：00红/红，10绿/红，11绿/绿
                                    switch (byte3 & 3)
                                    {
                                        case 3:
                                            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_LOADED;
                                            break;
                                        case 2:
                                            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_OPEN;
                                            break;
                                        case 0:
                                            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_NOT_LOADED;
                                            break;

                                        default:
                                            Console.WriteLine("装填状态指示位出错");
                                            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_NOT_LOADED;
                                            break;
                                    }
                                    //通信协议中的Byte4与Byte5：方位位置值L和方位位置值H
                                    byte[] bytes45 = new byte[2] { receivedBytes[3], receivedBytes[4] };

                                    //将Byte4与Byte5转为方位位置数值(同时记录mil值和对应的degree值)
                                    GlobalVars.dialPlateAngleWithMil = BitConverter.ToUInt16(receivedBytes, 3)/10.0;
                                    Console.WriteLine("方位位置值mil:" + GlobalVars.dialPlateAngleWithMil);
                                    GlobalVars.dialPlateAngleWithDegree = (GlobalVars.dialPlateAngleWithMil / 6000.0) * 360.0;
                                    Console.WriteLine("方位位置值degree：" + GlobalVars.dialPlateAngleWithDegree);

                                    //将Byte6与Byte7转为俯仰位置值的数值(同时记录mil值和对应的degree值)
                                    GlobalVars.pitchAngleWithMil = (BitConverter.ToUInt16(receivedBytes, 5) - 32768)/10.0;
                                    GlobalVars.pitchAngleWithDegree = ((GlobalVars.pitchAngleWithMil + 166.7) / 1166.7 * 70.0 - 10);
                                    Console.WriteLine("俯仰位置值mil：" + GlobalVars.pitchAngleWithMil);
                                    Console.WriteLine("俯仰位置值degree：" + GlobalVars.pitchAngleWithDegree);

                                    //将Byte8转为射弹计数，同时计算剩余弹量
                                    GlobalVars.projectileCount = receivedBytes[7];
                                    GlobalVars.ammoLeftNum = GlobalVars.ammoLoadNum - GlobalVars.projectileCount;
                                    Console.WriteLine("射弹计数：" + GlobalVars.projectileCount);

                                    //将Byte9转为当前焦距状态
                                    GlobalVars.focalDistanceMultiple = receivedBytes[8];
                                    Console.WriteLine("当前焦距状态：" + GlobalVars.focalDistanceMultiple);

                                    //将Byte10与Byte11转为距离数值
                                    GlobalVars.distanceMeter = BitConverter.ToUInt16(receivedBytes, 9)/10.0;
                                    Console.WriteLine("距离数值(米)：" + GlobalVars.distanceMeter);

                                    //调用委托更新UI界面显示                                    
                                    this.Invoke(flushAllUI);
                                }
                            }
                            //else
                            //{//数据包帧头第一字节正确而第二字节不正确
                            //    buffer.RemoveAt(0);
                            //    buffer.RemoveAt(1);
                            //    Console.WriteLine("数据帧头第一字节正确而第二字节不正确，丢弃前两字节");
                            //    continue;
                            //}
                        }
                        else
                        {//帧头不正确时
                            buffer.RemoveAt(0);
                            //buffer.RemoveRange(0, 2);
                            Console.WriteLine("数据帧头字节不正确，丢弃一个字节");
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
            for (int i = 2; i < 11; i++)
            {
                checksum += receivedBytes[i];
            }
            //byte checksumL = checksum & ;//取低字节
            byte checksumL = (byte)(checksum & 0x7f);//取低字节的低七位
            Console.WriteLine("校验和：" + checksumL);
            Console.WriteLine("收到校验和：" + receivedBytes[11]);
            if (checksumL == receivedBytes[11])
            {
                return true;
            }
            //测试！全返回ture
            return false;
        }
        //为准备好的待发送数据计算校验和字节
        private byte CalculateChecksumForDataToSend(byte[] data)
        {
            short checksum = 0;
            for (int i = 2; i < 6; i++)
            {
                checksum += data[i];
            }
            //byte checksumL = (byte)(checksum >> 8);//取低字节
            byte checksumL = (byte)(checksum & 0x7f);//取低字节的低七位
            return checksumL;
        }

        /// <summary>
        /// 定时用串口发送数据触发方法
        /// </summary>
        Byte[] dataToSend = new Byte[SEND_DATA_PACKAGE_SIZE];
        private void DataSendTimer_Tick(object sender, EventArgs e)
        {
            dataToSend[0] = 0xff;
            dataToSend[1] = 0x81;

            //Byte3-射弹计数清零
            if (GlobalVars.projectileCountClear)
            {
                dataToSend[2] = 0xAA;
                GlobalVars.projectileCountClear = false;//开关状态恢复
            }
            else
            {
                dataToSend[2] = 0x55;
            }

            //Byte4-方位零位设置
            if (GlobalVars.dialPlateAngleClear)
            {
                dataToSend[3] = 0xAA;
                GlobalVars.dialPlateAngleClear = false;//开关状态恢复
            }
            else
            {
                dataToSend[3] = 0x55;
            }

            //Byte5-俯仰零位设置
            if (GlobalVars.pitchAngleClear)
            {
                dataToSend[4] = 0xAA;
                GlobalVars.pitchAngleClear = false;
            }
            else
            {
                dataToSend[4] = 0x55;
            }

            //Byte6-辅助瞄准开关
            if (GlobalVars.laserControlSwitchState)
            {
                dataToSend[5] = 0xAA;
                GlobalVars.laserControlSwitchState = false;
            }
            else
            {
                dataToSend[5] = 0x55;
            }

            //伺服开关
            //if (GlobalVars.servoControlSwitchState)
            //{
            //    dataToSend[2] = 0xAA;
            //}
            //else
            //{
            //    dataToSend[2] = 0x55;              
            //}

            //校验和
            byte checksum = CalculateChecksumForDataToSend(dataToSend);
            dataToSend[6] = checksum;
            //发送数据
            //Console.WriteLine(BitConverter.ToString(dataToSend));
            serialPort.Write(dataToSend, 0, SEND_DATA_PACKAGE_SIZE);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.camCapter.Stop();
        }

        private void ParameterConfigButton_Click(object sender, EventArgs e)
        {
            AimingReticleConfigForm0 aimingReticleConfigForm = new AimingReticleConfigForm0();
            aimingReticleConfigForm.ShowDialog();
        }

        //俯仰角度标尺的指针
        private Image pitchAnglePointerImg = Properties.Resources.pitchAnglePointer;
        //方位角度表盘的指针
        private Image dialPlatePointerImg = Properties.Resources.dialPointer;

        private void PitchAngleRulerPictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawPitchAnglePointerImg(e.Graphics);
        }
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


        private void DialPlatePictureBox_Paint(object sender, PaintEventArgs e)
        {
            DrawDialPlatePointerImg(e.Graphics);
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
            int angle = (int)(GlobalVars.dialPlateAngleWithDegree);
            //将graphics平移原点
            g.TranslateTransform(dialPlateWidth / 2, dialPlateHeight / 2);
            //将graphics旋转相应角度(绕当前原点)
            g.RotateTransform(angle + 90);
            //将graphics恢复在水平和垂直方向上的平移（沿当前原点）
            g.TranslateTransform(-dialPlateWidth / 2, -dialPlateHeight / 2);
            g.DrawImage(dialPlatePointerImg, new Rectangle(0, dialPlateHeight / 2, dialPlateWidth / 2, 5));

            //将bitmap上的指针画在方位表盘的picturebox上
            gp.DrawImage(bitmap, new Point(0, 0));

            //释放资源
            g.Dispose();
            bitmap.Dispose();
        }

        private AmmoLoadConfigForm ammoLoadConfigForm = null;
        /// <summary>
        /// 弹药剩余量文本显示框点击事件函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AmmoLeftTextBox_Click(object sender, EventArgs e)
        {
            if (ammoLoadConfigForm == null || ammoLoadConfigForm.IsDisposed)
            {
                ammoLoadConfigForm = new AmmoLoadConfigForm
                {
                    MdiParent = this,
                    Parent = this.cameraViewImageBox,
                    TopMost = true
                };
                ammoLoadConfigForm.ChangeProjectileCount += new ChangeProjectileCountHandler(ChangeAmmoLeftTextBox);
                ammoLoadConfigForm.Show();
            }
        }
        /// <summary>
        /// 修改弹药剩余量文本框显示数值
        /// </summary>
        /// <param name="num"></param>
        public void ChangeAmmoLeftTextBox(int num)
        {
            if (num >= 100)
            {
                this.ammoLeftTextBoxBlinkTimer.Stop();
                this.ammoLeftTextBox.ForeColor = Color.LimeGreen;
            }
            else if (num >= 30)
            {
                this.ammoLeftTextBoxBlinkTimer.Stop();
                this.ammoLeftTextBox.ForeColor = Color.Yellow;
            }
            else if (num < 30)
            {
                this.ammoLeftTextBox.ForeColor = Color.Red;
                this.ammoLeftTextBoxBlinkTimer.Start();
            }
            this.ammoLeftTextBox.Text = num.ToString();
        }
        /// <summary>
        /// 弹药剩余量文本显示框闪动timer的tick函数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AmmoLeftTextBoxBlinkTimer_Tick(object sender, EventArgs e)
        {
            if (this.ammoLeftTextBox.ForeColor == Color.Black)
            {
                this.ammoLeftTextBox.ForeColor = Color.Red;
            }
            else if (this.ammoLeftTextBox.ForeColor == Color.Red)
            {
                this.ammoLeftTextBox.ForeColor = Color.Black;
            }
        }

        //private void ServoControlPictureBox_Click(object sender, EventArgs e)
        //{
            //this.servoControlOnOffSwitchPanel.Enabled = true;
            //this.servoControlOnOffSwitchPanel.BringToFront();          
            //this.servoControlOnOffSwitchPanel.Show();
        //}

        /// <summary>
        /// 修改伺服使能状态指示灯
        /// </summary>
        /// <param name="state"></param>
        public void ChangeServoControlPictureBox(bool state)
        {
            if (state)
            {
                this.servoControlPictureBox.Image = Properties.Resources.SafetyOn;
            }
            else
            {
                this.servoControlPictureBox.Image = Properties.Resources.SafetyOff;
            }
        }

        private void LaserControlPictureBox_Click(object sender, EventArgs e)
        {
            this.laserControlOnOffSwitchPanel.Enabled = true;
            this.laserControlOnOffSwitchPanel.BringToFront();
            this.laserControlOnOffSwitchPanel.Show();
        }
        /// <summary>
        /// 修改辅助瞄准状态指示灯
        /// </summary>
        /// <param name="state"></param>
        public void ChangeLaserControlPictureBox(bool state)
        {
            if (state)
            {
                this.laserControlPictureBox.Image = Properties.Resources.LaserOn;
            }
            else
            {
                this.laserControlPictureBox.Image = Properties.Resources.LaserOff;
            }
        }

        AimingReticleConfigForm aimingReticleConfigForm = null;
        private void ParameterConfigLabel_Click(object sender, EventArgs e)
        {
            if (aimingReticleConfigForm == null || aimingReticleConfigForm.IsDisposed)
            {
                aimingReticleConfigForm = new AimingReticleConfigForm
                {
                    MdiParent = this,
                    Parent = this.cameraViewImageBox,
                    TopMost = true
                };
                aimingReticleConfigForm.AimingReticlePositionChange += new AimingReticleConfigForm.AimingReticlePositionChangeHandler(MoveAimingReticlePictureBox);
                aimingReticleConfigForm.Show();
            }
        }
        /// <summary>
        /// 移动瞄准分划位置
        /// </summary>
        /// <param name="pos"></param>
        public void MoveAimingReticlePictureBox(Point pos)
        {
            this.aimingReticlePictureBox.Location = pos;
            this.aimingReticlePictureBox.Refresh();
        }
    }
}
