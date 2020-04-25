using System;
using System.IO;
using System.Security;
using System.Security.Cryptography;
using System.Text;




namespace TeamProject_
{
    class Program
    {  
        public readonly byte[] salt = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };
 
        public const int iterations = 1042; 

        public static void EncryptFile(string inputFile, string outputFile)
        {
            try
            {
                string password = @"myKey123"; // Your Key Here
                UnicodeEncoding UE = new UnicodeEncoding();
                byte[] key = UE.GetBytes(password);

                string cryptFile = outputFile;
                FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

                RijndaelManaged RMCrypto = new RijndaelManaged();

                CryptoStream cs = new CryptoStream(fsCrypt, RMCrypto.CreateEncryptor(key, key), CryptoStreamMode.Write);

                FileStream fsIn = new FileStream(inputFile, FileMode.Open);

                int data;
                while ((data = fsIn.ReadByte()) != -1)
                    cs.WriteByte((byte)data);


                fsIn.Close();
                cs.Close();
                fsCrypt.Close();

            }
            catch
            {

            }
        }

      
        public static void DecryptFile(string inputFile, string outputFile)
        {
            {
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

            }
        }

        static void Main(string[] args)
        {
            

            string currentPath = Environment.CurrentDirectory; // 현재 디렉토리 경로
            
            string[] HwpFilePath = Directory.GetFiles(currentPath, "*.hwp"); // 현재 디렉토리 경로의 hwp 파일들의 이름을 string 배열에 삽입
            for (int i = 0; i < HwpFilePath.Length; i++)
            {
                string encry = "Encrypted" + i + ".hwp";
                string decry = "Decrypted" + i + ".hwp";

                EncryptFile(HwpFilePath[i], encry);

                DecryptFile(encry, decry);
            }
            
            
            string[] JpgFilePath = Directory.GetFiles(currentPath, "*.jpg");
            for (int i = 0; i < JpgFilePath.Length; i++)
            {
                string encry = "Encrypted" + i + ".jpg";
                string decry = "Decrypted" + i + ".jpg";

                EncryptFile(JpgFilePath[i], encry);

                DecryptFile(encry, decry);
            }
            
            string[] PdfFilePath = Directory.GetFiles(currentPath, "*.pdf");
            for (int i = 0; i < PdfFilePath.Length; i++)
            {
                string encry = "Encrypted" + i + ".pdf";
                string decry = "Decrypted" + i + ".pdf";

                EncryptFile(PdfFilePath[i], encry);

                DecryptFile(encry, decry);
            }
                   
            string[] DocxFilePath = Directory.GetFiles(currentPath, "*.docx");
            for (int i = 0; i < DocxFilePath.Length; i++)
            {
                string encry = "Encrypted" + i + ".docx";
                string decry = "Decrypted" + i + ".docx";

                EncryptFile(DocxFilePath[i], encry);

                DecryptFile(encry, decry);
            }
            
        }

       
    }
}
