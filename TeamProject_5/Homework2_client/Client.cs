using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary1;
using System.Net.Sockets;
using System.Threading;
using System.IO;
using System.Diagnostics;
using homework2_fileinfo;
using System.ComponentModel.Design.Serialization;
using System.Xml.Serialization;
using System.Security.Cryptography;

namespace Homework2_client
{
    public partial class Client : Form
    {

        private NetworkStream m_networkstream;
        private TcpClient m_Client;

        private byte[] sendBuffer = new byte[1024 * 4];
        private byte[] readBuffer = new byte[1024 * 4];

        private bool m_bConnect = false;
        private Thread m_thread;

        public Initialize m_initializeClass;
        public Login m_loginClass;
        public Select m_SelectClass;
        public Detail m_DetailClass;
        public Download m_DownloadClass;
        public Doubleclick m_DoubleClass;
        public TreeNode node;
        public string downfilename;
        public int doubleclick = 0;

        public void Send()
        {
            this.m_networkstream.Write(this.sendBuffer, 0, this.sendBuffer.Length);
            this.m_networkstream.Flush();

            for (int i = 0; i < 1024 * 4; i++)
            {
                this.sendBuffer[i] = 0;
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.m_Client.Close();
            this.m_networkstream.Close();
        }

        public Client()
        {
            InitializeComponent();
        }
        public void setPlus(TreeNode node)
        {
            string path;
            DirectoryInfo dir;
            DirectoryInfo[] di;

            try
            {
                path = node.FullPath;
                dir = new DirectoryInfo(path);
                di = dir.GetDirectories();
                if (di.Length > 0)
                    node.Nodes.Add("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void btn_server_Click(object sender, EventArgs e)
        {

            if (btn_server.Text == "서버 연결")
            {
                if (txt_path.Text == "")
                    MessageBox.Show("경로를 선택해주세요.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    string port = txt_port.Text;
                    int Port = Convert.ToInt32(port);
                    this.m_Client = new TcpClient();
                    try
                    {
                        this.m_Client.Connect(this.txt_ip.Text, Port);
                        this.m_bConnect = true;
                        this.m_networkstream = this.m_Client.GetStream();
                        this.m_thread = new Thread(new ThreadStart(RUN));
                        this.m_thread.Start();
                    }
                    catch
                    {
                        MessageBox.Show("접속 에러");
                        return;
                    }
                    btn_server.Text = "서버 끊기";
                    btn_server.ForeColor = Color.Red;
                    if (!this.m_bConnect)
                    {
                        return;
                    }                   
                }
            }
            else
            {
                this.m_Client.Close();
                this.m_networkstream.Close();
                btn_server.Text = "서버 연결";
                btn_server.ForeColor = Color.Black;
            }
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fdb = new FolderBrowserDialog();
            if (fdb.ShowDialog() == DialogResult.OK)
            {
                txt_path.Text = fdb.SelectedPath;
            }
        }

        private void trvDir_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if(doubleclick == 0)
            {
                node = e.Node;
                Login expand = new Login();
                expand.Type = (int)PacketType.확장;
                expand.path = e.Node.FullPath;
                Packet.Serialize(expand).CopyTo(this.sendBuffer, 0);
                this.Send();
            }
            /*
            if (doubleclick == 1)
            {
                node = e.Node;
                doubleclick = 0;

                Doubleclick db = new Doubleclick(e.Node.FullPath);
                db.Type = (int)PacketType.더블클릭;
                db.path = e.Node.FullPath;
                Packet.Serialize(db).CopyTo(this.sendBuffer, 0);
                this.Send();
            }
            */
        }

        private void trvDir_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            node = e.Node;
            Select choice = new Select();
            choice.Type = (int)PacketType.선택;
            choice.path = e.Node.FullPath;
            Packet.Serialize(choice).CopyTo(this.sendBuffer, 0);
            this.Send();
        }

        private void 상세정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenDetail();
        }
        private void 다운로드ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ListView.SelectedListViewItemCollection siList;
            siList = lvwFiles.SelectedItems;
            
            foreach (ListViewItem item in siList)
            {
                OpenFile(item);
            }
        }
        public void OpenFile(ListViewItem item)
        {
            TreeNode downNode = trvDir.SelectedNode;
            if (item.Tag.ToString() == "D")
            {
                MessageBox.Show("폴더는 다운로드를 지원하지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {              
                downfilename = item.Text;
                Download path = new Download(downNode.FullPath + "\\" + item.Text);
                path.Type = (int)PacketType.다운로드;
                Packet.Serialize(path).CopyTo(this.sendBuffer, 0);
                this.Send();
            }
        }
        public readonly byte[] salt = new byte[] { 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00 };

        public const int iterations = 1042;
        private void 암호화ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection siList;
            siList = lvwFiles.SelectedItems;

            foreach (ListViewItem item in siList)
            {
                OpenEncry(item);
            }
        }

        public void OpenEncry(ListViewItem item)
        {
            TreeNode EncryNode = trvDir.SelectedNode;
            if (item.Tag.ToString() == "D")
            {
                MessageBox.Show("폴더는 암호화를 지원하지 않습니다.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Doubleclick db = new Doubleclick();
                db.Type = (int)PacketType.암호화;
                db.path = EncryNode.FullPath + "\\" + item.Text;
                Packet.Serialize(db).CopyTo(this.sendBuffer, 0);
                this.Send();
            }
        }
        public static void EncryptFile(string inputFile, string outputFile, string path)
        {
            string currentPath = Environment.CurrentDirectory; // 현재 디렉토리 경로

            string sourceFile = currentPath + @"\" + outputFile; //현재 암호화 파일 경로
            string DestinationFile = path + @"\" + outputFile; //이동할 암호화 파일 경로

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

            System.IO.File.Move(sourceFile, DestinationFile);
            System.IO.File.Delete(inputFile);
        }
        
        private void lvwFiles_DoubleClick(object sender, EventArgs e)
        {
            OpenDetail();
        }
        public void OpenDetail()
        {
            ListView.SelectedListViewItemCollection siList;
            siList = lvwFiles.SelectedItems;

            foreach (ListViewItem item in siList)
            {
                OpenItem(item);
            }          
        }
        public void OpenItem(ListViewItem item)
        {
            TreeNode root;
            TreeNode child;
            

            if (item.Tag.ToString() == "D")
            {
                //doubleclick = 1;
                root = trvDir.SelectedNode;

                root.Expand();

                child = root.FirstNode;

                while (child != null)
                {
                    if (child.Text == item.Text)
                    {
                        trvDir.SelectedNode = child;
                        trvDir.Focus();

                        break;
                    }
                    child = child.NextNode;
                }
                
            }
            else
            {
                root = trvDir.SelectedNode;
                string path = (root.FullPath + "\\" + item.Text);
                Detail info = new Detail();
                info.Type = (int)PacketType.상세정보;
                info.path = path;
                Packet.Serialize(info).CopyTo(this.sendBuffer, 0);
                this.Send();
            }
        }
        private void mnuView_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem item = (ToolStripMenuItem)sender;

            mnuDetail.Checked = false;
            mnuList.Checked = false;
            mnuSmall.Checked = false;
            mnuLarge.Checked = false;

            switch (item.Text)
            {
                case "자세히":
                    mnuDetail.Checked = true;
                    lvwFiles.View = View.Details;
                    break;
                case "간단히":
                    mnuList.Checked = true;
                    lvwFiles.View = View.List;
                    break;
                case "작은아이콘":
                    mnuSmall.Checked = true;
                    lvwFiles.View = View.SmallIcon;
                    break;
                case "큰아이콘":
                    mnuLarge.Checked = true;
                    lvwFiles.View = View.LargeIcon;
                    break;
            }
        }
        
        public void RUN()
        {
            Initialize Init = new Initialize();
            Init.Type = (int)PacketType.초기화;
            Packet.Serialize(Init).CopyTo(this.sendBuffer, 0);
            this.Send();

            int nRead = 0;
            while (this.m_bConnect)
            {
                try
                {
                    nRead = 0;
                    nRead = this.m_networkstream.Read(readBuffer, 0, 1024 * 4);
                }
                catch
                {
                    this.m_bConnect = false;
                    this.m_networkstream = null;
                }

                Packet packet = (Packet)Packet.Desserialize(this.readBuffer);

                switch ((int)packet.Type)
                {
                    case (int)PacketType.초기화:
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                TreeNode root;
                                root = trvDir.Nodes.Add(packet.path);
                                root.ImageIndex = 0;

                                if (trvDir.SelectedNode == null)
                                    trvDir.SelectedNode = root;
                                root.Nodes.Add("");
                               
                            }));
                            break;
                        }
                    case (int)PacketType.확장:
                        {
                            this.m_loginClass = (Login)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                TreeNode root;
                                node.Nodes.Clear();
                                DirectoryInfo[] di = packet.dir.GetDirectories();

                                foreach (DirectoryInfo dirs in di)
                                {
                                    root = node.Nodes.Add(dirs.Name);
                                    setPlus(root);
                                }
                            }));
                            break;
                        }
                    case (int)PacketType.선택:
                        {
                            this.m_SelectClass = (Select)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {                       
                                lvwFiles.Items.Clear();

                                DirectoryInfo[] diarray = packet.dir.GetDirectories();
                                ListViewItem item;
                                FileInfo[] fiarray;

                                foreach (DirectoryInfo tdis in diarray)
                                {
                                    item = lvwFiles.Items.Add(tdis.Name);
                                    item.SubItems.Add("");
                                    item.SubItems.Add(tdis.LastWriteTime.ToString());
                                    item.ImageIndex = 0;
                                    item.Tag = "D";
                                }
                                fiarray = packet.dir.GetFiles();
                                foreach (FileInfo fis in fiarray)
                                {
                                    string extens = Path.GetExtension(fis.FullName);
                                    item = lvwFiles.Items.Add(fis.Name);
                                    item.SubItems.Add(fis.Length.ToString());
                                    item.SubItems.Add(fis.LastWriteTime.ToString());
                             
                                    item.Tag = "F";
                                    if (extens == ".avi" || extens == ".mp4")
                                        item.ImageIndex = 1;
                                    else if (extens == ".jpg" || extens == ".png")
                                        item.ImageIndex = 2;
                                    else if (extens == ".mp3" || extens == ".wav")
                                        item.ImageIndex = 3;
                                    else if (extens == ".txt")
                                        item.ImageIndex = 4;
                                    else 
                                        item.ImageIndex = 5;
                                }
                            }));
                            break;
                        }
                    case (int)PacketType.상세정보:
                        {
                            this.m_DetailClass = (Detail)Packet.Desserialize(this.readBuffer);
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                var info = packet.fi;
                                Form2 dlg = new Form2();
                                string extens = info.FullName;
                                int length = extens.Length-4;
                                extens = extens.Substring(length, 4);

                                dlg.filename = info.Name;
                                dlg.extens = extens;
                                dlg.filepath = info.DirectoryName;
                                dlg.filesize = info.Length+" 바이트";
                                dlg.madedate = info.CreationTime;
                                dlg.fixdate = info.LastWriteTime;
                                dlg.acdate = info.LastAccessTime;

                                if (extens == ".avi" || extens == ".mp4")
                                    dlg.imageindex = 1;
                                else if (extens == ".jpg" || extens == ".png")
                                    dlg.imageindex = 2;
                                else if (extens == ".mp3" || extens == ".wav")
                                    dlg.imageindex = 3;
                                else if (extens == ".txt")
                                    dlg.imageindex = 4;
                                else
                                    dlg.imageindex = 5;

                                dlg.Show();
                            }));
                            break;
                        }
                    case (int)PacketType.다운로드:
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                this.m_DownloadClass = (Download)Packet.Desserialize(this.readBuffer);
                                FileInfo file = m_DownloadClass.fi;
                                file.CopyTo(txt_path.Text + "\\" + downfilename, true);
                            }));
                            break;
                        }
                    case (int)PacketType.암호화:
                        {                            
                            this.Invoke(new MethodInvoker(delegate ()
                            {                            
                                this.m_DoubleClass = (Doubleclick)Packet.Desserialize(this.readBuffer);
                                //ListViewItem item = lvwFiles.SelectedItems[0];
                                string Extension = Path.GetExtension(packet.path);

                                string inputfile = packet.path;
                                string path = Path.GetDirectoryName(packet.path);

                                if (Extension == ".hwp")
                                {
                                    string encry = "Encrypted.hwp";

                                    EncryptFile(inputfile, encry, path);

                                    MessageBox.Show("암호화 완료");
                                }
                                else if (Extension == ".jpg")
                                {
                                    string encry = "Encrypted.jpg";

                                    EncryptFile(inputfile, encry, path);

                                    MessageBox.Show("암호화 완료");
                                }
                                else if (Extension == ".pdf")
                                {
                                    string encry = "Encrypted.pdf";

                                    EncryptFile(inputfile, encry, path);

                                    MessageBox.Show("암호화 완료");
                                }

                            }));                        
                            break;
                        }
                }
            }

       
    }

        
    }
}
