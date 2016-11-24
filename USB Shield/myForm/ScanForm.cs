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

namespace USB_Shield
{
    public partial class ScanForm : Form
    {
        setting_hiq setting = new setting_hiq();
        DirectoryInfo dir;
        public ScanForm()
        {
            InitializeComponent();
        }
        public void scan()
        {
            try
            {
                this.scanFiles();
                this.scanFolder();
            }
            catch (Exception ex) { MessageBox.Show("Error : 0x001\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        public void listViewItem(string path, string type)
        {
            ListViewItem lvi = new ListViewItem(path);
            lvi.SubItems.Add(type);
            if (Directory.Exists(path) || File.Exists(path))
            {
                lvi.SubItems.Add("Not deleted");
            }
            else
            {
                lvi.SubItems.Add("Deleted");
            }
            this.lstScanUSB.Items.Add(lvi);
        }
        private void scanFiles()
        {
            lstScanUSB.Items.Clear();
            try
            {
                string str1, str2, str3, str4, str5;
                str1 = setting.driverLabel();
                for (int i = 0; i < str1.Length; i += 2)
                {
                    dir = new DirectoryInfo(str1[i]+":");
                    foreach (FileInfo myfile in dir.GetFiles())
                    {
                        if (myfile.Name == "autorun.inf" || myfile.Name.Contains(".lnk"))
                        {
                            if (myfile.Name == "autorun.inf")
                            {
                                StreamReader sr = new StreamReader(myfile.FullName);
                                str2 = sr.ReadToEnd();
                                sr.Close();
                                if (str2.Contains("open"))
                                {
                                    str3 = str2.Substring(str2.IndexOf("open") + 5);
                                    str4 = str3.Substring(0, str3.IndexOf(".") + 4);//worm name
                                    str5 = myfile.FullName.Substring(0, myfile.FullName.IndexOf("autorun.inf"));//path of folder that content worm
                                    File.Delete(str5 + str4);
                                    listViewItem(str5 + str4, "Worm");
                                }
                            }
                            myfile.Delete();
                            listViewItem(myfile.FullName, "Autorun");
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error : 0x002\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void scanFolder()
        {
            try
            {
                string str1;
                str1 = setting.driverLabel();
                for (int i = 0; i < str1.Length; i += 2)
                {
                    dir = new DirectoryInfo(str1[i] + ":");
                    foreach (DirectoryInfo myfolder in dir.GetDirectories())
                    {
                        if (myfolder.Name == "recycler")
                        {
                            Directory.Delete(myfolder.FullName, true);
                            listViewItem(myfolder.FullName, "Worm's Temporary");
                        }
                        foreach (FileInfo myfile in dir.GetFiles())
                        {
                            if (myfile.Name.Contains(myfolder.Name) && myfile.Name.Contains(".exe"))
                            {
                                myfile.Delete();
                                listViewItem(myfile.FullName, "Risk File");
                                
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Error : 0x003\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
       
        }
        private void ScanForm_Load(object sender, EventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            scan();
        }

        private void btnClearList_Click(object sender, EventArgs e)
        {
            this.lstScanUSB.Items.Clear();
        }
    }
}