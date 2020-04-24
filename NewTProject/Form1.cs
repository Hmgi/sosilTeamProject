using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Windows;
using static System.IO.Directory;

namespace NewTProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void ScreenCapture(int intBitmapWidth, int intBitmapHeight, Point ptSource)     // 스크린샷 찍는 함수
        {
            Bitmap bitmap = new Bitmap(intBitmapWidth, intBitmapHeight);
            Graphics g = Graphics.FromImage(bitmap);

            g.CopyFromScreen(ptSource, new Point(0, 0), new Size(intBitmapWidth, intBitmapHeight));

            pictureBox1.Image = bitmap;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            Image saveImage = pictureBox1.Image;

            string dir = textBox1.Text;

            if(dir == "") // 경로를 입력 안했을 경우
                MessageBox.Show("경로를 입력하세요.");
            else
            {
                if (Exists(dir))    // 경로가 존재하는지 확인
                {

                    pictureBox1.Image.Save(dir + "\\test.png", System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("저장 완료.");
                }
                else
                    MessageBox.Show("경로가 존재하지 않습니다.");
            }

        }

        private void btnImage_Click(object sender, EventArgs e) // 스크린샷 버튼
        {
            ScreenCapture(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height, new Point(0, 0));    // 스크린샷 찍는 함수 호출
        }
    }
}
