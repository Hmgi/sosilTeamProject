using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainProgram
{
    public partial class MainProgram : Form
    {
        private Button currentButton;
        private Form activeForm;

        public MainProgram()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ActivateButton(object btnSender)
        {
            string colorN = "#259E92";
            if(btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml(colorN);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    lblTitle.Text = currentButton.Text;
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in panelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
                }
            }
        }

        private void btnIPscan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormIPscan(), sender);
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormConnect(), sender);
        }

        private void btnScreen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormScreen(), sender);
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormFile(), sender);
        }

        private void btnDecry_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new Forms.FormDecry(), sender);
        }

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        ////////////////////

        private void button_MouseHover(object sender, EventArgs e)
        {
            var buttons = sender as Button;

            if (buttons == btnIPscan)
            {
                btnIPscan.ForeColor = Color.Aqua;
            }
            else if (buttons == btnConnect)
            {
                btnConnect.ForeColor = Color.Aqua;
            }
            else if (buttons == btnScreen)
            {
                btnScreen.ForeColor = Color.Aqua;
            }
            else if (buttons == btnFile)
            {
                btnFile.ForeColor = Color.Aqua;
            }
            else if (buttons == btnDecry)
            {
                btnDecry.ForeColor = Color.Aqua;
            }
           
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            var buttons = sender as Button;
            if (buttons == btnIPscan)
            {
                btnIPscan.ForeColor = Color.Transparent;
            }
            else if (buttons == btnConnect)
            {
                btnConnect.ForeColor = Color.Transparent;
            }
            else if (buttons == btnScreen)
            {
                btnScreen.ForeColor = Color.Transparent;
            }
            else if (buttons == btnFile)
            {
                btnFile.ForeColor = Color.Transparent;
            }
            else if (buttons == btnDecry)
            {
                btnDecry.ForeColor = Color.Transparent;
            }
            
        }


    }
}
