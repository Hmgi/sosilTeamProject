using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketLibrary;

using System.Runtime.InteropServices;

namespace MainProgram.Forms
{
    public partial class FormScreen : Form
    {
        [DllImport("gdi32.dll")] private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);
        [DllImport("user32.dll")] private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);


        public NetworkStream mainStream;
        public TcpClient client;
        private bool s_ClientOn = false;

        public Thread GetImage;

        private byte[] sendBuffer = new byte[10000000];
        private byte[] readBuffer = new byte[10000000];

        public FormScreen()
        {
            client = new TcpClient();
            client.Connect("127.0.0.1", 9999);
            mainStream = client.GetStream();

            InitializeComponent();

            IntPtr ip = CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 15, 15);
            int i = SetWindowRgn(pictureBox1.Handle, ip, true);

            IntPtr ipp = CreateRoundRectRgn(0, 0, btnScreenStart.Width, btnScreenStart.Height, 15, 15);
            int i1 = SetWindowRgn(btnScreenStart.Handle, ipp, true);

            //IntPtr ip2 = CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 15, 15); int i2 = SetWindowRgn(textBox1.Handle, ip2, true); this.Refresh();

            IntPtr ippap = CreateRoundRectRgn(0, 0, btnScreenStop.Width, btnScreenStop.Height, 15, 15);
            int i2 = SetWindowRgn(btnScreenStop.Handle, ippap, true);

            this.Refresh();
        }

        public void Run()
        {
            sendScreen sc = new sendScreen();
            sc.Type = (int)PacketType.Screen_start;
            sendScreen.Serialize(sc).CopyTo(this.sendBuffer, 0);
            this.Send();

            s_ClientOn = true;
            int nRead;
            while (s_ClientOn)
            {
                try
                {
                    nRead = 0;
                    nRead = this.mainStream.Read(readBuffer, 0, 10000000);
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
                            sendScreen p = (sendScreen)sendScreen.Deserialize(this.readBuffer);
                            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                            pictureBox1.Image = ByteArrayToImage(p.arr);
                            break;
                        }
                    case (int)PacketType.Screen_stop:
                        {
                            
                            break;
                        }
                }
            }
        }

        private void btnScreenStart_Click(object sender, EventArgs e)
        {
            this.GetImage = new Thread(new ThreadStart(Run));
            this.GetImage.Start();
        }

        private void btnScreenStop_Click(object sender, EventArgs e) // 스크린샷 저장
        {
            string path = System.Environment.CurrentDirectory + "\\ScreenShot.png";
            pictureBox1.Image.Save(path, System.Drawing.Imaging.ImageFormat.Png);
        }

        public void Send()
        {
            mainStream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            mainStream.Flush();
            for (int i = 0; i < 1024 * 100; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }

        public Image ByteArrayToImage(byte[] bytes) // 배열을 이미지로 변환
        {
            MemoryStream ms = new MemoryStream(bytes);
            Image img = Image.FromStream(ms);
            return img;
        }
    }
}
