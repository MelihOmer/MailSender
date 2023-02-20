using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace MailSender.Mail_Operations
{
    public class MailSmtp 
    {

        public MailSmtp()
        {

        }
        public MailSmtp(string attachment)
        {

        }



        RegistryKey regeditFolder = Registry.CurrentUser.CreateSubKey("BackUpMasters");

        public bool SendMail(string kime, string konu, string icerik, string mailAttachment)
        {
            string regeditHost = regeditFolder.GetValue("mailHost").ToString();
            string regeditPort = regeditFolder.GetValue("mailPort").ToString();
            string regeditMailSender = regeditFolder.GetValue("mailSender").ToString();
            string regeditPassword = regeditFolder.GetValue("mailSenderPassword").ToString();
            string regeditVisibleName = regeditFolder.GetValue("mailVisibleName").ToString();

            try
            {
                using (SmtpClient sc = new SmtpClient())
                {
                    sc.Host = regeditHost;
                    sc.Port = Convert.ToInt32(regeditPort);
                    sc.EnableSsl = true;
                    sc.Credentials = new NetworkCredential(regeditMailSender, regeditPassword);

                    MailMessage mail = new MailMessage();
                    mail.From = new MailAddress(regeditMailSender, regeditVisibleName);
                    mail.To.Add(kime);
                    mail.Subject = konu;
                    mail.IsBodyHtml = true;
                    mail.Body = icerik;
                    if (!string.IsNullOrEmpty(mailAttachment))
                    {
                        mail.Attachments.Add(new Attachment(mailAttachment));
                    }
                    sc.Send(mail);
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }



    }
}
