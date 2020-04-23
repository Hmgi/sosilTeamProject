using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Sockets;
using System.Net;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public partial class Screen : Form
    {
        private int port;
        private TcpClient client;
        private TcpListener server;
        private NetworkStream mainStream;

        private Thread Listening;
        private Thread GetImage;

        public Screen(int Port)
        {
            port = Port;
            client = new TcpClient();
            Listening = new Thread(StartListening);
            GetImage = new Thread(Receiveimage);

            InitializeComponent();
        }

        private void StartListening()
        {
         while(!client.Connected)
            {
                server.Start();
                client = server.AcceptTcpClient();
            }
            GetImage.Start();
        }

        private void StopListening()
        {
            server.Stop();
            client = null;
            if(Listening.IsAlive)
            {
                Listening.Abort();
            }
            if(GetImage.IsAlive)
            {
                Listening.Abort();
            }
        }

        private void Receiveimage()
        {
            BinaryFormatter binFormatter = new BinaryFormatter();
            while(client.Connected)
            {
                mainStream = client.GetStream();
                pictureBox1.Image = (Image)binFormatter.Deserialize(mainStream);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server = new TcpListener(IPAddress.Any, port);
            Listening.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }


    }
}
