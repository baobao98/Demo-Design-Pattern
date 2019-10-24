using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoObserver
{
    public partial class Form1 : Form
    {
        string numb;
        Product product = new Product();
        Customer cus1 = new Customer("Bao", "0120930");
        public Form1()
        {
            InitializeComponent();


           // Customer cus2 = new Customer("Khoa", "0293949");

            product.AddCustomer(cus1);
            //product.AddCustomer(cus2);

           
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            Product product = new Product();

            Customer cus1 = new Customer("Bao", "0120930");

            product.AddCustomer(cus1);

            product.Update(txtInput.Text,lblInfo);
           
        }

        private void TxtInput_TextChanged(object sender, EventArgs e)
        {
            product.Update(txtInput.Text,lblInfo);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //id
            //tao ra dataset chua 4 gia tri

            numb += comboBox1.SelectedItem.ToString();
            product.Update(numb,lblInfo);
        }
    }
}
