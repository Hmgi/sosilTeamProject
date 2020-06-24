using Homework2_client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework2_fileinfo
{
    public partial class Form2 : Form
    {
        Client m_f1;
        public string filename;
        public string extens;
        public string filepath;
        public string filesize;
        public DateTime madedate;
        public DateTime fixdate;
        public DateTime acdate;
        public int imageindex;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(Client _form)
        {
            InitializeComponent();
            m_f1 = _form;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Filepath.Text = filename;
            label9.Text = extens;
            label10.Text = filepath;
            label11.Text = filesize;
            label12.Text = madedate.ToString();
            label13.Text = fixdate.ToString();
            label14.Text = acdate.ToString();

            if (imageindex == 1)
            {
                pictureBox1.Image = imageList1.Images[1];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }      
            else if(imageindex == 2)
            {
                pictureBox1.Image = imageList1.Images[2];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }               
            else if (imageindex == 3)
            {
                pictureBox1.Image = imageList1.Images[3];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            } 
            else if (imageindex == 4)
            {
                pictureBox1.Image = imageList1.Images[4];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }              
            else
            {
                pictureBox1.Image = imageList1.Images[5];
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
