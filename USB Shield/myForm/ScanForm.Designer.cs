namespace USB_Shield
{
    partial class ScanForm
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
            this.groupBoxScanForm = new System.Windows.Forms.GroupBox();
            this.btnClearList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.lstScanUSB = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxScanForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxScanForm
            // 
            this.groupBoxScanForm.Controls.Add(this.btnClearList);
            this.groupBoxScanForm.Controls.Add(this.label1);
            this.groupBoxScanForm.Controls.Add(this.btnScan);
            this.groupBoxScanForm.Controls.Add(this.lstScanUSB);
            this.groupBoxScanForm.Location = new System.Drawing.Point(12, 12);
            this.groupBoxScanForm.Name = "groupBoxScanForm";
            this.groupBoxScanForm.Size = new System.Drawing.Size(400, 181);
            this.groupBoxScanForm.TabIndex = 0;
            this.groupBoxScanForm.TabStop = false;
            this.groupBoxScanForm.Text = "Scan USB";
            // 
            // btnClearList
            // 
            this.btnClearList.Location = new System.Drawing.Point(319, 152);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(75, 23);
            this.btnClearList.TabIndex = 3;
            this.btnClearList.Text = "Clear list";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(87, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scan and delete it .";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(6, 153);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lstScanUSB
            // 
            this.lstScanUSB.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstScanUSB.FullRowSelect = true;
            this.lstScanUSB.GridLines = true;
            this.lstScanUSB.Location = new System.Drawing.Point(6, 20);
            this.lstScanUSB.Name = "lstScanUSB";
            this.lstScanUSB.Size = new System.Drawing.Size(388, 127);
            this.lstScanUSB.TabIndex = 0;
            this.lstScanUSB.UseCompatibleStateImageBehavior = false;
            this.lstScanUSB.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Path";
            this.columnHeader1.Width = 174;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 125;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "State";
            this.columnHeader3.Width = 85;
            // 
            // ScanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 205);
            this.ControlBox = false;
            this.Controls.Add(this.groupBoxScanForm);
            this.Location = new System.Drawing.Point(140, 80);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScanForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.ScanForm_Load);
            this.groupBoxScanForm.ResumeLayout(false);
            this.groupBoxScanForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxScanForm;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ListView lstScanUSB;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClearList;


    }
}