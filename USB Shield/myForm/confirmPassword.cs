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
    public partial class confirmPasswordForm : Form
    {
        setting_hiq setting = new setting_hiq();
        public confirmPasswordForm()
        {
            InitializeComponent();
            this.Show();
            this.BringToFront();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtConfirmPassword.Text == setting.getProperty("closePassword"))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                this.DialogResult = DialogResult.Cancel;
                MessageBox.Show("wrong password!");
            }

        }
    }
}
