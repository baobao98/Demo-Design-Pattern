using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern
{
    public class Adapter
    {
        Core core = new Core(); 
        public List<string> ChuanHoaListChuoi(List<string> danhSach)
        {
            List<string> newList = new List<string>();
            foreach(string item in danhSach)
            {
                newList.Add(core.ChuanHoaChuoi(item));
            }

            return newList;

        }

    }
}
