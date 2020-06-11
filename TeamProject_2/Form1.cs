using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TeamProject_2
{
    public partial class Form1 : MetroForm
    {
        public Form1()
        {
            InitializeComponent();         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       
        private void btn_Dir_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();

            newForm.Show();
        }
        
    }
}
