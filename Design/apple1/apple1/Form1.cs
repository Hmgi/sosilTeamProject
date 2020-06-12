using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apple1
{
    public partial class Form1 : Form
    {

        
        private Point mousePoint;

        Child child;
        int nChild = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));
            }
        }

        private void button_MouseHover(object sender, EventArgs e)
        {
            var buttons = sender as Button;

            if (buttons == b0)
            {
                b0.ForeColor = Color.Orange;
            }
            else if (buttons == b1)
            {
                b1.ForeColor = Color.Orange;
            }
            else if (buttons == b2)
            {
                b2.ForeColor = Color.Orange;
            }
            else if (buttons == b3)
            {
                b3.ForeColor = Color.Orange;
            }
            else if (buttons == b4)
            {
                b4.ForeColor = Color.Orange;
            }
            else if (buttons == b5)
            {
                b5.ForeColor = Color.Orange;
            }
            else if (buttons == b6)
            {
                b6.ForeColor = Color.Orange;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var buttons = sender as Button;
            if (buttons == b0)
            {
                b0.ForeColor = Color.Transparent;
            }
            else if (buttons == b1)
            {
                b1.ForeColor = Color.Transparent;
            }
            else if (buttons == b2)
            {
                b2.ForeColor = Color.Transparent;
            }
            else if (buttons == b3)
            {
                b3.ForeColor = Color.Transparent;
            }
            else if (buttons == b4)
            {
                b4.ForeColor = Color.Transparent;
            }
            else if (buttons == b5)
            {
                b5.ForeColor = Color.Transparent;
            }
            else if (buttons == b6)
            {
                b6.ForeColor = Color.Transparent;
            }
        }
        
        private void b0_Click(object sender, EventArgs e)
        {
            child = new Child();
            child.TopLevel = false;
            this.Controls.Add(child);
            child.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
