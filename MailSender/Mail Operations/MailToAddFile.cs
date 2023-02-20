using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Mail_Operations
{
    public class MailToAddFile
    {

        public string AddToFileForMail()
        {
            OpenFileDialog files = new OpenFileDialog();
            files.Title = "Attachment";
            files.ShowDialog();
            return  files.FileName;
              
        }


    }
}
