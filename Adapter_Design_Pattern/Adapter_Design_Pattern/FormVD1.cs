using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adapter_Design_Pattern
{
    public partial class FormVD1 : Form
    {
        public FormVD1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if ( dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtChuoi.Text = dialog.FileName;
                Adapter adapter = new Adapter();
                StreamReader sr = new StreamReader(dialog.FileName);
                string line;
                List<string> danhSach = new List<string>();
                while((line = sr.ReadLine()) != null)
                {
                    danhSach.Add(line);
                }
                cboOuput.DataSource = null;
                cboOuput.DataSource = adapter.ChuanHoaListChuoi(danhSach);
            }
        }
    }
}
