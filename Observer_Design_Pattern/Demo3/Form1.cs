using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo3
{
    public partial class Form1 : Form
    {
        int glucidValue = 0;
        int lipidValue = 0;


        MonAn monAn;
        public Form1()
        {
            InitializeComponent();
            ChatDinhDuong glucid = new ChatDinhDuong(lblCDvalue);
            ChatDinhDuong lipid = new ChatDinhDuong(lblCBvalue);
            monAn = new MonAn();
            monAn.AddChatDinhDuong(glucid);
            monAn.AddChatDinhDuong(lipid);
        }

        private void CboMon1_SelectedIndexChanged(object sender, EventArgs e)
        {
           int cbo1= Convert.ToInt32(cboMon1.SelectedItem.ToString());
            glucidValue += cbo1;
            //lưu ý mảng int giá trị chất đưa vào đúng theo thứ tự mà hàm add chất ở trên
            monAn.MonAnThem(new int[] { glucidValue, lipidValue });
            monAn.Update();
        }

        private void CboMon2_SelectedIndexChanged(object sender, EventArgs e)
        {
           int cbo2= Convert.ToInt32(cboMon2.SelectedItem.ToString());
            lipidValue += cbo2;

            monAn.MonAnThem(new int[] { glucidValue, lipidValue });
            monAn.Update();
        }
    }
}
