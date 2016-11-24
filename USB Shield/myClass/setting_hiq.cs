using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Win32;


namespace USB_Shield
{
    class setting_hiq
    {
        string[] driversLabelArray = new string[] { "a:", "b:", "c:", "d:", "e:", "f:", "g:", "h:", "i:", "j:", "k:", "l:", "m:", "n:", "o:", "p:", "q:", "r:", "s:", "t:", "u:", "v:", "w:", "x:", "y:", "z:" };
        string str1 = "", str2, str3,str4;
        DriveInfo di;
        //constructor of setting 
        public setting_hiq()
        {
            StreamReader sr = new StreamReader("setting.hiq");
            str4 = sr.ReadToEnd();
            sr.Close();

            if (!str4.Contains("=") || !str4.Contains(";"))
            {
                MessageBox.Show("Unplug any USB form compter before press ok");
                //autostart
                RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Run", true);
                key.SetValue("USB_Shield",@"c:\Hiethem Aliraqi\USB Shield\USB Shield.exe");
                key.Close();
                //
                insertProperty("numberOfDrivers", Convert.ToString(numberOfDrivers()));
                insertProperty("driverLabel", driverLabel());
            }
           
        }
        public int numberOfDrivers()
        {
            try
            {
                str1 = "";
                foreach (string s in driversLabelArray)
                {
                    di = new DriveInfo(s);
                    if (di.IsReady && di.DriveType != DriveType.Removable)
                    {
                        str1 += s;
                    }
                }
                return (str1.Length / 2);
            }
            catch (Exception ex) { MessageBox.Show("Error:0x004\n" + ex.Message); return 0; }

        }
        public string driverLabel() 
        {
            try
            {
                foreach (string str2 in driversLabelArray)
                {
                    di = new DriveInfo(str2);
                    if (di.IsReady)
                    {
                        str3 += str2;
                    }
                }
                return str3;
            }
            catch (Exception ex) { MessageBox.Show("Error:0x005\n" + ex.Message); return ""; }
        }
        public void insertProperty(string var, string val)
        {
            try
            {
                if (File.Exists("setting.hiq"))
                {
                    FileStream fs1 = new FileStream("setting.hiq", FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs1);
                    sw.Write(var + "=" + val + ";" + Environment.NewLine);
                    sw.Close();

                }
            }
            catch (Exception ex) { MessageBox.Show("Error:0x006\n" + ex.Message); }
        }
        public string getProperty(string var)
        {
            try
            {
                if (File.Exists("setting.hiq"))
                {
                    FileStream fs2 = new FileStream("setting.hiq", FileMode.Open);
                    StreamReader sr = new StreamReader(fs2);
                    str1 = sr.ReadToEnd();
                    str2 = str1.Substring(str1.IndexOf(var) + (var.Length) + 1);
                    str3 = str2.Substring(0, str2.IndexOf(";"));
                    sr.Close();
                }
                return str3;
            }
            catch (Exception ex) { MessageBox.Show("Error:0x007\n" + ex.Message); return ""; }
        }
    }
}
