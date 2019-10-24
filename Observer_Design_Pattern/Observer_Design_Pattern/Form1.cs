using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_Design_Pattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            Customer cus1 = new Customer("Bao", "0120930");
            Customer cus2 = new Customer("Khoa", "0293949");

            product.AddCustomer(cus1);
            product.AddCustomer(cus2);

            product.Update("Bikini Super Size");
        }
    }
}
