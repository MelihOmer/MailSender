using Ionic.Zip;
using MailSender.FilePathOperations;
using MailSender.Helper;
using MailSender.Mail_Operations;
using MailSender.RegeditOperations;
using MailSender.ZipHelpers;
using Microsoft.Win32;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Net.Mail;
using ZipFile = Ionic.Zip.ZipFile;

namespace MailSender
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        string sourceFile = "";
        string destFile = "";
        string saatlikSourceFile = "";
        string saatlikDestFile = "";
        MailSmtp mail = new MailSmtp();
        int alinanYedek = 0;
        int saatlikAlinanYedek = 0;
        ZipHelper zipHlp = new ZipHelper();
        DeleteOperations deleteHelper = new DeleteOperations();
        FilePaths filepath = new();
        MailToAddFile addFileForMail = new();

        private void Form1_Load(object sender, EventArgs e)
        {

            lblSaatDurum.BackColor = Color.Red;
            lblState.BackColor = Color.Red;
            rTxtLog.Width = 743;
            panel1.Visible = false;
            timer2.Interval = 1000;

            #region saatlikIslemChecked
            if (!cb1islem.Checked)
            {
                saat1.Enabled = false;
                Dakika1.Enabled = false;
            }
            if (!cb2islem.Checked)
            {
                saat2.Enabled = false;
                Dakika2.Enabled = false;
            }
            if (!cb3islem.Checked)
            {
                saat3.Enabled = false;
                Dakika3.Enabled = false;
            }
            #endregion

            #region saatlikBaslaDurdur
            btnSaatlikDurdur.Enabled = false;
            #endregion

            txtKime.Text = RegeditWriteAndRead.CheckMailReceiverValue();








            #region tutulacakYedekSayisi
            int[] sayilar = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            for (int i = 1; i < sayilar.Length + 1; i++)
            {
                cmbYedekSayisi.Items.Add(i);
            }
            cmbYedekSayisi.SelectedItem = sayilar[1];
            #endregion


            CbMailGonder.Checked = false;
            btnTimerStop.Enabled = false;

            #region comboBoxDoldur
            cmbTime.Items.Add("Her gün tekrar et");
            cmbTime.Items.Add("Her saat tekrar et");
            cmbTime.Items.Add("Her dakika tekrar et");
            cmbTime.Items.Add("Her 5 dakika'da tekrar et");
            cmbTime.Items.Add("Her 3 Saatte tekrar et");
            cmbTime.SelectedIndex = 2;
            #endregion

            #region MailKontroller
            if (!CbMailGonder.Checked)
            {
                txtKime.Enabled = false;
                txtKonu.Enabled = false;
                rtxtIcerik.Enabled = false;
            }
            #endregion



        }
        string mailAttechment = "";
        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            mailAttechment = addFileForMail.AddToFileForMail();
            lblDosyaGonder.Text = $"{mailAttechment} Eklendi...";
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {



            bool mailStatus = mail.SendMail(txtKime.Text, txtKonu.Text, rtxtIcerik.Text, mailAttechment);
            rTxtLog.Text += $"{txtKime.Text} Adli postaya MAÝL Gönderildi -- -- {DateTime.Now} \n\n";
            MessageBox.Show(Text = $"Baþarýlý -- Mail Gönder Method Deðer = {mailStatus.ToString()}");
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            sourceFile = filepath.SourceFilePath();
            lblCopyPath.Text = sourceFile;
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            destFile = filepath.SourceFilePath();
            lblDestPath.Text = destFile;
        }

        private async void timer1_Tick(object sender, EventArgs e)
        {

            RegeditWriteAndRead.SetMailReceiverValue(txtKime.Text);

            deleteHelper.DeletedOldBackUpFolder(destFile, Convert.ToInt32(cmbYedekSayisi.Text));
            try
            {

                await Task.Run(() =>
                {
                    var zipInfo = zipHlp.AddZipDirectory(sourceFile, destFile);
                    FileInfo info = new(zipInfo.Name);
                    if (CbMailGonder.Checked)
                    {


                        mail.SendMail(txtKime.Text, $"{txtKonu.Text}",
                      $"Yedekleme Tarihi = {DateTime.Now.ToString()} => Dosya Boyutu = {info.Length / 1024 / 1024}KB-- ",
                      mailAttechment);
                    }


                });
                rTxtLog.Text += $"{DateTime.Now}  ==>> {destFile} Yoluna Yedek Oluþturuldu...\n\n";
                alinanYedek++;
                lblSayi.Text = alinanYedek.ToString();
                lblLastTime.Text = $" = {DateTime.Now.ToString()}";
                if (CbMailGonder.Checked)
                {
                    rTxtLog.Text += $"{DateTime.Now}  ==>>  {cmbTime.Text} Zaman Aralýðýnda {txtKime.Text} Kiþisine Yedek Bilgileri Gönderildi... \n\n";
                }
                rTxtLog.ForeColor = Color.Green;

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {



            try
            {
                if (cmbTime.Text != null && cmbTime.Text != string.Empty)
                {

                    rTxtLog.Text += $"{DateTime.Now}  ==>>  Yedekleme Operasyonu Baþladý... \n\n";
                    timer1_Tick(sender, e);
                    timer1.Start();
                    button1.Enabled = false;
                    btnTimerStop.Enabled = true;
                    lblStartTime.Text = $" = {DateTime.Now.ToString()}";
                    if (CbMailGonder.Checked)
                    {

                        rTxtLog.Text += $"{DateTime.Now.ToString()} ==>> Yedek Bilgileri Mail Olarak Gönderimi Baþladý... \n\n";
                    }
                    else
                    {
                        rTxtLog.Text += $"{DateTime.Now.ToString()} ==>> Yedek Bilgileri Mail Olarak Gönderilmeyecektir... \n\n";
                    }
                    lblState.BackColor = Color.Green;
                }
            }
            catch (Exception error)
            {


                button1.Enabled = true;
                btnTimerStop.Enabled = false;
                MessageBox.Show($"Ýþlem Baþarýsýz.{error.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblState.BackColor = Color.Red;
            }





        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {

            timer1.Stop();

            rTxtLog.Text += $"{DateTime.Now}  ==>>  Yedek Operasyonu Durduruldu... \n\n";
            button1.Enabled = true;
            btnTimerStop.Enabled = false;
            lblState.BackColor = Color.Red;
            lblSayi.Text = 0.ToString();

        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            int interval = 0;

            if (cmbTime.SelectedIndex == 0)
            {
                interval = 86400000;
            }
            if (cmbTime.SelectedIndex == 1)
            {
                interval = 3600000;
            }
            if (cmbTime.SelectedIndex == 2)
            {
                interval = 60000;
            }
            if (cmbTime.SelectedIndex == 3)
            {
                interval = 300000;
            }
            if (cmbTime.SelectedIndex == 4)
            {
                interval = 10800000;
            }

            timer1.Interval = interval;

        }

        private void CbMailGonder_CheckedChanged(object sender, EventArgs e)
        {


            if (CbMailGonder.Checked)
            {
                txtKime.Enabled = true;
                txtKonu.Enabled = true;
                rTxtLog.Enabled = true;
                rtxtIcerik.Enabled = true;
            }
            else
            {
                txtKime.Enabled = false;
                txtKonu.Enabled = false;
                rTxtLog.Enabled = false;
                rtxtIcerik.Enabled = false;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer2_Tick(sender, e);
            timer2.Start();
            btnSaatlikBasla.Enabled = false;
            btnSaatlikDurdur.Enabled = true;
            lblSaatDurum.BackColor = Color.Green;
            rTxtLog.Text += $"LogDate = {DateTime.Now}  /==>> Zamanlanmýþ Yedek Operasyonu Baþladý... Aayarlarý Tekrar Düzenlemek için Görevi Durdurup Ayarlarý Düzenleyip Tekrar Baþlatýn... \n\n";
            if (CbMailGonder.Checked)
            {
                rTxtLog.Text += $"LogDate = {DateTime.Now}  /==>>Yedek Bilgileri Mail Olarak Göndeirlecektir...";
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            RegeditWriteAndRead.SetMailReceiverValue(txtKime.Text);


            deleteHelper.DeletedOldBackUpFolder(saatlikDestFile, Convert.ToInt32(cmbYedekSayisi.Text));
            if (cb1islem.Checked && DateTime.Now.Hour == saat1.Value && DateTime.Now.Minute == Dakika1.Value && DateTime.Now.Second == 01)
            {
                var file = zipHlp.AddZipDirectory(saatlikSourceFile, saatlikDestFile);
                var fileInfo = new FileInfo(file.Name);
                if (CbMailGonder.Checked)
                {
                    mail.SendMail(txtKime.Text, txtKonu.Text, $"{rtxtIcerik.Text} //Dosya Boyutu => {fileInfo.Length / 1024 / 1024}MB", mailAttechment);
                }
                saatlikAlinanYedek++;
                lblSonSayi.Text = saatlikAlinanYedek.ToString();
                lblSonSaat.Text = DateTime.Now.ToString();
                rTxtLog.Text += $"LogDate = {DateTime.Now}  /==>> {saat1.Value}:{Dakika1.Value} - {fileInfo.Length / 1024 / 1024}MB  Boyutunda {saatlikDestFile} Yoluna Yedek Alýndý... \n\n";
            }

            if (cb2islem.Checked && DateTime.Now.Hour == saat2.Value && DateTime.Now.Minute == Dakika2.Value && DateTime.Now.Second == 03)
            {
                var file = zipHlp.AddZipDirectory(saatlikSourceFile, saatlikDestFile);
                var fileInfo = new FileInfo(file.Name);
                if (CbMailGonder.Checked)
                {
                    mail.SendMail(txtKime.Text, txtKonu.Text, $"{rtxtIcerik.Text} //Dosya Boyutu => {fileInfo.Length / 1024 / 1024}MB", mailAttechment);
                }
                saatlikAlinanYedek++;
                lblSonSayi.Text = saatlikAlinanYedek.ToString();
                lblSonSaat.Text = DateTime.Now.ToString();
                rTxtLog.Text += $"LogDate = {DateTime.Now}  /==>> {saat1.Value}:{Dakika1.Value} - {fileInfo.Length / 1024 / 1024}MB  Boyutunda {saatlikDestFile} Yoluna Yedek Alýndý... \n\n";
            }

            if (cb3islem.Checked && DateTime.Now.Hour == saat3.Value && DateTime.Now.Minute == Dakika3.Value && DateTime.Now.Second == 05)
            {
                var file = zipHlp.AddZipDirectory(saatlikSourceFile, saatlikDestFile);
                var fileInfo = new FileInfo(file.Name);
                if (CbMailGonder.Checked)
                {
                    mail.SendMail(txtKime.Text, txtKonu.Text, $"{rtxtIcerik.Text} //Dosya Boyutu => {fileInfo.Length / 1024 / 1024}MB", mailAttechment);
                }
                saatlikAlinanYedek++;
                lblSonSayi.Text = saatlikAlinanYedek.ToString();
                lblSonSaat.Text = DateTime.Now.ToString();
                rTxtLog.Text += $"LogDate = {DateTime.Now}  /==>> {saat1.Value}:{Dakika1.Value} - {fileInfo.Length / 1024 / 1024}MB  Boyutunda {saatlikDestFile} Yoluna Yedek Alýndý... \n\n";
            }
        }

        private void cb1islem_CheckedChanged(object sender, EventArgs e)
        {
            if (cb1islem.Checked)
            {
                saat1.Enabled = true;
                Dakika1.Enabled = true;
            }
            else
            {
                saat1.Enabled = false;
                Dakika1.Enabled = false;
            }
        }

        private void cb2islem_CheckedChanged(object sender, EventArgs e)
        {
            if (cb2islem.Checked)
            {
                saat2.Enabled = true;
                Dakika2.Enabled = true;
            }
            else
            {
                saat2.Enabled = false;
                Dakika2.Enabled = false;
            }
        }

        private void cb3islem_CheckedChanged(object sender, EventArgs e)
        {

            if (cb3islem.Checked)
            {
                saat3.Enabled = true;
                Dakika3.Enabled = true;
            }
            else
            {
                saat3.Enabled = false;
                Dakika3.Enabled = false;
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel1.Visible = true;
                ActiveForm.Width = 1012;
                rTxtLog.Width = 984;
            }
            else
            {
                panel1.Visible = false;
                ActiveForm.Width = 703;
                rTxtLog.Width = 677;
            }
        }



        private void btnSaatlikDurdur_Click(object sender, EventArgs e)
        {
            saatlikAlinanYedek = 0;


            btnSaatlikBasla.Enabled = true;
            btnSaatlikDurdur.Enabled = false;
            timer2.Stop();
            lblSaatDurum.BackColor = Color.Red;
            rTxtLog.Text += $"LogDate = {DateTime.Now}  /==>> Zamanlanmýþ Yedek Operasyonu Durduruldu... Aayarlarý Tekrar Düzenlemek için Görevi Durdurup Ayarlarý Düzenleyip Tekrar Baþlatýn... \n\n";
            if (CbMailGonder.Checked)
            {
                rTxtLog.Text += $"LogDate = {DateTime.Now}  /==>>Yedek Bilgileri Mail Gönderme Operasyonu Durmuþtur....";
            }
        }
        private void btnSaatlikSourcePath_Click(object sender, EventArgs e)
        {
            saatlikSourceFile = filepath.SourceFilePath();
            lblSaatlikCopy.Text = saatlikSourceFile;
        }

        private void btnSaatlikDestPath_Click(object sender, EventArgs e)
        {
            saatlikDestFile = filepath.SourceFilePath();
            lblSaatlikDest.Text = saatlikDestFile;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            new MailInfo().Show();
        }
    }
}
