using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter_Design_Pattern
{
    public class Core
    {
        public string ChuanHoaChuoi(string chuoi)
        {
            //Xóa khoảng trắng
            return chuoi.Trim();
        }
    }
}
