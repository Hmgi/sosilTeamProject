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
using PacketLibrary;

namespace MainProgram.Forms
{
    public partial class FormConnect : Form
    {
        public NetworkStream mainStream;
        public TcpClient client;

        private byte[] sendBuffer = new byte[1024 * 100];
        private byte[] readBuffer = new byte[1024 * 100];

        public FormConnect()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient();
            client.Connect(this.txtIP.Text, 9999);
            mainStream = client.GetStream();

            FormScreen formScreen = new FormScreen();
            formScreen.client = client;
            formScreen.mainStream = mainStream;
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
    }
}
