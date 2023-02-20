namespace MailSender
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKime = new System.Windows.Forms.TextBox();
            this.txtKonu = new System.Windows.Forms.TextBox();
            this.rtxtIcerik = new System.Windows.Forms.RichTextBox();
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.btnGonder = new System.Windows.Forms.Button();
            this.lblDosyaGonder = new System.Windows.Forms.Label();
            this.btnKopyalaYol = new System.Windows.Forms.Button();
            this.rTxtLog = new System.Windows.Forms.RichTextBox();
            this.btnYapistir = new System.Windows.Forms.Button();
            this.lblCopyPath = new System.Windows.Forms.Label();
            this.lblDestPath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.btnTimerStop = new System.Windows.Forms.Button();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSonGorev = new System.Windows.Forms.Label();
            this.lblBasla = new System.Windows.Forms.Label();
            this.lblSayi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblStartTime = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.CbMailGonder = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbYedekSayisi = new System.Windows.Forms.ComboBox();
            this.lblState = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSaatlikBasla = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.saat1 = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSonSaat = new System.Windows.Forms.Label();
            this.lblSonSayi = new System.Windows.Forms.Label();
            this.lblSaatlikToplam = new System.Windows.Forms.Label();
            this.lblSaatlikSonIslem = new System.Windows.Forms.Label();
            this.lblSaatlikDest = new System.Windows.Forms.Label();
            this.lblSaatlikCopy = new System.Windows.Forms.Label();
            this.btnSaatlikDestPath = new System.Windows.Forms.Button();
            this.btnSaatlikSourcePath = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.cb3islem = new System.Windows.Forms.CheckBox();
            this.cb2islem = new System.Windows.Forms.CheckBox();
            this.cb1islem = new System.Windows.Forms.CheckBox();
            this.Dakika3 = new System.Windows.Forms.NumericUpDown();
            this.saat3 = new System.Windows.Forms.NumericUpDown();
            this.lblSaatDurum = new System.Windows.Forms.Label();
            this.Dakika2 = new System.Windows.Forms.NumericUpDown();
            this.saat2 = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSaatlikDurdur = new System.Windows.Forms.Button();
            this.Dakika1 = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.saat1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(4, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(4, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Konu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(4, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "İçerik";
            // 
            // txtKime
            // 
            this.txtKime.Location = new System.Drawing.Point(46, 48);
            this.txtKime.Name = "txtKime";
            this.txtKime.Size = new System.Drawing.Size(208, 23);
            this.txtKime.TabIndex = 3;
            // 
            // txtKonu
            // 
            this.txtKonu.Location = new System.Drawing.Point(46, 86);
            this.txtKonu.Name = "txtKonu";
            this.txtKonu.Size = new System.Drawing.Size(208, 23);
            this.txtKonu.TabIndex = 4;
            // 
            // rtxtIcerik
            // 
            this.rtxtIcerik.Location = new System.Drawing.Point(46, 127);
            this.rtxtIcerik.Name = "rtxtIcerik";
            this.rtxtIcerik.Size = new System.Drawing.Size(208, 96);
            this.rtxtIcerik.TabIndex = 5;
            this.rtxtIcerik.Text = "";
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDosyaEkle.Location = new System.Drawing.Point(46, 241);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(87, 23);
            this.btnDosyaEkle.TabIndex = 6;
            this.btnDosyaEkle.Text = "Dosya Ekle";
            this.btnDosyaEkle.UseVisualStyleBackColor = true;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // btnGonder
            // 
            this.btnGonder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGonder.Location = new System.Drawing.Point(167, 241);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(87, 23);
            this.btnGonder.TabIndex = 7;
            this.btnGonder.Text = "Mail Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // lblDosyaGonder
            // 
            this.lblDosyaGonder.AutoSize = true;
            this.lblDosyaGonder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDosyaGonder.ForeColor = System.Drawing.Color.Red;
            this.lblDosyaGonder.Location = new System.Drawing.Point(4, 267);
            this.lblDosyaGonder.Name = "lblDosyaGonder";
            this.lblDosyaGonder.Size = new System.Drawing.Size(10, 15);
            this.lblDosyaGonder.TabIndex = 8;
            this.lblDosyaGonder.Text = " ";
            // 
            // btnKopyalaYol
            // 
            this.btnKopyalaYol.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnKopyalaYol.Location = new System.Drawing.Point(275, 47);
            this.btnKopyalaYol.Name = "btnKopyalaYol";
            this.btnKopyalaYol.Size = new System.Drawing.Size(150, 23);
            this.btnKopyalaYol.TabIndex = 9;
            this.btnKopyalaYol.Text = "Kopyalanacak Dosya seç";
            this.btnKopyalaYol.UseVisualStyleBackColor = true;
            this.btnKopyalaYol.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // rTxtLog
            // 
            this.rTxtLog.Location = new System.Drawing.Point(4, 303);
            this.rTxtLog.Name = "rTxtLog";
            this.rTxtLog.Size = new System.Drawing.Size(677, 222);
            this.rTxtLog.TabIndex = 11;
            this.rTxtLog.Text = "";
            // 
            // btnYapistir
            // 
            this.btnYapistir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYapistir.Location = new System.Drawing.Point(275, 92);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(150, 23);
            this.btnYapistir.TabIndex = 12;
            this.btnYapistir.Text = "Yapıştırılacak Alan Seç";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // lblCopyPath
            // 
            this.lblCopyPath.AutoSize = true;
            this.lblCopyPath.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCopyPath.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblCopyPath.Location = new System.Drawing.Point(275, 74);
            this.lblCopyPath.Name = "lblCopyPath";
            this.lblCopyPath.Size = new System.Drawing.Size(111, 12);
            this.lblCopyPath.TabIndex = 14;
            this.lblCopyPath.Text = "Kopyalanan Dosya Yolu";
            // 
            // lblDestPath
            // 
            this.lblDestPath.AutoSize = true;
            this.lblDestPath.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDestPath.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblDestPath.Location = new System.Drawing.Point(275, 118);
            this.lblDestPath.Name = "lblDestPath";
            this.lblDestPath.Size = new System.Drawing.Size(119, 12);
            this.lblDestPath.TabIndex = 15;
            this.lblDestPath.Text = "Yapıştırılacak Dosya Yolu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(295, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Yedek Alma Operasyonları";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(551, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 57);
            this.button1.TabIndex = 17;
            this.button1.Text = "Zamanlı Görev Başlat";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTimerStop.Image = ((System.Drawing.Image)(resources.GetObject("btnTimerStop.Image")));
            this.btnTimerStop.Location = new System.Drawing.Point(551, 190);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(110, 57);
            this.btnTimerStop.TabIndex = 18;
            this.btnTimerStop.Text = "Zamanlı Görev Durdur";
            this.btnTimerStop.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimerStop.UseVisualStyleBackColor = true;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // cmbTime
            // 
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Location = new System.Drawing.Point(421, 193);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(121, 23);
            this.cmbTime.TabIndex = 19;
            this.cmbTime.SelectedIndexChanged += new System.EventHandler(this.cmbTime_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(95, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Mail Operasyonları";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(275, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 15);
            this.label6.TabIndex = 21;
            this.label6.Text = "Görevin Zaman Aralığı";
            // 
            // lblSonGorev
            // 
            this.lblSonGorev.AutoSize = true;
            this.lblSonGorev.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSonGorev.Location = new System.Drawing.Point(295, 249);
            this.lblSonGorev.Name = "lblSonGorev";
            this.lblSonGorev.Size = new System.Drawing.Size(109, 15);
            this.lblSonGorev.TabIndex = 29;
            this.lblSonGorev.Text = "Son Görev Zamanı";
            // 
            // lblBasla
            // 
            this.lblBasla.AutoSize = true;
            this.lblBasla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBasla.Location = new System.Drawing.Point(275, 227);
            this.lblBasla.Name = "lblBasla";
            this.lblBasla.Size = new System.Drawing.Size(151, 15);
            this.lblBasla.TabIndex = 28;
            this.lblBasla.Text = "Görev Başlama Zamanı      ";
            // 
            // lblSayi
            // 
            this.lblSayi.AutoSize = true;
            this.lblSayi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSayi.Location = new System.Drawing.Point(411, 267);
            this.lblSayi.Name = "lblSayi";
            this.lblSayi.Size = new System.Drawing.Size(14, 15);
            this.lblSayi.TabIndex = 27;
            this.lblSayi.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(280, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Toplam Alınan Yedek = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(448, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 15);
            this.label8.TabIndex = 30;
            // 
            // lblStartTime
            // 
            this.lblStartTime.AutoSize = true;
            this.lblStartTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStartTime.Location = new System.Drawing.Point(413, 227);
            this.lblStartTime.Name = "lblStartTime";
            this.lblStartTime.Size = new System.Drawing.Size(15, 15);
            this.lblStartTime.TabIndex = 31;
            this.lblStartTime.Text = "=";
            // 
            // lblLastTime
            // 
            this.lblLastTime.AutoSize = true;
            this.lblLastTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLastTime.Location = new System.Drawing.Point(410, 249);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(15, 15);
            this.lblLastTime.TabIndex = 32;
            this.lblLastTime.Text = "=";
            // 
            // CbMailGonder
            // 
            this.CbMailGonder.AutoSize = true;
            this.CbMailGonder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CbMailGonder.Location = new System.Drawing.Point(275, 136);
            this.CbMailGonder.Name = "CbMailGonder";
            this.CbMailGonder.Size = new System.Drawing.Size(270, 19);
            this.CbMailGonder.TabIndex = 33;
            this.CbMailGonder.Text = "Yedek Tamamlanma Durumunu Mail Gönder";
            this.CbMailGonder.UseVisualStyleBackColor = true;
            this.CbMailGonder.CheckedChanged += new System.EventHandler(this.CbMailGonder_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(314, 164);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 15);
            this.label9.TabIndex = 36;
            this.label9.Text = "En Fazla Depolanacak Yedek Sayısı";
            // 
            // cmbYedekSayisi
            // 
            this.cmbYedekSayisi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cmbYedekSayisi.FormattingEnabled = true;
            this.cmbYedekSayisi.Location = new System.Drawing.Point(275, 161);
            this.cmbYedekSayisi.Name = "cmbYedekSayisi";
            this.cmbYedekSayisi.Size = new System.Drawing.Size(33, 23);
            this.cmbYedekSayisi.TabIndex = 37;
            // 
            // lblState
            // 
            this.lblState.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblState.Location = new System.Drawing.Point(572, 267);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(75, 33);
            this.lblState.TabIndex = 38;
            this.lblState.Text = "    ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(466, 276);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 15);
            this.label10.TabIndex = 39;
            this.label10.Text = "Görev Durumu";
            // 
            // btnSaatlikBasla
            // 
            this.btnSaatlikBasla.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaatlikBasla.Image = ((System.Drawing.Image)(resources.GetObject("btnSaatlikBasla.Image")));
            this.btnSaatlikBasla.Location = new System.Drawing.Point(180, 9);
            this.btnSaatlikBasla.Name = "btnSaatlikBasla";
            this.btnSaatlikBasla.Size = new System.Drawing.Size(110, 57);
            this.btnSaatlikBasla.TabIndex = 40;
            this.btnSaatlikBasla.Text = "Saate Göre İşlem Başlat";
            this.btnSaatlikBasla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaatlikBasla.UseVisualStyleBackColor = true;
            this.btnSaatlikBasla.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // saat1
            // 
            this.saat1.Location = new System.Drawing.Point(29, 30);
            this.saat1.Name = "saat1";
            this.saat1.Size = new System.Drawing.Size(38, 23);
            this.saat1.TabIndex = 41;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblSonSaat);
            this.panel1.Controls.Add(this.lblSonSayi);
            this.panel1.Controls.Add(this.lblSaatlikToplam);
            this.panel1.Controls.Add(this.lblSaatlikSonIslem);
            this.panel1.Controls.Add(this.lblSaatlikDest);
            this.panel1.Controls.Add(this.lblSaatlikCopy);
            this.panel1.Controls.Add(this.btnSaatlikDestPath);
            this.panel1.Controls.Add(this.btnSaatlikSourcePath);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.cb3islem);
            this.panel1.Controls.Add(this.cb2islem);
            this.panel1.Controls.Add(this.cb1islem);
            this.panel1.Controls.Add(this.Dakika3);
            this.panel1.Controls.Add(this.saat3);
            this.panel1.Controls.Add(this.lblSaatDurum);
            this.panel1.Controls.Add(this.Dakika2);
            this.panel1.Controls.Add(this.saat2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnSaatlikDurdur);
            this.panel1.Controls.Add(this.Dakika1);
            this.panel1.Controls.Add(this.btnSaatlikBasla);
            this.panel1.Controls.Add(this.saat1);
            this.panel1.Location = new System.Drawing.Point(687, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 297);
            this.panel1.TabIndex = 42;
            // 
            // lblSonSaat
            // 
            this.lblSonSaat.AutoSize = true;
            this.lblSonSaat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSonSaat.Location = new System.Drawing.Point(141, 205);
            this.lblSonSaat.Name = "lblSonSaat";
            this.lblSonSaat.Size = new System.Drawing.Size(0, 15);
            this.lblSonSaat.TabIndex = 60;
            // 
            // lblSonSayi
            // 
            this.lblSonSayi.AutoSize = true;
            this.lblSonSayi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSonSayi.Location = new System.Drawing.Point(141, 220);
            this.lblSonSayi.Name = "lblSonSayi";
            this.lblSonSayi.Size = new System.Drawing.Size(17, 15);
            this.lblSonSayi.TabIndex = 59;
            this.lblSonSayi.Text = "0 ";
            // 
            // lblSaatlikToplam
            // 
            this.lblSaatlikToplam.AutoSize = true;
            this.lblSaatlikToplam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaatlikToplam.Location = new System.Drawing.Point(9, 220);
            this.lblSaatlikToplam.Name = "lblSaatlikToplam";
            this.lblSaatlikToplam.Size = new System.Drawing.Size(135, 15);
            this.lblSaatlikToplam.TabIndex = 58;
            this.lblSaatlikToplam.Text = "Toplam Alınan Yedek = ";
            // 
            // lblSaatlikSonIslem
            // 
            this.lblSaatlikSonIslem.AutoSize = true;
            this.lblSaatlikSonIslem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaatlikSonIslem.Location = new System.Drawing.Point(24, 205);
            this.lblSaatlikSonIslem.Name = "lblSaatlikSonIslem";
            this.lblSaatlikSonIslem.Size = new System.Drawing.Size(118, 15);
            this.lblSaatlikSonIslem.TabIndex = 57;
            this.lblSaatlikSonIslem.Text = "Son İşlem Zamanı = ";
            // 
            // lblSaatlikDest
            // 
            this.lblSaatlikDest.AutoSize = true;
            this.lblSaatlikDest.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaatlikDest.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSaatlikDest.Location = new System.Drawing.Point(8, 186);
            this.lblSaatlikDest.Name = "lblSaatlikDest";
            this.lblSaatlikDest.Size = new System.Drawing.Size(119, 12);
            this.lblSaatlikDest.TabIndex = 56;
            this.lblSaatlikDest.Text = "Yapıştırılacak Dosya Yolu";
            // 
            // lblSaatlikCopy
            // 
            this.lblSaatlikCopy.AutoSize = true;
            this.lblSaatlikCopy.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaatlikCopy.ForeColor = System.Drawing.Color.Goldenrod;
            this.lblSaatlikCopy.Location = new System.Drawing.Point(8, 142);
            this.lblSaatlikCopy.Name = "lblSaatlikCopy";
            this.lblSaatlikCopy.Size = new System.Drawing.Size(111, 12);
            this.lblSaatlikCopy.TabIndex = 55;
            this.lblSaatlikCopy.Text = "Kopyalanan Dosya Yolu";
            // 
            // btnSaatlikDestPath
            // 
            this.btnSaatlikDestPath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaatlikDestPath.Location = new System.Drawing.Point(8, 160);
            this.btnSaatlikDestPath.Name = "btnSaatlikDestPath";
            this.btnSaatlikDestPath.Size = new System.Drawing.Size(150, 23);
            this.btnSaatlikDestPath.TabIndex = 54;
            this.btnSaatlikDestPath.Text = "Yapıştırılacak Alan Seç";
            this.btnSaatlikDestPath.UseVisualStyleBackColor = true;
            this.btnSaatlikDestPath.Click += new System.EventHandler(this.btnSaatlikDestPath_Click);
            // 
            // btnSaatlikSourcePath
            // 
            this.btnSaatlikSourcePath.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaatlikSourcePath.Location = new System.Drawing.Point(8, 115);
            this.btnSaatlikSourcePath.Name = "btnSaatlikSourcePath";
            this.btnSaatlikSourcePath.Size = new System.Drawing.Size(150, 23);
            this.btnSaatlikSourcePath.TabIndex = 53;
            this.btnSaatlikSourcePath.Text = "Kopyalanacak Dosya seç";
            this.btnSaatlikSourcePath.UseVisualStyleBackColor = true;
            this.btnSaatlikSourcePath.Click += new System.EventHandler(this.btnSaatlikSourcePath_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(24, 273);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 15);
            this.label13.TabIndex = 52;
            this.label13.Text = "Görev Durumu";
            // 
            // cb3islem
            // 
            this.cb3islem.AutoSize = true;
            this.cb3islem.Location = new System.Drawing.Point(8, 96);
            this.cb3islem.Name = "cb3islem";
            this.cb3islem.Size = new System.Drawing.Size(15, 14);
            this.cb3islem.TabIndex = 51;
            this.cb3islem.UseVisualStyleBackColor = true;
            this.cb3islem.CheckedChanged += new System.EventHandler(this.cb3islem_CheckedChanged);
            // 
            // cb2islem
            // 
            this.cb2islem.AutoSize = true;
            this.cb2islem.Location = new System.Drawing.Point(8, 67);
            this.cb2islem.Name = "cb2islem";
            this.cb2islem.Size = new System.Drawing.Size(15, 14);
            this.cb2islem.TabIndex = 51;
            this.cb2islem.UseVisualStyleBackColor = true;
            this.cb2islem.CheckedChanged += new System.EventHandler(this.cb2islem_CheckedChanged);
            // 
            // cb1islem
            // 
            this.cb1islem.AutoSize = true;
            this.cb1islem.Location = new System.Drawing.Point(8, 38);
            this.cb1islem.Name = "cb1islem";
            this.cb1islem.Size = new System.Drawing.Size(15, 14);
            this.cb1islem.TabIndex = 50;
            this.cb1islem.UseVisualStyleBackColor = true;
            this.cb1islem.CheckedChanged += new System.EventHandler(this.cb1islem_CheckedChanged);
            // 
            // Dakika3
            // 
            this.Dakika3.Location = new System.Drawing.Point(79, 88);
            this.Dakika3.Name = "Dakika3";
            this.Dakika3.Size = new System.Drawing.Size(38, 23);
            this.Dakika3.TabIndex = 49;
            // 
            // saat3
            // 
            this.saat3.Location = new System.Drawing.Point(29, 88);
            this.saat3.Name = "saat3";
            this.saat3.Size = new System.Drawing.Size(38, 23);
            this.saat3.TabIndex = 48;
            // 
            // lblSaatDurum
            // 
            this.lblSaatDurum.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblSaatDurum.Location = new System.Drawing.Point(134, 264);
            this.lblSaatDurum.Name = "lblSaatDurum";
            this.lblSaatDurum.Size = new System.Drawing.Size(75, 33);
            this.lblSaatDurum.TabIndex = 43;
            this.lblSaatDurum.Text = "    ";
            // 
            // Dakika2
            // 
            this.Dakika2.Location = new System.Drawing.Point(79, 59);
            this.Dakika2.Name = "Dakika2";
            this.Dakika2.Size = new System.Drawing.Size(38, 23);
            this.Dakika2.TabIndex = 47;
            // 
            // saat2
            // 
            this.saat2.Location = new System.Drawing.Point(29, 59);
            this.saat2.Name = "saat2";
            this.saat2.Size = new System.Drawing.Size(38, 23);
            this.saat2.TabIndex = 46;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 15);
            this.label12.TabIndex = 45;
            this.label12.Text = "Dakika";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "Saat";
            // 
            // btnSaatlikDurdur
            // 
            this.btnSaatlikDurdur.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaatlikDurdur.Image = ((System.Drawing.Image)(resources.GetObject("btnSaatlikDurdur.Image")));
            this.btnSaatlikDurdur.Location = new System.Drawing.Point(180, 70);
            this.btnSaatlikDurdur.Name = "btnSaatlikDurdur";
            this.btnSaatlikDurdur.Size = new System.Drawing.Size(110, 57);
            this.btnSaatlikDurdur.TabIndex = 43;
            this.btnSaatlikDurdur.Text = "Saate Göre İşlem Durdur";
            this.btnSaatlikDurdur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaatlikDurdur.UseVisualStyleBackColor = true;
            this.btnSaatlikDurdur.Click += new System.EventHandler(this.btnSaatlikDurdur_Click);
            // 
            // Dakika1
            // 
            this.Dakika1.Location = new System.Drawing.Point(79, 30);
            this.Dakika1.Name = "Dakika1";
            this.Dakika1.Size = new System.Drawing.Size(38, 23);
            this.Dakika1.TabIndex = 42;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBox1.Location = new System.Drawing.Point(493, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(188, 19);
            this.checkBox1.TabIndex = 43;
            this.checkBox1.Text = "Saate Göre Yedek Panelini Aç";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Olive;
            this.button2.Location = new System.Drawing.Point(4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(65, 38);
            this.button2.TabIndex = 44;
            this.button2.Text = "Mail Ayarları";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(687, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.cmbYedekSayisi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CbMailGonder);
            this.Controls.Add(this.lblLastTime);
            this.Controls.Add(this.lblStartTime);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSonGorev);
            this.Controls.Add(this.lblBasla);
            this.Controls.Add(this.lblSayi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbTime);
            this.Controls.Add(this.btnTimerStop);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDestPath);
            this.Controls.Add(this.lblCopyPath);
            this.Controls.Add(this.btnYapistir);
            this.Controls.Add(this.rTxtLog);
            this.Controls.Add(this.btnKopyalaYol);
            this.Controls.Add(this.lblDosyaGonder);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.btnDosyaEkle);
            this.Controls.Add(this.rtxtIcerik);
            this.Controls.Add(this.txtKonu);
            this.Controls.Add(this.txtKime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackUp Masters";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saat1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saat3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dakika1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }






        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKonu;
        private RichTextBox rtxtIcerik;
        private Button btnDosyaEkle;
        private Button btnGonder;
        private Button btnKopyalaYol;
        private Button btnYapistir;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button btnTimerStop;
        private ComboBox cmbTime;
        private Label label5;
        private Label label6;
        private Label lblSonGorev;
        private Label lblBasla;
        private Label lblSayi;
        private Label label7;
        private Label label8;
        private Label lblStartTime;
        private Label lblLastTime;
        private CheckBox CbMailGonder;
        public RichTextBox rTxtLog;
        private Label label9;
        private ComboBox cmbYedekSayisi;
        private Label lblState;
        private Label label10;
        private Button btnSaatlikBasla;
        private System.Windows.Forms.Timer timer2;
        private NumericUpDown saat1;
        private Panel panel1;
        private Label label13;
        private CheckBox cb3islem;
        private CheckBox cb2islem;
        private CheckBox cb1islem;
        private Label lblSaatDurum;
        private NumericUpDown Dakika3;
        private NumericUpDown saat3;
        private NumericUpDown Dakika2;
        private NumericUpDown saat2;
        private Label label12;
        private Label label11;
        private Button btnSaatlikDurdur;
        private NumericUpDown Dakika1;
        private CheckBox checkBox1;
        private Label lblSaatlikDest;
        private Label lblSaatlikCopy;
        private Button btnSaatlikDestPath;
        private Button btnSaatlikSourcePath;
        public Label lblCopyPath;
        public Label lblDestPath;
        private Label lblSaatlikToplam;
        private Label lblSaatlikSonIslem;
        private Label lblSonSaat;
        public Label lblDosyaGonder;
        private Label lblSonSayi;
        public TextBox txtKime;
        private Button button2;
    }
}