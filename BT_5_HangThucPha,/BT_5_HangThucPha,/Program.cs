﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HangThucPham tp1 = new HangThucPham("001", "Gao", 100000, new DateTime(2018, 7, 10), new DateTime(2018, 7, 9));
            HangThucPham tp2 = new HangThucPham("002", "Mi", 5000, new DateTime(2018, 3, 1), new DateTime(2022, 9, 1));
            HangThucPham tp3 = new HangThucPham("003", "Nuoc", 10000, new DateTime(2017, 3, 1), new DateTime(2022, 3, 1));
            Console.WriteLine("{0,10} {1,10} {2,20:#,##0.00} {3,20} {4,20} {5,20}\n", "Ma_Hang", "Ten_Hang", "Don_Gia", "Ngay_San_Xuat", "Ngay_Het_Han", "Ghi_Chu");
            Console.WriteLine(tp1.toString());
            Console.WriteLine(tp2.toString());
            Console.WriteLine(tp3.toString());
        }
    }
}
