using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hinhtron hinhtron1 = new Hinhtron(new Toado("O",5,5), 10.5);
            Console.WriteLine(hinhtron1.toString());
        }
    }
}
