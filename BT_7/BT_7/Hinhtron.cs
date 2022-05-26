

namespace BT_7
{
     class Hinhtron
    {
        Toado tam;
        double bankinh;

        public Hinhtron()
        {

        }

        public Hinhtron(Toado tam, double bankinh)
        {
            this.tam = tam;
            this.bankinh = bankinh;
        }

        public double Bankinh 
        { 
            get => bankinh; 
            set => bankinh = value; 
        }
        internal Toado _tam 
        { 
            get => tam; 
            set => tam = value; 
        }

        public double dienTich()
        {
            return bankinh *bankinh * 3.14;
        }

        public double chuvi()
        {
            return (bankinh * 2) * 3.14;
        }

        public string toString()
        {
            return string.Format("Hinh tron co tam {0} voi ban kinh {1} co dien tich va chu vi lan luot la {2} va {3}",tam.toString(),bankinh, dienTich(), chuvi());
        }
    }
}
