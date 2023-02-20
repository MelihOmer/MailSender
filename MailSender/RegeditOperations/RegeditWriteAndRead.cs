using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailSender.RegeditOperations
{
    public static class RegeditWriteAndRead
    {
        static RegistryKey regeditFolder = Registry.CurrentUser.CreateSubKey("BackUpMasters");
        


        public static string CheckMailReceiverValue()
        {
            string regeditValue = regeditFolder.GetValue("mailReceiver").ToString();

            if (!String.IsNullOrEmpty(regeditValue))
            {
                return regeditValue;
            }
            return null;
        }
        public static void SetMailReceiverValue(string value)
        {
            regeditFolder.SetValue("mailReceiver",value);
        }



        public static string[] CheckMailSenderValue()
        {
            string regeditHost = regeditFolder.GetValue("mailHost").ToString();
            string regeditPort = regeditFolder.GetValue("mailPort").ToString();
            string regeditMailSender = regeditFolder.GetValue("mailSender").ToString();
            string regeditPassword = regeditFolder.GetValue("mailSenderPassword").ToString();
            string regeditVisibleName = regeditFolder.GetValue("mailVisibleName").ToString();
            int Check = 0;
            string[] values = new string[5];
            if (!String.IsNullOrEmpty(regeditHost) && !String.IsNullOrEmpty(regeditPort) && !String.IsNullOrEmpty(regeditMailSender) && !String.IsNullOrEmpty(regeditPassword) && !String.IsNullOrEmpty(regeditVisibleName))
            {
                values[0] = regeditHost;
                values[1] = regeditPort;
                values[2] = regeditMailSender;
                values[3] = regeditPassword;
                values[4] = regeditVisibleName;
            }
            
            for (int i = 0; i < values.Count(); i++)
            {
                if (!String.IsNullOrEmpty(values[i]))
                {
                    Check  = Check+1;
                }
                
            }
            //if (Check <5)
            //{
            //    return null;
            //}
            return values;
        }
        public static void SetMailSenderValue(string _regeditHost,string _regeditPort,string _regeditMailSender,string _regeditPassword,string _regeditVisibleName)
        {
            regeditFolder.SetValue("mailHost", _regeditHost);
            regeditFolder.SetValue("mailPort", _regeditPort );
            regeditFolder.SetValue("mailSender", _regeditMailSender );
            regeditFolder.SetValue("mailSenderPassword",_regeditPassword );
            regeditFolder.SetValue("mailVisibleName", _regeditVisibleName );
        }



    }
}
