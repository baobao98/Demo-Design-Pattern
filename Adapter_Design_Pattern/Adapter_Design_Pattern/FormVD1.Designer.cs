namespace Adapter_Design_Pattern
{
    partial class FormVD1
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
            this.txtChuoi = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cboOuput = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtChuoi
            // 
            this.txtChuoi.Location = new System.Drawing.Point(31, 12);
            this.txtChuoi.Name = "txtChuoi";
            this.txtChuoi.ReadOnly = true;
            this.txtChuoi.Size = new System.Drawing.Size(161, 20);
            this.txtChuoi.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cboOuput
            // 
            this.cboOuput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboOuput.FormattingEnabled = true;
            this.cboOuput.Location = new System.Drawing.Point(31, 70);
            this.cboOuput.Name = "cboOuput";
            this.cboOuput.Size = new System.Drawing.Size(161, 150);
            this.cboOuput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 263);
            this.Controls.Add(this.cboOuput);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtChuoi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtChuoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboOuput;
    }
}

