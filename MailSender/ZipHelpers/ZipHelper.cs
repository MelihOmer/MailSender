using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.ZipHelpers
{
    public class ZipHelper
    {



        public ZipFile AddZipDirectory(string sourceFile,string destFile)
        {
            if (!string.IsNullOrEmpty(sourceFile) && !string.IsNullOrEmpty(destFile))
            {
                string saat = $"{DateTime.Now.Hour.ToString()}.{DateTime.Now.Minute.ToString()}.{DateTime.Now.Second.ToString()}";
                var files = new FileInfo(sourceFile);
                if (files != null)
                {
                    string path = Path.Combine(destFile, $"{files.Name} {DateTime.Now.ToShortDateString()} {saat}.zip");

                    ZipFile zip = new ZipFile();
                    zip.AddDirectory(sourceFile);
                    zip.Save(path);
                    return zip;
                }
                

                
            }
            return null;
        }
    }

}

