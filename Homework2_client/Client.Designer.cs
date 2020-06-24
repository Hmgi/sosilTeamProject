namespace Homework2_client
{
    partial class Client
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_server = new System.Windows.Forms.Button();
            this.btn_path = new System.Windows.Forms.Button();
            this.btn_folder = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.Filename = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Filesize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Filedate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.상세정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.다운로드ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuList = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSmall = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLarge = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.trvDir = new System.Windows.Forms.TreeView();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.암호화ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP :";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(90, 27);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(369, 25);
            this.txt_ip.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT :";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(526, 27);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(118, 25);
            this.txt_port.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "다운로드 경로 :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(181, 68);
            this.txt_path.Name = "txt_path";
            this.txt_path.ReadOnly = true;
            this.txt_path.Size = new System.Drawing.Size(463, 25);
            this.txt_path.TabIndex = 5;
            // 
            // btn_server
            // 
            this.btn_server.Location = new System.Drawing.Point(90, 121);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(107, 29);
            this.btn_server.TabIndex = 6;
            this.btn_server.Text = "서버 연결";
            this.btn_server.UseVisualStyleBackColor = true;
            this.btn_server.Click += new System.EventHandler(this.btn_server_Click);
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(267, 121);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(107, 29);
            this.btn_path.TabIndex = 7;
            this.btn_path.Text = "경로 설정";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // btn_folder
            // 
            this.btn_folder.Location = new System.Drawing.Point(443, 121);
            this.btn_folder.Name = "btn_folder";
            this.btn_folder.Size = new System.Drawing.Size(107, 29);
            this.btn_folder.TabIndex = 8;
            this.btn_folder.Text = "폴더 열기";
            this.btn_folder.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvwFiles);
            this.groupBox1.Controls.Add(this.splitter1);
            this.groupBox1.Controls.Add(this.trvDir);
            this.groupBox1.Location = new System.Drawing.Point(-3, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(688, 409);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lvwFiles
            // 
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Filename,
            this.Filesize,
            this.Filedate});
            this.lvwFiles.ContextMenuStrip = this.contextMenuStrip1;
            this.lvwFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFiles.HideSelection = false;
            this.lvwFiles.LargeImageList = this.imageList1;
            this.lvwFiles.Location = new System.Drawing.Point(184, 21);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(501, 385);
            this.lvwFiles.SmallImageList = this.imageList1;
            this.lvwFiles.TabIndex = 2;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.DoubleClick += new System.EventHandler(this.lvwFiles_DoubleClick);
            // 
            // Filename
            // 
            this.Filename.Text = "파일이름";
            // 
            // Filesize
            // 
            this.Filesize.Text = "파일크기";
            // 
            // Filedate
            // 
            this.Filedate.Text = "수정한날짜";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.상세정보ToolStripMenuItem,
            this.다운로드ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.mnuDetail,
            this.mnuList,
            this.mnuSmall,
            this.mnuLarge,
            this.toolStripMenuItem2,
            this.암호화ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 212);
            // 
            // 상세정보ToolStripMenuItem
            // 
            this.상세정보ToolStripMenuItem.Name = "상세정보ToolStripMenuItem";
            this.상세정보ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.상세정보ToolStripMenuItem.Text = "상세정보";
            this.상세정보ToolStripMenuItem.Click += new System.EventHandler(this.상세정보ToolStripMenuItem_Click);
            // 
            // 다운로드ToolStripMenuItem
            // 
            this.다운로드ToolStripMenuItem.Name = "다운로드ToolStripMenuItem";
            this.다운로드ToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.다운로드ToolStripMenuItem.Text = "다운로드";
            this.다운로드ToolStripMenuItem.Click += new System.EventHandler(this.다운로드ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(150, 6);
            // 
            // mnuDetail
            // 
            this.mnuDetail.Name = "mnuDetail";
            this.mnuDetail.Size = new System.Drawing.Size(153, 24);
            this.mnuDetail.Text = "자세히";
            this.mnuDetail.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuList
            // 
            this.mnuList.Name = "mnuList";
            this.mnuList.Size = new System.Drawing.Size(153, 24);
            this.mnuList.Text = "간단히";
            this.mnuList.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuSmall
            // 
            this.mnuSmall.Name = "mnuSmall";
            this.mnuSmall.Size = new System.Drawing.Size(153, 24);
            this.mnuSmall.Text = "작은아이콘";
            this.mnuSmall.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // mnuLarge
            // 
            this.mnuLarge.Name = "mnuLarge";
            this.mnuLarge.Size = new System.Drawing.Size(153, 24);
            this.mnuLarge.Text = "큰아이콘";
            this.mnuLarge.Click += new System.EventHandler(this.mnuView_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "folder.png");
            this.imageList1.Images.SetKeyName(1, "avi.png");
            this.imageList1.Images.SetKeyName(2, "image.png");
            this.imageList1.Images.SetKeyName(3, "music.png");
            this.imageList1.Images.SetKeyName(4, "text.png");
            this.imageList1.Images.SetKeyName(5, "temp.png");
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(181, 21);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 385);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // trvDir
            // 
            this.trvDir.Dock = System.Windows.Forms.DockStyle.Left;
            this.trvDir.ImageIndex = 0;
            this.trvDir.ImageList = this.imageList1;
            this.trvDir.Location = new System.Drawing.Point(3, 21);
            this.trvDir.Name = "trvDir";
            this.trvDir.SelectedImageIndex = 0;
            this.trvDir.Size = new System.Drawing.Size(178, 385);
            this.trvDir.TabIndex = 0;
            this.trvDir.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeExpand);
            this.trvDir.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.trvDir_BeforeSelect);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(150, 6);
            // 
            // 암호화ToolStripMenuItem
            // 
            this.암호화ToolStripMenuItem.Name = "암호화ToolStripMenuItem";
            this.암호화ToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.암호화ToolStripMenuItem.Text = "암호화";
            this.암호화ToolStripMenuItem.Click += new System.EventHandler(this.암호화ToolStripMenuItem_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 567);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_folder);
            this.Controls.Add(this.btn_path);
            this.Controls.Add(this.btn_server);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "File Manager - Client";
            this.groupBox1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_server;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.Button btn_folder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 상세정보ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 다운로드ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuDetail;
        private System.Windows.Forms.ToolStripMenuItem mnuList;
        private System.Windows.Forms.ToolStripMenuItem mnuSmall;
        private System.Windows.Forms.ToolStripMenuItem mnuLarge;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.ListView lvwFiles;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView trvDir;
        private System.Windows.Forms.ColumnHeader Filename;
        private System.Windows.Forms.ColumnHeader Filesize;
        private System.Windows.Forms.ColumnHeader Filedate;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 암호화ToolStripMenuItem;
    }
}

