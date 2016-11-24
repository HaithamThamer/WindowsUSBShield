using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace USB_Shield
{
    public partial class setPasswordForm : Form
    {
        setting_hiq setting = new setting_hiq();
        public setPasswordForm()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == string.Empty)
            {
                MessageBox.Show("It's empty");
            }
            else
            {
                if (txtPassword.Text != txtConfirm.Text)
                {
                    MessageBox.Show("Not Matched");
                }
                else 
                {
                    setting.insertProperty("closePassword", txtPassword.Text);
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("Password was set");
                    this.Close();
                }
            }
        }
    }
}
