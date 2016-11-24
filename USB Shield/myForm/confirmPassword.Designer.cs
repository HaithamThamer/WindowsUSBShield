namespace USB_Shield
{
    partial class confirmPasswordForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxConfirmPassword = new System.Windows.Forms.GroupBox();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.groupBoxConfirmPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxConfirmPassword
            // 
            this.groupBoxConfirmPassword.Controls.Add(this.btnConfirm);
            this.groupBoxConfirmPassword.Controls.Add(this.txtConfirmPassword);
            this.groupBoxConfirmPassword.Location = new System.Drawing.Point(13, 13);
            this.groupBoxConfirmPassword.Name = "groupBoxConfirmPassword";
            this.groupBoxConfirmPassword.Size = new System.Drawing.Size(259, 51);
            this.groupBoxConfirmPassword.TabIndex = 0;
            this.groupBoxConfirmPassword.TabStop = false;
            this.groupBoxConfirmPassword.Text = "Confirm Password";
            // 
            // btnConfirm
            // 
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnConfirm.Location = new System.Drawing.Point(175, 20);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(78, 20);
            this.btnConfirm.TabIndex = 1;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(7, 20);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(162, 20);
            this.txtConfirmPassword.TabIndex = 0;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // confirmPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 73);
            this.Controls.Add(this.groupBoxConfirmPassword);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "confirmPasswordForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USB Shield | Confirm Password";
            this.groupBoxConfirmPassword.ResumeLayout(false);
            this.groupBoxConfirmPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxConfirmPassword;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtConfirmPassword;
    }
}