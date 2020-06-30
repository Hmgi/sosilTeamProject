namespace MingiHW
{
    partial class Form1
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
            this.txt_command = new System.Windows.Forms.TextBox();
            this.btn_cmd = new System.Windows.Forms.Button();
            this.txt_log = new System.Windows.Forms.TextBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_server = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_command
            // 
            this.txt_command.Location = new System.Drawing.Point(12, 40);
            this.txt_command.Name = "txt_command";
            this.txt_command.Size = new System.Drawing.Size(291, 21);
            this.txt_command.TabIndex = 0;
            // 
            // btn_cmd
            // 
            this.btn_cmd.Location = new System.Drawing.Point(309, 40);
            this.btn_cmd.Name = "btn_cmd";
            this.btn_cmd.Size = new System.Drawing.Size(90, 21);
            this.btn_cmd.TabIndex = 1;
            this.btn_cmd.Text = "명령어 실행";
            this.btn_cmd.UseVisualStyleBackColor = true;
            this.btn_cmd.Click += new System.EventHandler(this.btn_cmd_Click);
            // 
            // txt_log
            // 
            this.txt_log.Location = new System.Drawing.Point(12, 67);
            this.txt_log.Multiline = true;
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_log.Size = new System.Drawing.Size(387, 496);
            this.txt_log.TabIndex = 2;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(34, 12);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(133, 21);
            this.txt_ip.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "IP";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(218, 12);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(85, 21);
            this.txt_port.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "PORT";
            // 
            // btn_server
            // 
            this.btn_server.Location = new System.Drawing.Point(309, 10);
            this.btn_server.Name = "btn_server";
            this.btn_server.Size = new System.Drawing.Size(90, 25);
            this.btn_server.TabIndex = 7;
            this.btn_server.Text = "서버켜기";
            this.btn_server.UseVisualStyleBackColor = true;
            this.btn_server.Click += new System.EventHandler(this.btn_server_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 573);
            this.Controls.Add(this.btn_server);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ip);
            this.Controls.Add(this.txt_log);
            this.Controls.Add(this.btn_cmd);
            this.Controls.Add(this.txt_command);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_command;
        private System.Windows.Forms.Button btn_cmd;
        private System.Windows.Forms.TextBox txt_log;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_server;
    }
}

