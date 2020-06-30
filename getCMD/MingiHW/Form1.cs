using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using System.IO;

namespace MingiHW
{
    public partial class Form1 : Form
    {
        private NetworkStream m_networkstream;
        public StreamReader m_Read;
        public StreamWriter m_Write;

        private TcpListener m_listener;

        private bool m_bClientOn = false;
        private bool m_bStop = false;

        private Thread m_thServer;
        private Thread m_ThReader;

        public Form1()
        {
            InitializeComponent();
            this.txt_command.KeyDown += com_KeyDown;
        }

        public void RUN()
        {
            try
            {
                IPAddress localAddr = IPAddress.Parse(txt_ip.Text);
                int PORT = Int32.Parse(txt_port.Text);
                this.m_listener = new TcpListener(localAddr, PORT);
                this.m_listener.Start();

                m_bStop = true;
                while(m_bStop)
                {
                    TcpClient client = this.m_listener.AcceptTcpClient();
                    
                    if(client.Connected)
                    {
                        m_bClientOn = true;

                        m_networkstream = client.GetStream();
                        m_Read = new StreamReader(m_networkstream);
                        m_Write = new StreamWriter(m_networkstream);

                        m_ThReader = new Thread(new ThreadStart(Receive));
                        m_ThReader.Start();
                    }
                }
            }
            catch
            {
                MessageBox.Show("오류 발생");
                return;
            }
            
        }

        public void Message(string msg) // log에 내용 출력
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                txt_log.AppendText(msg + "\r\n");
            }));
        }

        public void Receive() // 실행 결과 수신
        {
            try
            {
                while(m_bClientOn)
                {
                    string msg = m_Read.ReadLine();
                    if (msg != null)
                        Message(msg);
                }
            }
            catch
            {
                MessageBox.Show("데이터 읽는 과정에서 오류 발생");
                return;
            }
        }

        private void com_KeyDown(object sender, KeyEventArgs e) // enter 키 구현
        {
            if (e.KeyCode == Keys.Enter)
                btn_cmd_Click(sender, e);
        }

        private void btn_cmd_Click(object sender, EventArgs e) // 명령어 송신
        {
            try
            {
                m_Write.WriteLine(txt_command.Text);
                m_Write.Flush();
            }
            catch
            {
                Message("데이터 전송 실패");
            }
        }

        private void btn_server_Click(object sender, EventArgs e)
        {
            this.m_thServer = new Thread(new ThreadStart(RUN));
            this.m_thServer.Start();
        }
    }
}
