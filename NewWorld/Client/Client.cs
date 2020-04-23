using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//추가 내용
using System.Net.Sockets;
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;

namespace Client
{
    public partial class Client : Form
    {
        //
        private TcpClient client = new TcpClient();
        private NetworkStream mainStream;
        private int portNumber = 9999;


        //화면 캡쳐 함수
        private static Image GrabDesktop()
        {
            Rectangle bound = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bound.Width, bound.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(bound.X, bound.Y,0,0,bound.Size,CopyPixelOperation.SourceCopy);

            return screenshot;
        }
        private void SendDesktopImage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            mainStream = client.GetStream();
            binFormatter.Serialize(mainStream, GrabDesktop());
        }


        public Client()
        {
            InitializeComponent();
        }

        private void Client_Load(object sender, EventArgs e)
        {
            btnScreen.Enabled = false;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(txtServIP.Text, portNumber);
                btnConnect.Text = "Connected";
                MessageBox.Show("Connected");
                btnConnect.Enabled = false;
                btnScreen.Enabled = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Failed to connect");
                btnConnect.Text = "Not Connected";
            }
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            if(btnScreen.Text.StartsWith("Share"))
            {
                timer1.Start();
                btnScreen.Text = "Stop sharing";
            }
            else
            {
                timer1.Stop();
                btnScreen.Text = "Share My Screen";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SendDesktopImage();
        }
    }
}
