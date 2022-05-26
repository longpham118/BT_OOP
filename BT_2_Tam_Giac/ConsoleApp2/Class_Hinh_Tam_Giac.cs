namespace BT_2
{
    class Tam_giac
    {
        private int ma;
        private int mb;
        private int mc;

        //Constructor mac dinh ko tham so
        public Tam_giac()
        {

        }

        //Constructor du tham so
        public Tam_giac(int ma, int mb, int mc)
        { 
            this.Ma = ma;
            this.Mb = mb;
            this.Mc = mc;
            if (Ma + Mb > Mc && Ma + Mc > Mb && Mb + Mc > Ma)
            {
                this.Ma = ma;
                this.Mb = mb;
                this.Mc = mc;
            }
            else
            {
                this.Ma = 0;
                this.Mb = 0;
                this.Mc = 0;
            }
        }
        
            
        

        //Method setter and getter
        public int Ma
        {
            get { return ma; }
            set
            {
                if (value > 0)
                {
                    ma = value;
                }
                else
                {
                    ma = 0;
                }
            }
            
        }
        public int Mb
        {
            get { return mb; }
            set
            {
                if (value > 0)
                {
                    mb = value;
                }
                else
                {
                    mb =  0;
                }
            }
        }
        public int Mc
        {
            get { return mc; }
            set
            {
                if (value > 0)
                {
                    mc = value;
                }
                else
                {
                    mc =  0;
                }
            }
        }

        

        //Method chu vi
        public float Tinhchuvi()
        {
            return Ma + Mb + Mc;
        }

        //Method tinh dien tich
        public float Tinhdietich()
        {
            float S, p;
            if (Ma < Mb + Mc && Mb < Ma + Mc && Mc < Ma + Mb)
            {
                p = (Ma + Mb + Mc) / 2;
                return S = (float)Math.Round(Math.Sqrt(p * (p - Ma) * (p - Mb) * (p - Mc)));
            }
            else
            {
                return 0;
            } 
                
        }

        //Method tra ve thong tin tam giac
        public string Trathongtin()
        {
            if (Ma < Mb + Mc && Mb < Ma + Mc && Mc < Ma + Mb)
            {
                return "Day la tam giac nhon";
            }
            else
            {
                return "Day ko phai la tam giac";
            }
            if (Ma == Mb && Mb == Mc )
            {
                return "Day la tam giac deu";
            }
            else if (Ma == Mb || Ma == Mc || Mb == Mc)
            {
                return "Day la tam giac can";
            }
           
        }

        //Method xuat thong tin tam giac ra man hinh
        public string toString()
        {
            return string.Format("ma = {0};  mb = {1};  mc = {2}; Kieu: {3}; P = {4}; S = {5}", Ma, Mb, Mc, Trathongtin(), Tinhchuvi(), Tinhdietich() );
        }

        

    }
}