using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Tam_giac tamgiac1 = new Tam_giac(5, 5, 5);
            string str = tamgiac1.toString();
            Console.WriteLine(str);


        }
    }
}
