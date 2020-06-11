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

namespace MainProgram.Forms
{
    public partial class FormScreen : Form
    {
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
