namespace Adapter_Design_Pattern
{
    partial class FormVD2
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
            this.btnChuyen = new System.Windows.Forms.Button();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtChuoiChuyenDoi = new System.Windows.Forms.TextBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChuyen
            // 
            this.btnChuyen.Location = new System.Drawing.Point(122, 94);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(75, 23);
            this.btnChuyen.TabIndex = 0;
            this.btnChuyen.Text = "old";
            this.btnChuyen.UseVisualStyleBackColor = true;
            this.btnChuyen.Click += new System.EventHandler(this.BtnChuyen_Click);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(60, 144);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(198, 20);
            this.txtTen.TabIndex = 1;
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(41, 29);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(519, 20);
            this.txtInput.TabIndex = 1;
            // 
            // txtChuoiChuyenDoi
            // 
            this.txtChuoiChuyenDoi.Location = new System.Drawing.Point(342, 144);
            this.txtChuoiChuyenDoi.Name = "txtChuoiChuyenDoi";
            this.txtChuoiChuyenDoi.Size = new System.Drawing.Size(201, 20);
            this.txtChuoiChuyenDoi.TabIndex = 2;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(406, 94);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // FormVD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 339);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.txtChuoiChuyenDoi);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.btnChuyen);
            this.Name = "FormVD2";
            this.Text = "formVD2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChuyen;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtChuoiChuyenDoi;
        private System.Windows.Forms.Button btnNew;
    }
}