using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace USB_Shield
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"http://www.facebook.com/hiethemaliraqi");
            Process.Start(@"http://www.facebook.com/hiq4info");
        }
    }
}
