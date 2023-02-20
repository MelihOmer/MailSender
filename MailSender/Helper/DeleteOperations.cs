using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.Helper
{
    public class DeleteOperations
    {

        public void DeletedOldBackUpFolder(string destFile,int maxFileLimits)
        {

            try
            {
                FileInfo[] silinecekDosya = new DirectoryInfo(destFile).GetFiles();
                if (silinecekDosya.Length > maxFileLimits)
                {
                    var file = silinecekDosya.OrderBy(O => O.CreationTime).First();
                    file.Delete();

                    var text = new Form1().rTxtLog;

                    text.ForeColor = Color.Red;
                    text.Text += $"{DateTime.Now}  ==>> {file.Name} Adında Olan Dosya Silindi... \n\n";

                } 
            }
            catch (Exception ee)
            {

                MessageBox.Show(ee.ToString());
            }

            
        }



    }
}
