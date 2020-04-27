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
using System.Drawing.Imaging;
using System.Runtime.Serialization.Formatters.Binary;

namespace Server
{
    public partial class Server : Form
    {
        private TcpClient client;
        private TcpListener server;
        private NetworkStream mainStream;

        private Thread Listening;
        private Thread ListeningData;

        public Server()
        {
            client = new TcpClient();
            Listening = new Thread(StartListening);
            ListeningData = new Thread(ReceiveData);
            InitializeComponent();
        }

        private void StartListening()
        {
            while (!client.Connected)
            {
                server.Start();
                client = server.AcceptTcpClient();
            }
            ListeningData.Start();
        }
        
        private void StopListening()
        {
            server.Stop();
            client = null;
            if (Listening.IsAlive)
            {
                Listening.Abort();
            }
        }
        private void ReceiveData()
        {
            mainStream = client.GetStream();
            int length;
            string data = null;
            byte[] bytes = new byte[256];
            length = mainStream.Read(bytes, 0, bytes.Length);
            data = Encoding.Default.GetString(bytes, 0, length);
            if(String.Format(data) == "test")
            {
                this.Invoke(new Action(delegate ()
                {
                    lblData.Text = String.Format(data);
                }));
            }
            else
            {
                this.Invoke(new Action(delegate ()
                {
                    lblData.Text = "else";
                }));

            }
            
            
            mainStream.Close();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            server = new TcpListener(IPAddress.Any, 9999);
            Listening.Start();
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            StopListening();
        }
    }

}
