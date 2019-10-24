using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace  DemoObserver
{
    public class Product : Observer
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }

        private List<Customer> customers = new List<Customer>();

        //constructor
        public Product(string name)
        {
            this._name = name;
        }
        public Product() { }
        //method
        public override void Update(string info,Label label)
        {
            foreach(Customer cus in customers)
            {
                cus.Update(info,label);
            }
        }

        public void AddCustomer(Customer customer)
        {
            if( customer !=null)
            {
                customers.Add(customer);
            }
        }
        
        public void RemoveCustomer(Customer customer)
        {
            if (customer!=null)
            {
                customers.Remove(customer);

            }
        }
    }
}
