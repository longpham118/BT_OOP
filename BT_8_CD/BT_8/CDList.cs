namespace BT_8
{
    class CDList
    {
        int count = 0;
        private CD[] list;

        public CDList(int size)
        {
            list = new CD[size];
        }

        //Check Existed CD
        int check(int _idCD)
        {
            for (int i  = 0; i < count; i++)
            {
                if (_idCD.Equals(list[i].getIdCD()))
                {
                    return i;
                }
            }
            return -1;
        }

        //Add new CD
        public void add(CD _cd)
        {
            if (count == list.Length)
            {
                Console.WriteLine("List if full!");
            }
            else
            {
                int newidCD; string newname; int newsongnumber; double newPrice;
                CD cd = new CD();
                int pos;
                do
                {
                    Console.WriteLine("Nhap id CD: ");
                    newidCD = Convert.ToInt32(Console.ReadLine());
                    pos = check(newidCD);
                    if (pos >= 0)
                    {
                        Console.WriteLine("Ma CD da ton tai!");
                    }
                }
                while (pos >= 0);
                {
#pragma warning disable CS8600
                    Console.WriteLine("Nhap ten CD: "); 
                    newname = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Nhap so bai hat: ");
                    newsongnumber = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Nhap gia tien CD: ");
                    newPrice = Convert.ToDouble(Console.ReadLine());
                    list[count++] = new CD(newidCD, newname, newsongnumber, newPrice);
                    Console.WriteLine("CD moi da dc them");

                }
            }
        }

        //So luong CD co trong danh sach
        public void SoluongCD()
        {
            if (count == 0)
            {
                Console.WriteLine("CDList is emtpy!");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("So luong CD co trong danh sach la: " + count);
                }
            }
        }

        //Tinh tong gia thanh cua cac CD
        public void TongtienCD()
        {
            float total = 0;
            if (count == 0)
            {
                Console.WriteLine("List is empty!");
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    total += (float)list[i].getPrice();
                }
            }
            Console.WriteLine("Tong gia tien cua cac CD la: {0}", total);
        }

        //Xuat thong tin ra man hinh
        public void toString()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(list[i].toString());
            }
        }

        //Sap xep danh sach theo gia thanh giam dan
        public void Giamdan()
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (list[i].getPrice() <  list[j].getPrice())
                    {
                        CD c = list[i];
                        list[i] = list[j];
                        list[j] = c;
                    }
                }    
            }
            Console.WriteLine("Danh sach CD sau khi sap xep theo gia thanh giam dan");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("{0} {1} {2} {3}", list[i].getIdCD(), list[i].getName(), list[i].getSongnumber(), list[i].getPrice());
            }
        }
    }
}