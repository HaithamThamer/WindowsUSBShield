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
    public partial class toolsForm : Form
    {
        setting_hiq setting = new setting_hiq();
        public toolsForm()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("setting.hiq");
            string str = sr.ReadToEnd();
            sr.Close();
            if (str.Contains("closePassword")) this.btnSetPassword.Enabled = false;
        }
        public void fixFolder() 
        {
            comboBoxRemovable.Items.Clear();
            string str0 = setting.driverLabel();
            DriveInfo di;
            for (int i = 0; i < str0.Length; i += 2)
            {
                di = new DriveInfo(str0[i] + ":");
                if (di.IsReady && di.DriveType == DriveType.Removable)
                {
                    comboBoxRemovable.Items.Add(str0[i] + ":");
                }
            }
        }
        private void btnSetPassword_Click(object sender, EventArgs e)
        {
            setPasswordForm spf = new setPasswordForm();
            spf.Visible = false;
            DialogResult dr = spf.ShowDialog();
            if (dr == DialogResult.OK) this.btnSetPassword.Enabled = false;
        }

        private void comboBoxRemovable_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFixHidenFolder_Click(object sender, EventArgs e)
        {
            try
            {
                string rootUSB = comboBoxRemovable.SelectedItem.ToString();
                foreach (string mydir in Directory.GetDirectories(rootUSB))
                {
                    if(mydir.Contains("$RECYCLE.BIN") || mydir.Contains("System Volume Information"))continue;
                    File.SetAttributes(mydir, FileAttributes.Normal);
                }
                MessageBox.Show("Done");
            }
            catch (System.NullReferenceException) { MessageBox.Show("Choose USB drive"); }
            catch (Exception ex) { MessageBox.Show("Error:0x008\n" + ex.Message); }
        }
    }
}
