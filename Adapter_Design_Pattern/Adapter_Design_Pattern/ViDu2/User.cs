using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern.ViDu2
{
    public class User : UserInterface
    {
        private string name;
        public string getName()
        {
            try
            {
                return this.name;
            }
            catch
            {
                return "Error";
            }
        }

        public void setName(string name)
        {
            this.name = name;
        }
    }
}
