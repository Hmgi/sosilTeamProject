namespace MainProgram.Forms
{
    partial class FormScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScreenStart = new System.Windows.Forms.Button();
            this.btnScreenStop = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScreenStart
            // 
            this.btnScreenStart.Location = new System.Drawing.Point(681, 12);
            this.btnScreenStart.Name = "btnScreenStart";
            this.btnScreenStart.Size = new System.Drawing.Size(75, 23);
            this.btnScreenStart.TabIndex = 0;
            this.btnScreenStart.Text = "Start";
            this.btnScreenStart.UseVisualStyleBackColor = true;
            this.btnScreenStart.Click += new System.EventHandler(this.btnScreenStart_Click);
            // 
            // btnScreenStop
            // 
            this.btnScreenStop.Location = new System.Drawing.Point(681, 53);
            this.btnScreenStop.Name = "btnScreenStop";
            this.btnScreenStop.Size = new System.Drawing.Size(75, 23);
            this.btnScreenStop.TabIndex = 1;
            this.btnScreenStop.Text = "Stop";
            this.btnScreenStop.UseVisualStyleBackColor = true;
            this.btnScreenStop.Click += new System.EventHandler(this.btnScreenStop_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(645, 418);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // FormScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 442);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnScreenStop);
            this.Controls.Add(this.btnScreenStart);
            this.Name = "FormScreen";
            this.Text = "FormScreen";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnScreenStart;
        private System.Windows.Forms.Button btnScreenStop;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}