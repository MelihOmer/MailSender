using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.FilePathOperations
{
    public  class FilePaths
    {

        
        public  string SourceFilePath()
        {
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.ShowDialog();
            return fb.SelectedPath;

        }
        
    }
}
