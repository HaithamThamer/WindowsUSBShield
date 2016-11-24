namespace USB_Shield
{
    partial class toolsForm
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
            this.groupBoxToolsForm = new System.Windows.Forms.GroupBox();
            this.comboBoxRemovable = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFixHidenFolder = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSetPassword = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape3 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.groupBoxToolsForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxToolsForm
            // 
            this.groupBoxToolsForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxToolsForm.Controls.Add(this.comboBoxRemovable);
            this.groupBoxToolsForm.Controls.Add(this.label4);
            this.groupBoxToolsForm.Controls.Add(this.btnFixHidenFolder);
            this.groupBoxToolsForm.Controls.Add(this.label3);
            this.groupBoxToolsForm.Controls.Add(this.label1);
            this.groupBoxToolsForm.Controls.Add(this.btnSetPassword);
            this.groupBoxToolsForm.Controls.Add(this.shapeContainer1);
            this.groupBoxToolsForm.Location = new System.Drawing.Point(13, 13);
            this.groupBoxToolsForm.Name = "groupBoxToolsForm";
            this.groupBoxToolsForm.Size = new System.Drawing.Size(400, 181);
            this.groupBoxToolsForm.TabIndex = 0;
            this.groupBoxToolsForm.TabStop = false;
            this.groupBoxToolsForm.Text = "Tools";
            // 
            // comboBoxRemovable
            // 
            this.comboBoxRemovable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRemovable.FormattingEnabled = true;
            this.comboBoxRemovable.Location = new System.Drawing.Point(6, 73);
            this.comboBoxRemovable.Name = "comboBoxRemovable";
            this.comboBoxRemovable.Size = new System.Drawing.Size(69, 21);
            this.comboBoxRemovable.TabIndex = 9;
            this.comboBoxRemovable.SelectedIndexChanged += new System.EventHandler(this.comboBoxRemovable_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "show hiden folder in the USB";
            // 
            // btnFixHidenFolder
            // 
            this.btnFixHidenFolder.Location = new System.Drawing.Point(81, 72);
            this.btnFixHidenFolder.Name = "btnFixHidenFolder";
            this.btnFixHidenFolder.Size = new System.Drawing.Size(150, 21);
            this.btnFixHidenFolder.TabIndex = 7;
            this.btnFixHidenFolder.Text = "Fix Hiden Folder";
            this.btnFixHidenFolder.UseVisualStyleBackColor = true;
            this.btnFixHidenFolder.Click += new System.EventHandler(this.btnFixHidenFolder_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.Location = new System.Drawing.Point(17, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "to more security for your PC , do not allow another one close this program.";
            // 
            // btnSetPassword
            // 
            this.btnSetPassword.Location = new System.Drawing.Point(7, 20);
            this.btnSetPassword.Name = "btnSetPassword";
            this.btnSetPassword.Size = new System.Drawing.Size(387, 23);
            this.btnSetPassword.TabIndex = 0;
            this.btnSetPassword.Text = "Set Password";
            this.btnSetPassword.UseVisualStyleBackColor = true;
            this.btnSetPassword.Click += new System.EventHandler(this.btnSetPassword_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(3, 16);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape3,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(394, 162);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape3
            // 
            this.lineShape3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape3.BorderColor = System.Drawing.Color.Silver;
            this.lineShape3.Name = "lineShape3";
            this.lineShape3.X1 = 0;
            this.lineShape3.X2 = 394;
            this.lineShape3.Y1 = 82;
            this.lineShape3.Y2 = 82;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.Color.Silver;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = -3;
            this.lineShape1.X2 = 391;
            this.lineShape1.Y1 = 46;
            this.lineShape1.Y2 = 46;
            // 
            // toolsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 205);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxToolsForm);
            this.Location = new System.Drawing.Point(140, 80);
            this.Name = "toolsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.groupBoxToolsForm.ResumeLayout(false);
            this.groupBoxToolsForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxToolsForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetPassword;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFixHidenFolder;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape3;
        private System.Windows.Forms.ComboBox comboBoxRemovable;
    }
}