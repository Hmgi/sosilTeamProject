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

            if (buttons == button1)
            {
                button1.ForeColor = Color.Orange;
            }
            else if (buttons == button2)
            {
                button2.ForeColor = Color.Orange;
            }
            else if (buttons == button3)
            {
                button3.ForeColor = Color.Orange;
            }
            else if (buttons == button4)
            {
                button4.ForeColor = Color.Orange;
            }
            else if (buttons == button5)
            {
                button5.ForeColor = Color.Orange;
            }
            else if (buttons == button6)
            {
                button6.ForeColor = Color.Orange;
            }
            else if (buttons == button7)
            {
                button7.ForeColor = Color.Orange;
            }
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var buttons = sender as Button;
            if (buttons == button1)
            {
                button1.ForeColor = Color.Transparent;
            }
            else if (buttons == button2)
            {
                button2.ForeColor = Color.Transparent;
            }
            else if (buttons == button3)
            {
                button3.ForeColor = Color.Transparent;
            }
            else if (buttons == button4)
            {
                button4.ForeColor = Color.Transparent;
            }
            else if (buttons == button5)
            {
                button5.ForeColor = Color.Transparent;
            }
            else if (buttons == button6)
            {
                button6.ForeColor = Color.Transparent;
            }
            else if (buttons == button7)
            {
                button7.ForeColor = Color.Transparent;
            }
        }
    }
}
