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




using System.Runtime.InteropServices;



namespace MainProgram.Forms
{
    public partial class FormIPscan : Form
    {

        [DllImport("gdi32.dll")] private static extern IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2, int cx, int cy);
        [DllImport("user32.dll")] private static extern int SetWindowRgn(IntPtr hWnd, IntPtr hRgn, bool bRedraw);



        public FormIPscan()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            //
            IntPtr ip = CreateRoundRectRgn(0, 0, btnStart.Width, btnStart.Height, 15, 15);
            int i = SetWindowRgn(btnStart.Handle, ip, true);

            IntPtr ipp = CreateRoundRectRgn(0, 0, btnStop.Width, btnStop.Height, 15, 15);
            int i1 = SetWindowRgn(btnStop.Handle, ipp, true);


            //txtIP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            IntPtr ippap = CreateRoundRectRgn(0, 0, txtIP.Width, txtIP.Height, 15, 15);
            int i2 = SetWindowRgn(txtIP.Handle, ippap, true);
            //

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
