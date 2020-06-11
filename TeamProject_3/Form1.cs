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
using System.Security;
using System.Security.Cryptography;
using System.Diagnostics;

namespace TeamProject_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //AES 방식
        public readonly byte[] salt = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        public const int iterations = 1042;
        public static void DecryptFile(string inputFile, string outputFile, string path)
        {
            string currentPath = Environment.CurrentDirectory; // 현재 디렉토리 경로

            string sourceFile = currentPath + @"\" + outputFile; //현재 암호화 파일 경로
            string DestinationFile = path + @"\" + outputFile; //이동할 암호화 파일 경로

            string password = @"myKey123"; // Your Key Here

            UnicodeEncoding UE = new UnicodeEncoding();
            byte[] key = UE.GetBytes(password);

            FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

            RijndaelManaged RMCrypto = new RijndaelManaged();

            CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateDecryptor(key, key), CryptoStreamMode.Read);

            FileStream fsOut = new FileStream(outputFile, FileMode.Create);

            int data;
            while ((data = cs.ReadByte()) != -1)
                fsOut.WriteByte((byte)data);

            fsOut.Close();
            cs.Close();
            fsCrypt.Close();

            System.IO.File.Move(sourceFile, DestinationFile);
            System.IO.File.Delete(inputFile);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string path = txt_path.Text;
            if (path == "")
            {
                MessageBox.Show("존재하지 않은 경로입니다.");
            }
            else
            {
                FileInfo fi = new FileInfo(path);
                if (fi.Exists)
                {
                    btn_return.Enabled = true;
                }
                else
                {
                    MessageBox.Show("존재하지 않은 경로입니다.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "그림 파일 (*.jpg) | *.jpg; *.gif; *.bmp; | 한글 파일 (*.hwp) | *.hwp; | " +
                "PDF 파일 (*.pdf) | *.pdf;";
            openFile.ShowDialog();
            if (openFile.FileNames.Length > 0)
            {
                foreach (string filename in openFile.FileNames)
                {
                    this.txt_path.Text = filename;
                }
            }
        }

        private void btn_return_Click(object sender, EventArgs e)
        {
            string path = txt_path.Text;
            string Extension = Path.GetExtension(path);
            string DirectoryName = Path.GetDirectoryName(path);

            if (Extension == ".hwp")
            {
                string encry = "Encrypted.hwp";
                string decry = "Decrypted.hwp";
                string encrypath = DirectoryName + @"\" + encry;
                string decrypath = DirectoryName + @"\" + decry;

                DecryptFile(encrypath, decry, DirectoryName);

                MessageBox.Show("복호화 완료");
                btn_return.Enabled = false;
                Process.Start(decrypath);
            }


            if (Extension == ".jpg")
            {
                string encry = "Encrypted.jpg";
                string decry = "Decrypted.jpg";
                string encrypath = DirectoryName + @"\" + encry;
                string decrypath = DirectoryName + @"\" + decry;

                DecryptFile(encrypath, decry, DirectoryName);

                MessageBox.Show("복호화 완료");
                btn_return.Enabled = false;
                Process.Start(decrypath);
            }

            if (Extension == ".pdf")
            {
                string encry = "Encrypted.pdf";
                string decry = "Decrypted.pdf";
                string encrypath = DirectoryName + @"\" + encry;
                string decrypath = DirectoryName + @"\" + decry;

                DecryptFile(encrypath, decry, DirectoryName);

                MessageBox.Show("복호화 완료");
                btn_return.Enabled = false;
                Process.Start(decrypath);
            }
        }



        private void lb_path_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

    }
}
