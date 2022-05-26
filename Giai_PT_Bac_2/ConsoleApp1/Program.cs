namespace GiaiPT
{
      class Pt2
      {
        private float a;
        private float b;
        private float c;
        private float delta;
        public  Pt2()
        {
            Console.WriteLine("Moi ban nhap vao a mot so: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap vao b mot so: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap vao c mot so: ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4*(a * c);
        }

        public void Ptvo_nghiem()
        {
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
        }

        public void Ptnghiem_kep()
        {
            if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co nghiem kep x1 = x2 = " + -b / 2 * a);
            }
        }

        public void Pt2_nghiem()
        { 
             if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1 =" + (-b + Math.Sqrt(delta)) / (2*a)) ;
                Console.WriteLine("x2 = " + (-b - Math.Sqrt(delta)) / (2*a)) ;
            }
        }
    
      }

   
}