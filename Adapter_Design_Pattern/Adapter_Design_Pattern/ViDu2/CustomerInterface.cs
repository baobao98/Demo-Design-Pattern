using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern.ViDu2
{
    interface CustomerInterface
    {
        string getFirstName();
        void setFirstName(string first_name);

        string getLastName();
        void setLastName(string last_name);

    }
}
