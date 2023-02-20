namespace MailSender
{
    partial class MailInfo
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
            this.txtHost = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMailAdresi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtGorunenAd = new System.Windows.Forms.TextBox();
            this.cBHost = new System.Windows.Forms.CheckBox();
            this.cBPort = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(66, 6);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(126, 23);
            this.txtHost.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(21, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 15);
            this.label9.TabIndex = 37;
            this.label9.Text = "Host";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 15);
            this.label1.TabIndex = 39;
            this.label1.Text = "Port";
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(66, 35);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(126, 23);
            this.txtPort.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(301, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Mail Adresi";
            // 
            // txtMailAdresi
            // 
            this.txtMailAdresi.Location = new System.Drawing.Point(403, 6);
            this.txtMailAdresi.Name = "txtMailAdresi";
            this.txtMailAdresi.Size = new System.Drawing.Size(148, 23);
            this.txtMailAdresi.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(301, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(403, 35);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(148, 23);
            this.txtSifre.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(301, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 45;
            this.label4.Text = "Görünecek İsim ";
            // 
            // txtGorunenAd
            // 
            this.txtGorunenAd.Location = new System.Drawing.Point(403, 64);
            this.txtGorunenAd.Name = "txtGorunenAd";
            this.txtGorunenAd.Size = new System.Drawing.Size(148, 23);
            this.txtGorunenAd.TabIndex = 44;
            // 
            // cBHost
            // 
            this.cBHost.AutoSize = true;
            this.cBHost.Location = new System.Drawing.Point(197, 11);
            this.cBHost.Name = "cBHost";
            this.cBHost.Size = new System.Drawing.Size(15, 14);
            this.cBHost.TabIndex = 46;
            this.cBHost.UseVisualStyleBackColor = true;
            this.cBHost.CheckedChanged += new System.EventHandler(this.cBHost_CheckedChanged);
            // 
            // cBPort
            // 
            this.cBPort.AutoSize = true;
            this.cBPort.Location = new System.Drawing.Point(197, 39);
            this.cBPort.Name = "cBPort";
            this.cBPort.Size = new System.Drawing.Size(15, 14);
            this.cBPort.TabIndex = 47;
            this.cBPort.UseVisualStyleBackColor = true;
            this.cBPort.CheckedChanged += new System.EventHandler(this.cBPort_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.YellowGreen;
            this.button1.Location = new System.Drawing.Point(66, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 48;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(2, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(601, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Host ve Port Alanlarındaki Değişiklik hakkında bilginiz yoksa değiştirmeyiniz. Mi" +
    "crosoft Mail Adreslerini Kullanınız.";
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRead.Location = new System.Drawing.Point(147, 60);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(120, 27);
            this.btnRead.TabIndex = 50;
            this.btnRead.Text = "Bilgileri Getir";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // MailInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Olive;
            this.ClientSize = new System.Drawing.Size(605, 107);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBPort);
            this.Controls.Add(this.cBHost);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtGorunenAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMailAdresi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtHost);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MailInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Gönderici Bilgileri";
            this.Load += new System.EventHandler(this.MailInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label9;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox cBHost;
        private CheckBox cBPort;
        private Button button1;
        public TextBox txtHost;
        public TextBox txtPort;
        public TextBox txtMailAdresi;
        public TextBox txtSifre;
        public TextBox txtGorunenAd;
        private Label label5;
        private Button btnRead;
    }
}