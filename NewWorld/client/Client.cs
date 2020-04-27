using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Drawing.Imaging;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace client
{
    public partial class Client : Form
    {
        private TcpClient client = new TcpClient();
        private NetworkStream mainStream;
        private int portNumber = 9999;

        public Client()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client.Connect(txtServerIP.Text, portNumber);
                btnConnect.Text = "Connected";
                MessageBox.Show("Connected");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to connect");
                btnConnect.Text = "Not Connected";
            }
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            mainStream = client.GetStream();
            string data = "qwerttt";
            byte[] bdata = Encoding.Default.GetBytes(data);
            mainStream.Write(bdata, 0, bdata.Length);
        }
    }
}
