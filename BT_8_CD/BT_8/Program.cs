using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_8
{
    internal class Program
    {
        static void Main(String[] args)
        {
            CDList list = new CDList(4);
            list.add(new CD(1, "AA", 2, 10000));
            list.add(new CD(2, "EE", 5, 40000));
            list.add(new CD(3, "DD", 10, 200000));
            list.add(new CD(4, "VV", 1, 20000));

            list.SoluongCD();
            list.TongtienCD();
            list.toString();
            list.Giamdan();
        }
    }
}
