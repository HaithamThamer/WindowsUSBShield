/***********************************************************************************************************
 * 
 * Project name :   USB Shield
 * Description  :   to protect your pc form USB prot
 * Version      :   0.4 beta
 * Modifired at :   29/11/2013
 * 
 * Author       :   Hiethem Aliraqi
 * Contact      :   www.facebook.com/hiethemaliraqi
 * Mobile       :   009647703867142
 * 
 ************************************************************************************************************/
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
    public partial class Home : Form
    {
        // declare object from the another forms to access them
        ScanForm sf = new ScanForm();
        toolsForm tf = new toolsForm();
        aboutForm af = new aboutForm();
        homeContent hc = new homeContent();
        setting_hiq setting = new setting_hiq();
        public Home()
        {
            InitializeComponent();
            this.notifyMain.Icon = this.Icon;
            this.notifyMain.ShowBalloonTip(1, "USB Shield", "USB Shield is running now and protected your PC", ToolTipIcon.Info);
            hc.Show();
            hc.BringToFront();
            hc.MdiParent = this;
        }

        private void btnClose_Click(object sender, EventArgs e) // to hide program but it is running in background
        {
            this.Opacity = 0;
        }

        private void btnScanUSB_Click(object sender, EventArgs e)
        {
            sf.Show();
            sf.BringToFront();
            sf.MdiParent = this;
        }
        private void btnTools_Click(object sender, EventArgs e)
        {
            tf.Show();
            tf.BringToFront();
            tf.MdiParent = this;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            af.Show();
            af.BringToFront();
            af.MdiParent = this;

        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str;
            StreamReader sr = new StreamReader("setting.hiq");
            str = sr.ReadToEnd();
            sr.Close();
            if (str.Contains("closePassword"))
            {
                confirmPasswordForm cpf = new confirmPasswordForm();
                cpf.Visible = false;
                DialogResult dr = cpf.ShowDialog();
                if ( dr == DialogResult.OK) this.Close();
            } 
            else
            {
                this.Close(); // to close the program
            }
            
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            hc.Show();
            hc.BringToFront();
            hc.MdiParent = this;
        }

        private void timerForNewDrivers_Tick(object sender, EventArgs e)
        {
            
            if (Convert.ToInt32(setting.numberOfDrivers()) > Convert.ToInt32(setting.getProperty("numberOfDrivers")))
            {
                sf.Show();
                sf.BringToFront();
                sf.MdiParent = this;
                sf.scan();
                tf.fixFolder();
                timerForNewDrivers.Enabled = false;
            }
            else
            {
                timerForNewDrivers.Enabled = true;
            }
            
        }
        public void showMyProgram()
        {
            this.Opacity = 100;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
            this.BringToFront();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Opacity = 100;
            af.Show();
            af.BringToFront();
            af.MdiParent = this;
        }
    }
}
