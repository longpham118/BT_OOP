using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_4
{
     class Program
    {
        static void Main(string[] args)
        {
            vehicle xe1 = new vehicle("Pham Hoang Long", "Suzuki", 56000000 , 150);
            string str = xe1.toString();
            Console.WriteLine(str);
        }
    }
}
