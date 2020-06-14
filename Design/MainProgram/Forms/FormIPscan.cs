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
using System.Net.NetworkInformation;
using System.Threading;


namespace MainProgram.Forms
{


    public partial class FormIPscan : Form
    {
        public FormIPscan()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

        }
        Thread myThread = null;

        public void scan(string subnet)
        {
            Ping myPing;
            PingReply reply;
            IPAddress addr;
            IPHostEntry host;

            for(int i = 1; i < 255; i++)
            {
                string subnetn = "." + i.ToString();
                myPing = new Ping();
                reply = myPing.Send(subnet + subnetn);

                if(reply.Status == IPStatus.Success)
                {
                    try
                    {
                        addr = IPAddress.Parse(subnet + subnetn);
                        host = Dns.GetHostEntry(addr);

                        txtLog.AppendText("IPaddress : " + subnet + subnetn + "       HostName : " + host.HostName.ToString() + "   UP \r\n");
                    }
                    catch
                    {

                    }
                }
            }

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            myThread = new Thread(() => scan(txtIP.Text));
            myThread.Start();

            if(myThread.IsAlive)
            {
                btnStop.Enabled = true;
                btnStart.Enabled = false;
                txtIP.Enabled = false;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            myThread.Abort();
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            txtIP.Enabled = true;
        }
    }

    
}
