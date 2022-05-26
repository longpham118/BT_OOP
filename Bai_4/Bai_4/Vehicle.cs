namespace Bai_4
{
    class vehicle
    {
        private  string name;
        private string type;
        private int price;
        private int xylanh;

        public  vehicle()
        {

        }

        public vehicle(string name, string type, int price, int xylanh)
        {
            this.name = name;
            this.type = type;
            this.price = price;
            this.xylanh = xylanh;
        }

        public string Name 
        { 
            get { return name; }
            set { name = value;  }
        }
        public string Type 
        { 
            get => type; 
            set => type = value; 
        }
        public int Price 
        { 
            get => price;
            set 
            { 
                if (value > 0)
                {
                    this.price = value;
                }
                else
                {
                    this.price = 0;
                }
            } 
        }
        public int Xylanh 
        { 
            get => xylanh; 
            set
            {
                if (value > 0)
                {
                    this.xylanh = value;
                }
                else
                {
                    this.xylanh = 0;
                }
            }
        }

        //Tinh thue phai nop
        public float Tax()
        {
            if (xylanh < 100)
            {
                return (float)(Price * 0.1);
            }
            if (xylanh >= 100 && xylanh <= 200)
            {
                return (float)(Price * 0.3);
            }
            if (xylanh > 200)
            {
                return (float)(Price * 0.5);
            }
            else
                return 0;
        }

        public string toString()
        {
            return string.Format("Chu xe: {0}; Loai xe: {1}; Dung tich: {2}; Tri gia: {3}; Thue phai nop: {4}", Name, Type, Xylanh, Price, Tax());
        }
    }
}