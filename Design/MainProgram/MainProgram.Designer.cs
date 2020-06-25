namespace MainProgram
{
    partial class MainProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainProgram));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.btnDecry = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnScreen = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnIPscan = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnDecry);
            this.panelMenu.Controls.Add(this.btnFile);
            this.panelMenu.Controls.Add(this.btnScreen);
            this.panelMenu.Controls.Add(this.btnConnect);
            this.panelMenu.Controls.Add(this.btnIPscan);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.lblLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Location = new System.Drawing.Point(30, 24);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(142, 30);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "New World";
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelTitle.Controls.Add(this.btnMinimize);
            this.panelTitle.Controls.Add(this.btnMaximize);
            this.panelTitle.Controls.Add(this.btnClose);
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(784, 80);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(694, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(31, 36);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.Text = "O";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(723, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(31, 36);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.Text = "O";
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(750, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(31, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "O";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 16F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(338, 24);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 25);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 80);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(784, 481);
            this.panelDesktop.TabIndex = 2;
            // 
            // btnDecry
            // 
            this.btnDecry.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDecry.FlatAppearance.BorderSize = 0;
            this.btnDecry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecry.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnDecry.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDecry.Image = ((System.Drawing.Image)(resources.GetObject("btnDecry.Image")));
            this.btnDecry.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecry.Location = new System.Drawing.Point(0, 360);
            this.btnDecry.Name = "btnDecry";
            this.btnDecry.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDecry.Size = new System.Drawing.Size(200, 70);
            this.btnDecry.TabIndex = 6;
            this.btnDecry.Text = "Decrypt";
            this.btnDecry.UseVisualStyleBackColor = true;
            this.btnDecry.Click += new System.EventHandler(this.btnDecry_Click);
            this.btnDecry.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnDecry.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // btnFile
            // 
            this.btnFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.Location = new System.Drawing.Point(0, 290);
            this.btnFile.Name = "btnFile";
            this.btnFile.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFile.Size = new System.Drawing.Size(200, 70);
            this.btnFile.TabIndex = 5;
            this.btnFile.Text = "File Explorer";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            this.btnFile.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnFile.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // btnScreen
            // 
            this.btnScreen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScreen.FlatAppearance.BorderSize = 0;
            this.btnScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScreen.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnScreen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnScreen.Image = ((System.Drawing.Image)(resources.GetObject("btnScreen.Image")));
            this.btnScreen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScreen.Location = new System.Drawing.Point(0, 220);
            this.btnScreen.Name = "btnScreen";
            this.btnScreen.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnScreen.Size = new System.Drawing.Size(200, 70);
            this.btnScreen.TabIndex = 4;
            this.btnScreen.Text = "Screen View";
            this.btnScreen.UseVisualStyleBackColor = true;
            this.btnScreen.Click += new System.EventHandler(this.btnScreen_Click);
            this.btnScreen.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnScreen.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // btnConnect
            // 
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConnect.FlatAppearance.BorderSize = 0;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnConnect.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(0, 150);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnConnect.Size = new System.Drawing.Size(200, 70);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            this.btnConnect.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnConnect.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // btnIPscan
            // 
            this.btnIPscan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIPscan.FlatAppearance.BorderSize = 0;
            this.btnIPscan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIPscan.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.btnIPscan.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnIPscan.Image = ((System.Drawing.Image)(resources.GetObject("btnIPscan.Image")));
            this.btnIPscan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIPscan.Location = new System.Drawing.Point(0, 80);
            this.btnIPscan.Name = "btnIPscan";
            this.btnIPscan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnIPscan.Size = new System.Drawing.Size(200, 70);
            this.btnIPscan.TabIndex = 2;
            this.btnIPscan.Text = "IPscan";
            this.btnIPscan.UseVisualStyleBackColor = true;
            this.btnIPscan.Click += new System.EventHandler(this.btnIPscan_Click);
            this.btnIPscan.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            this.btnIPscan.MouseHover += new System.EventHandler(this.button_MouseHover);
            // 
            // MainProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(650, 470);
            this.Name = "MainProgram";
            this.Text = "MainProgram";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnIPscan;
        private System.Windows.Forms.Button btnDecry;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnScreen;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Button btnMinimize;
    }
}

