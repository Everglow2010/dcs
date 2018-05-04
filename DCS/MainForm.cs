using System;
using System.Windows.Forms;
using System.IO.Ports;

namespace DCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
                Console.WriteLine(portsNames[1]);
                Console.WriteLine("serialPort is opened.");
            }
        }

        //VideoCapture camCapter = null;
        //Mat frame;
        //System.Windows.Forms.Timer PlayerTimer = new Timer();
        //string videoPath = "F:\\bgVideo.mp4";

        //private void PlayVideo()
        //{
        //    camCapter = new VideoCapture(videoPath);
        //    camCapter.SetCaptureProperty(Emgu.CV.CvEnum.CapProp.PosFrames, 2241);
        //    var tmp = (camCapter.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps) > 0) ? (camCapter.GetCaptureProperty(Emgu.CV.CvEnum.CapProp.Fps)) : 24;//获取视频帧率，如无法获取就默认24帧
        //    int delay = (int)(1000 / tmp);
        //    PlayerTimer.Interval = delay;
        //    PlayerTimer.Tick += VideoController;
        //    PlayerTimer.Start();
        //}

        //private void VideoController(object sender, EventArgs e)
        //{
        //    if (camCapter == null) { return; }
        //    if (frame != null) { frame.Dispose(); }
        //    frame = camCapter.QueryFrame();
        //    if (frame == null)
        //    {
        //        Console.WriteLine("Video End");
        //        camCapter = new VideoCapture(videoPath);
        //        //PlayerTimer.Stop();
        //        return;
        //    }
        //    this.cameraImageBox.Image = frame;
        //}

        private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("串口未打开！", "error");

            }
            else //端口打开
            {
                try
                {
                    Byte[] receivedData = new Byte[serialPort.BytesToRead];
                    serialPort.Read(receivedData, 0, receivedData.Length);//读取字节数据
                    serialPort.DiscardInBuffer();
                    //Console.WriteLine(Convert.ToString(receivedData));
                    string strReceived = "";
                    strReceived += System.Text.Encoding.ASCII.GetString(receivedData);
                    Console.WriteLine(strReceived);
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }

        //private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    this.PlayerTimer.Stop();
        //}

        private void parameterConfigButton_Click(object sender, EventArgs e)
        {
        }
    }
}
