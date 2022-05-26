namespace BT_7
{
     class Toado
    {
        string name;
        float x, y;

        public Toado()
        {

        }

        public Toado(string name, float x, float y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        public string Name 
        { 
            get => name; 
            set => name = value; 
        }
        public float X 
        { 
            get => x; 
            set => x = value; 
        }
        public float Y 
        { 
            get => y; 
            set => y = value; 
        }

        public string toString()
        {
            return string.Format("{0} ({1}, {2}) ", name, x, y);
        }
    }
}