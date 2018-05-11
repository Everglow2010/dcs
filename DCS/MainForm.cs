using System;
using System.Windows.Forms;
using System.IO.Ports;
using Emgu.CV;
using System.Collections.Generic;

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
            GlobalVars.cameraIP = "178.178.1.131";
            GlobalVars.cameraPort = "554";
            GlobalVars.userName = "admin";
            GlobalVars.userPassword = "abcd1234";
            GlobalVars.cameraRTSPPath = "rtsp://" + GlobalVars.userName + ":" + GlobalVars.userPassword + "@" + GlobalVars.cameraIP + ":" + GlobalVars.cameraPort + "/mpeg4/ch33/main/av_stream";

            GlobalVars.servoControlSwitchState = true;//伺服使能开关默认为开
            GlobalVars.laserControlSwitchState = false;//激光控制开关默认为关闭

            GlobalVars.ammoLoadNum = 200;
            GlobalVars.ammoLeftNum = 200;
            GlobalVars.projectileCountClear = false;

            GlobalVars.ammoLoadState = GlobalVars.AMMOLOAD_NOT_LOADED;
            GlobalVars.safeState = true;

            GlobalVars.pitchAngle = 0;
            GlobalVars.pitchAngleClear = false;

            GlobalVars.dialPlateAngle = 0;
            GlobalVars.dialPlateAngleClear = false;

            //初始化20个焦距档位对应的瞄准分划大小和位置
            for (int i = 0; i < 20; i++)
            {

            }
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
                    this.cameraViewImageBox.Image = frame;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Cam_ImageGrabbed exception");
            }
        }

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
                                    GlobalVars.dialPlateAngle = BitConverter.ToInt16(receivedBytes, 3);
                                    GlobalVars.pitchAngle = BitConverter.ToInt16(receivedBytes, 5);
                                    GlobalVars.projectileCount = receivedBytes[7];
                                    GlobalVars.ammoLeftNum = GlobalVars.ammoLoadNum - GlobalVars.projectileCount;
                                    GlobalVars.focalDistanceMultiple = receivedBytes[8];

                                    //更新UI状态
                                    写到委托里！
                                    this.safeStatePitureBox.Image = GlobalVars.safeState ? Properties.Resources.safetyOn : Properties.Resources.safetyOff;
                                    switch (GlobalVars.ammoLoadState)
                                    {
                                        case GlobalVars.AMMOLOAD_LOADED:
                                            this.ammoLoadPictureBox.Image = Properties.Resources.ammoLoaded;
                                            break;

                                        case GlobalVars.AMMOLOAD_NOT_LOADED:
                                            this.ammoLoadPictureBox.Image = Properties.Resources.ammoNotLoaded;
                                            break;

                                        case GlobalVars.AMMOLOAD_OPEN:
                                            this.ammoLoadPictureBox.Image = Properties.Resources.ammoOpen;
                                            break;

                                        default:
                                            break;          
                                    }
                                    //this.ammoLeftTextBox.Text = GlobalVars.ammoLeftNum.ToString();

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
            ammoLoadConfigForm.ShowDialog();
        }
    }
}
