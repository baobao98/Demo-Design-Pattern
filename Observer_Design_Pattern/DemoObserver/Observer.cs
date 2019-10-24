using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoObserver 
{
    public abstract class Observer
    {
        public abstract void Update(string info,Label label);
    }
}
