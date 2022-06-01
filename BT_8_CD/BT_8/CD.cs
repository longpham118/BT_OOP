namespace BT_8
{
    class CD
    {
        protected int idCD;
        protected string name;
        protected int songnumber;
        protected double price;

        public CD()
        {

        }

        public CD(int idCD, string name, int songnumber, double price)
        {
            this.idCD = idCD;
            this.name = name;
            this.songnumber = songnumber;
            this.price = price;
        }

        public int getIdCD()
        {
            return idCD;
        }

        public void setIdCD(int idCD)
        {
            if (this.idCD > 0)
            {
                this.idCD = idCD;
            }
            else
            {
                this.idCD = 999999;
            }
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            if (this.name == " ")
            {
                this.name = "Chua xac dinh!";
            }
            else
            {
                this.name = name;
            }
        }

        public int getSongnumber()
        {
            return songnumber;
        }

        public void setSongnumber(int songnumber)
        {
            if (this.songnumber > 0)
            {
                this.songnumber = songnumber;
            }
            else
            {
                this.songnumber = 1;
            }
        }

        public double getPrice()
        {
            return price;
        }

        public void setPrice(double price)
        {
            if (this.price > 0)
            {
                this.price = price;
            }
            else
            {
                this.price = 0000;
            }
        }

        public string toString()
        {
            return string.Format("{0} {1} {2} {3}", idCD, name, songnumber ,price);
        }
    }
}

       