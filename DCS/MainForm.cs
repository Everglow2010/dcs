using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO.Ports;

namespace DCS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //this.dialPlatePictureBox.Parent = this.cameraViewPicturebox;
            //this.dialPlatePictureBox.BackColor = Color.Transparent;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
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
    }
}
