namespace Demo3
{
    partial class Form1
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
            this.lblNL = new System.Windows.Forms.Label();
            this.lblNLvalue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCDvalue = new System.Windows.Forms.Label();
            this.lblTBvalue = new System.Windows.Forms.Label();
            this.lblCBvalue = new System.Windows.Forms.Label();
            this.cboMon1 = new System.Windows.Forms.ComboBox();
            this.cboMon2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblNL
            // 
            this.lblNL.AutoSize = true;
            this.lblNL.Location = new System.Drawing.Point(37, 138);
            this.lblNL.Name = "lblNL";
            this.lblNL.Size = new System.Drawing.Size(68, 13);
            this.lblNL.TabIndex = 0;
            this.lblNL.Text = "Năng lượng: ";
            // 
            // lblNLvalue
            // 
            this.lblNLvalue.AutoSize = true;
            this.lblNLvalue.Location = new System.Drawing.Point(130, 138);
            this.lblNLvalue.Name = "lblNLvalue";
            this.lblNLvalue.Size = new System.Drawing.Size(35, 13);
            this.lblNLvalue.TabIndex = 1;
            this.lblNLvalue.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chất đạm: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Chất béo: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tinh bột:";
            // 
            // lblCDvalue
            // 
            this.lblCDvalue.AutoSize = true;
            this.lblCDvalue.Location = new System.Drawing.Point(130, 171);
            this.lblCDvalue.Name = "lblCDvalue";
            this.lblCDvalue.Size = new System.Drawing.Size(35, 13);
            this.lblCDvalue.TabIndex = 1;
            this.lblCDvalue.Text = "label1";
            // 
            // lblTBvalue
            // 
            this.lblTBvalue.AutoSize = true;
            this.lblTBvalue.Location = new System.Drawing.Point(130, 227);
            this.lblTBvalue.Name = "lblTBvalue";
            this.lblTBvalue.Size = new System.Drawing.Size(35, 13);
            this.lblTBvalue.TabIndex = 1;
            this.lblTBvalue.Text = "label1";
            // 
            // lblCBvalue
            // 
            this.lblCBvalue.AutoSize = true;
            this.lblCBvalue.Location = new System.Drawing.Point(130, 198);
            this.lblCBvalue.Name = "lblCBvalue";
            this.lblCBvalue.Size = new System.Drawing.Size(35, 13);
            this.lblCBvalue.TabIndex = 1;
            this.lblCBvalue.Text = "label1";
            // 
            // cboMon1
            // 
            this.cboMon1.FormattingEnabled = true;
            this.cboMon1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboMon1.Location = new System.Drawing.Point(40, 34);
            this.cboMon1.Name = "cboMon1";
            this.cboMon1.Size = new System.Drawing.Size(121, 21);
            this.cboMon1.TabIndex = 2;
            this.cboMon1.SelectedIndexChanged += new System.EventHandler(this.CboMon1_SelectedIndexChanged);
            // 
            // cboMon2
            // 
            this.cboMon2.FormattingEnabled = true;
            this.cboMon2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cboMon2.Location = new System.Drawing.Point(40, 78);
            this.cboMon2.Name = "cboMon2";
            this.cboMon2.Size = new System.Drawing.Size(121, 21);
            this.cboMon2.TabIndex = 2;
            this.cboMon2.SelectedIndexChanged += new System.EventHandler(this.CboMon2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(202, 296);
            this.Controls.Add(this.cboMon2);
            this.Controls.Add(this.cboMon1);
            this.Controls.Add(this.lblCBvalue);
            this.Controls.Add(this.lblTBvalue);
            this.Controls.Add(this.lblCDvalue);
            this.Controls.Add(this.lblNLvalue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNL;
        private System.Windows.Forms.Label lblNLvalue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCDvalue;
        private System.Windows.Forms.Label lblTBvalue;
        private System.Windows.Forms.Label lblCBvalue;
        private System.Windows.Forms.ComboBox cboMon1;
        private System.Windows.Forms.ComboBox cboMon2;
    }
}

