using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using System.Diagnostics;

namespace MingiHW_Client
{
    public partial class Form1 : Form
    {
        private NetworkStream m_networkstream;
        public StreamReader m_Read;
        public StreamWriter m_Write;
        string result;

        private bool m_bConnect = false;

        private Thread m_thread;
        TcpClient m_Client;
        public Form1()
        {
            InitializeComponent();
        }


        public void Receive() // 명령어 수신
        {
            try
            {
                while (m_bConnect)
                {
                    string msg = m_Read.ReadLine();
                    if (msg != null)
                    {
                        // 수신한 명령어 실행
                        ProcessStartInfo cmd = new ProcessStartInfo();
                        Process process = new Process();
                        cmd.FileName = @"cmd";
                        cmd.WindowStyle = ProcessWindowStyle.Hidden;
                        cmd.CreateNoWindow = true;

                        cmd.UseShellExecute = false;
                        cmd.RedirectStandardOutput = true;
                        cmd.RedirectStandardInput = true;
                        cmd.RedirectStandardError = true;

                        process.EnableRaisingEvents = false;
                        process.StartInfo = cmd;
                        process.Start();
                        process.StandardInput.Write(msg + Environment.NewLine);
                        process.StandardInput.Close();

                        result = process.StandardOutput.ReadToEnd();
                        StringBuilder sb = new StringBuilder();
                        sb.Append(result);

                        result = sb.ToString();
                        process.WaitForExit();
                        process.Close();

                        m_Write.WriteLine(result);
                        m_Write.Flush();
                    }
                }
            }
            catch
            {
                MessageBox.Show("데이터 읽는 과정에서 오류 발생");
                return;
            }
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            try
            {
                this.m_Client = new TcpClient();
                int PORT = Int32.Parse(txt_port.Text);
                this.m_Client.Connect(this.txt_ip.Text, PORT);
            }
            catch
            {
                MessageBox.Show("접속 에러", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            m_bConnect = true;
            m_networkstream = m_Client.GetStream();

            m_Read = new StreamReader(m_networkstream);
            m_Write = new StreamWriter(m_networkstream);

            this.m_thread = new Thread(new ThreadStart(Receive));
            this.m_thread.Start();
        }
    }
}
