using MailSender.RegeditOperations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailSender
{
    public partial class MailInfo : Form
    {
        public MailInfo()
        {
            InitializeComponent();
        }
        //string host = RegeditWriteAndRead.CheckMailSenderValue()[0].ToString();
        //string port = RegeditWriteAndRead.CheckMailSenderValue()[1].ToString();
        //string mailAdress = RegeditWriteAndRead.CheckMailSenderValue()[2].ToString();
        //string password = RegeditWriteAndRead.CheckMailSenderValue()[3].ToString();
        //string visibleName = RegeditWriteAndRead.CheckMailSenderValue()[4].ToString();
        private void MailInfo_Load(object sender, EventArgs e)
        {

            txtHost.Enabled = false;
            txtPort.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtHost.Text) || String.IsNullOrEmpty(txtPort.Text) || String.IsNullOrEmpty(txtMailAdresi.Text) || String.IsNullOrEmpty(txtSifre.Text) || String.IsNullOrEmpty(txtGorunenAd.Text))
            {
                MessageBox.Show("Tüm Alanları Doldurunuz...");
            }
            else
            {
                RegeditWriteAndRead.SetMailSenderValue(txtHost.Text, txtPort.Text, txtMailAdresi.Text, txtSifre.Text, txtGorunenAd.Text);
                MessageBox.Show("İşlem Tamamlandı. Ana Ekrana Dönüp 'Yedek Durumunu Mail Gönder' Seçeneğini İşaretleyiniz.");
                
            }
        }

        private void AutoMailInfoSet()
        {

            txtHost.Text = RegeditWriteAndRead.CheckMailSenderValue()[0].ToString();
            txtPort.Text = RegeditWriteAndRead.CheckMailSenderValue()[1].ToString();
            txtMailAdresi.Text = RegeditWriteAndRead.CheckMailSenderValue()[2].ToString();
            txtSifre.Text = RegeditWriteAndRead.CheckMailSenderValue()[3].ToString();
            txtGorunenAd.Text = RegeditWriteAndRead.CheckMailSenderValue()[4].ToString();
        }

        private void cBHost_CheckedChanged(object sender, EventArgs e)
        {
            if (cBHost.Checked)
            {
                txtHost.Enabled = true;
            }
            else
            {
                txtHost.Enabled = false;
            }
        }

        private void cBPort_CheckedChanged(object sender, EventArgs e)
        {
            if (cBPort.Checked)
            {
                txtPort.Enabled = true;
            }
            else
            {
                txtPort.Enabled = false;
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            AutoMailInfoSet();
        }
    }
}
