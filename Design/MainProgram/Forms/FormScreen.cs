using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using PacketLibrary;


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

        public Thread GetImage;

        private byte[] sendBuffer = new byte[1024 * 100];
        private byte[] readBuffer = new byte[1024 * 100];

        public FormScreen()
        {
            client = new TcpClient();
            client.Connect("127.0.0.1", 9002);
            mainStream = client.GetStream();

            GetImage = new Thread(Receiveimage);
            InitializeComponent();

            

            IntPtr ip = CreateRoundRectRgn(0, 0, pictureBox1.Width, pictureBox1.Height, 15, 15);
            int i = SetWindowRgn(pictureBox1.Handle, ip, true);

            IntPtr ipp = CreateRoundRectRgn(0, 0, btnScreenStart.Width, btnScreenStart.Height, 15, 15);
            int i1 = SetWindowRgn(btnScreenStart.Handle, ipp, true);

            //IntPtr ip2 = CreateRoundRectRgn(0, 0, textBox1.Width, textBox1.Height, 15, 15); int i2 = SetWindowRgn(textBox1.Handle, ip2, true); this.Refresh();

            IntPtr ippap = CreateRoundRectRgn(0, 0, btnScreenStop.Width, btnScreenStop.Height, 15, 15);
            int i2 = SetWindowRgn(btnScreenStop.Handle, ippap, true);


        }

        private void btnScreenStart_Click(object sender, EventArgs e)
        {

        }

        private void btnScreenStop_Click(object sender, EventArgs e)
        {
           
        }

        private void Receiveimage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            while (client.Connected)
            {
                mainStream = client.GetStream();
                pictureBox1.Image = (Image)binFormatter.Deserialize(mainStream);
            }
        }
    }
}
