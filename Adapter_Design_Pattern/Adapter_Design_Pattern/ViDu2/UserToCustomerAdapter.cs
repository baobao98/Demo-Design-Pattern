using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern.ViDu2
{
    public class UserToCustomerAdapter : CustomerInterface
    {
        //bộ chuyển đổi kiểu dữ liệu từ user -> customer | mapping các atribute của user -> customer
        protected User user;
        protected string firstName;
        protected string lastName;
        
        public UserToCustomerAdapter(User userInput)
        {
            string fullName = userInput.getName();
            fullName.Trim();
            string[] arr = fullName.Split(' ');
            firstName = arr[0];
            lastName = arr[1];
        }
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
            firstName = first_name;
        }

        public void setLastName(string last_name)
        {
            lastName = last_name;
        }
    }
}
