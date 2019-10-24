using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observer_Design_Pattern
{
    public class Customer: Observer
    {
        private string _name;
        public string Name { get { return _name; } set { _name= value; } }

        private string _phoneNumber;
        public string PhoneNumber { get => _phoneNumber; set => _phoneNumber = value; }

        public Customer(string name, string phone )
        {
            this._name = name;
            this._phoneNumber = phone;

        }
        public override void Update(string info)
        {
            MessageBox.Show("Thông báo tới khách hàng: "+Name+" \n thông tin sản phẩm mới: "+info);
        }
    }
}
