namespace BT_9
{
    class Congnhan
    {
        private int maCN;
        private string mHo;
        private string mTen;
        private int mSoSP;

        public Congnhan()
        {

        }

        public Congnhan(int maCN, string mHo, string mTen, int mSoSP)
        {
            this.maCN = maCN;
            this.mHo = mHo;
            this.mTen = mTen;
            this.mSoSP = mSoSP;
        }

        public int getMaCN()
        {
            return maCN;
        }

        public void setMaCN(int maCN)
        {
            this.maCN = maCN;
        }

        public string getMHo()
        {
            return mHo;
        }

        public void setMHo(string mHo)
        {
            this.mHo = mHo;
        }

        public string getMTen()
        {
            return mTen;
        }

        public int getMSoSP()
        {
            return mSoSP;
        }

        public void setMSoSP(int mSoSP)
        {
            this.mSoSP = mSoSP;
        }

        public void setMTen(string mTen)
        {
            this.mTen=mTen;
        }

        public void Tinhluong()
        {
            if (mSoSP >= 1 && mSoSP <= 199)
            {
                Console.WriteLine("Luong = " + mSoSP * 0.5);
            }
            if (mSoSP >= 200 && mSoSP <= 399)
            {
                Console.WriteLine("Luong = " + mSoSP * 0.55);
            }
            if (mSoSP >= 400 && mSoSP <= 599)
            {
                Console.WriteLine("Luong = " + mSoSP * 0.6);
            }
            if (mSoSP >= 600)
            {
                Console.WriteLine("Luong = " + mSoSP * 0.65);
            }
        }

        public string toString()
        {
            
            return string.Format("{0,5} {1,20} {2,20} {3,20}", maCN, mHo, mTen, mSoSP);
        }
    }
}