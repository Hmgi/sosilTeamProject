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
using System.Diagnostics;
using MetroFramework.Forms;

namespace TeamProject_2
{
    public partial class Form3 : MetroForm
    {
        public Form3()
        {
            InitializeComponent();
            this.btnClose2.Click += btnClose2_Click;
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo proinfo = new System.Diagnostics.ProcessStartInfo();
            System.Diagnostics.Process pro = new System.Diagnostics.Process();

            // 실행할 프로그램 명
            proinfo.FileName = @"cmd";
            // 셀 배치 설정 = false
            proinfo.CreateNoWindow = true;
            proinfo.UseShellExecute = false;
            // 입력 Stream 사용 여부
            proinfo.RedirectStandardInput = true;
            // 출력 Stream 사용 여부
            proinfo.RedirectStandardOutput = true;
            // 에러 Stream 사용 여부
            proinfo.RedirectStandardError = true;

            // Process 클래스에 환경 설정
            pro.StartInfo = proinfo;
            pro.Start();

            string path = textBox1.Text;
            
            //string name = path.Replace(" ", "");
            // 실행 함수 호출
            pro.StandardInput.Write(@"dir {0} > test_dir.txt" + Environment.NewLine, path);

            pro.StandardInput.Close();        
            pro.WaitForExit();
            pro.Close();

            MessageBox.Show("탐색 완료!");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                string item = string.Format("Drive {0}", d.Name);
                listBox1.Items.Add(item);
            }

            listBox1.SelectedIndex = 0;
        }
    }
}
