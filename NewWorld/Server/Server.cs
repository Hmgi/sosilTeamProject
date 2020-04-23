using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//추가 내용
using System.Net.Sockets;

namespace Server
{
    public partial class Server : Form
    {

        //추가 내용
        private int portNumber = 9999;

        public Server()
        {
            InitializeComponent();
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            new Screen(portNumber).Show();
            btnListen.Enabled = false;
        }
    }
}
