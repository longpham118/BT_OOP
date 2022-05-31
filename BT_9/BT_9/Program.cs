using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhsachCN list = new DanhsachCN(3);
            list.Add();
            list.Add();
            list.Add();
            list.Xuatthongtin();
            list.Congnhan200sp();
            list.SoluongCN();

            list.Sapxepgiamdan(); 
            
        }
    }
}
