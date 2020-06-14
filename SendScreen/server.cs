using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Imaging;
using PacketLibrary;

namespace Server
{
    public partial class server : Form
    {
        private TcpListener s_listener9001;
        private TcpListener s_listener9002;
        private TcpListener s_listener9003;

        private TcpClient client9001;
        private TcpClient client9002;
        private TcpClient client9003;

        private NetworkStream mainStream9001;
        private NetworkStream mainStream9002;
        private NetworkStream mainStream9003;

        private bool ClientOn_9001 = false;
        private bool ClientOn_9002 = false;
        private bool ClientOn_9003 = false;

        private Thread s_thread9001;
        private Thread s_thread9002;
        private Thread s_thread9003;

        private byte[] sendBuffer = new byte[1024 * 1024];
        private byte[] readBuffer = new byte[1024 * 1024];


        public server()
        {
            InitializeComponent();
        }

        public void RunServer1()
        {
            this.s_listener9001 = new TcpListener(9001);
            this.s_listener9001.Start();
            client9001 = this.s_listener9001.AcceptTcpClient();
            
            if (client9001.Connected)
            {
                this.ClientOn_9001 = true;
                mainStream9001 = client9001.GetStream();
                MessageBox.Show("connect 9001 port");
            }
            /*int nRead;
            while (this.s_ClientOn)
            {
                try
                {
                    nRead = 0;
                    nRead = this.mainStream.Read(readBuffer, 0, 1024 * 100);
                }
                catch
                {
                    this.s_ClientOn = false;
                    this.mainStream = null;
                }

                Packet packet = (Packet)Packet.Deserialize(this.readBuffer);

                switch ((int)packet.Type)
                {
                    case (int)PacketType.Init:

                        break;

                    case (int)PacketType.Screen_start:
                        {
                            timer1.Start();
                            break;
                        }

                    case (int)PacketType.Screen_stop:
                        {
                            timer1.Stop();
                            break;
                        }
                }
            }*/
        }

        public void RunServer2()
        {
            this.s_listener9002 = new TcpListener(9002);
            this.s_listener9002.Start();
            client9002 = this.s_listener9002.AcceptTcpClient();

            if (client9002.Connected)
            {
                this.ClientOn_9002 = true;
                mainStream9002 = client9002.GetStream();
                MessageBox.Show("connect 9002 port");
                while(true)
                {
                    SendDesktopImage();
                }
            }
        }

        public void RunServer3()
        {
            this.s_listener9003 = new TcpListener(9003);
            this.s_listener9003.Start();
            client9003 = this.s_listener9003.AcceptTcpClient();

            if (client9003.Connected)
            {
                this.ClientOn_9003 = true;
                mainStream9003 = client9003.GetStream();
            }
        }

        private void server_Load(object sender, EventArgs e)
        {
            s_thread9001 = new Thread(new ThreadStart(RunServer1));
            s_thread9001.Start();
            s_thread9002 = new Thread(new ThreadStart(RunServer2));
            s_thread9002.Start();
            s_thread9003 = new Thread(new ThreadStart(RunServer3));
            s_thread9003.Start();
        }

        private static Image GrabDesktop()
        {
            Rectangle bound = Screen.PrimaryScreen.Bounds;
            Bitmap screenshot = new Bitmap(bound.Width, bound.Height, PixelFormat.Format32bppArgb);
            Graphics graphics = Graphics.FromImage(screenshot);
            graphics.CopyFromScreen(bound.X, bound.Y, 0, 0, bound.Size, CopyPixelOperation.SourceCopy);

            return screenshot;
        }

        private void SendDesktopImage()
        {
            BinaryFormatter bf = new BinaryFormatter();
            mainStream9002 = client9002.GetStream();
            bf.Serialize(mainStream9002, GrabDesktop());
        }


        public void Send()
        {
            mainStream9002.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            mainStream9002.Flush();
            for (int i = 0; i < 1024 * 100; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }
    }
}
