using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern.ViDu2
{
    public class Customer : CustomerInterface
    {
        //Nâng cấp từ User và có đến 2 thuộc tính
        private string firstName;
        private string lastName;
        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public void setFirstName(string first_name)
        {
            this.firstName = first_name;
        }

        public void setLastName(string last_name)
        {
            this.lastName = last_name;
        }

    }
}
