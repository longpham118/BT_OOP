using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_9
{
    class DanhsachCN
    {
        private int count = 0;
        private Congnhan[] list = null;

        public DanhsachCN(int size)
        {
            list = new Congnhan[size];
        }

        int find(int amaCn)
        {
            for (int i = 0; i < count; i++)
            {
                if (amaCn.Equals(list[i].getMaCN()))
                {
                    return i;
                }
            }
                return -1;
        }

        //Them cong nhan
        public void Add()
        {
            if (count == list.Length)
            {
                Console.WriteLine("List if full!");
            }
            else
            {
                int newmaCn; string newmHo, newmTen; int newmSoSP;
                Congnhan cv = new Congnhan();
                int pos;
                do
                {
                    Console.WriteLine("Nhap ma so Cong Nhan: ");
                    newmaCn = Convert.ToInt32(Console.ReadLine());
                    pos = find(newmaCn);
                    if (pos >= 0)
                    {
                        Console.WriteLine("Ma Conh nhan nay da ton tai!");
                    }
                }
                while (pos >= 0);
                {
                    Console.WriteLine("Nhap Ho cong nhan: ");
                    newmHo = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Nhap Ten cong nhan: ");
                    newmTen = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Nhap so SP: ");
                    newmSoSP = Convert.ToInt32(Console.ReadLine());
                    list[count++] = new Congnhan(newmaCn, newmHo, newmTen, newmSoSP);
                    Console.WriteLine("Cong nhan moi da dc them");
                }
            }
        }

        public void Xuatthongtin()
        {
            if (count == 0)
            {
                Console.WriteLine("List if empty!");
            }
            else
            {
                Console.WriteLine("\nDanh sach cong nhan");
                Console.WriteLine("{0,5} {1,20} {2,20} {3,20}", "Ma CN", "Ho", "Ten", "So SP");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(list[i].toString());
                }
            }
        }

        

        public void Congnhan200sp()
        {
            if (count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                Console.WriteLine("\nDanh sach cong nhan lam tren 200sp la: ");
                Console.WriteLine("{0,5} {1,20} {2,20} {3,20}", "Ma CN", "Ho", "Ten", "So SP");
                for (int i = 0; i < count; i++)
                {
                    if (list[i].getMSoSP() > 200)
                    {
                       Console.WriteLine(list[i].toString());
                    }
                }
            }
        }

        public void SoluongCN()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("\nSo luong Cong nhan trong danh sach la: " + count + " cong nhan ");
                break;
            }    
        }

        
        public void Sapxepgiamdan()
        {
            Console.WriteLine("\nDanh sach cong nhan sap xep theo so SP giam dan:");
            Console.WriteLine("{0,5} {1,20} {2,20} {3,20}", "Ma CN", "Ho", "Ten", "So SP");
           
            for (int i = 0; i < count ; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (list[i].getMSoSP() < list[j].getMSoSP())
                    {
                        Congnhan c = list[i];
                        list[i] = list[j];
                        list[j] = c;
                        
                    }    
                }
            }
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0,5} {1,20} {2,20} {3,20}", list[i].getMaCN(), list[i].getMHo(), list[i].getMTen(), list[i].getMSoSP());
            }    
           
            
                
               
            
           
            
            
           
        }



    }
}      