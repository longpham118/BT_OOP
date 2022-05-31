namespace BT_5
{
    class HangThucPham
    {
        private string mahang;
        private string tenhang;
        private double dongia;
        private DateTime ngaysanxuat;
        private DateTime ngayhethan;

        //Constructor ma hang
        public HangThucPham(string mahang)
        {
            this.mahang = mahang;
        }

        //Constructor day du tham so
        public HangThucPham(string mahang, string tenhang, double dongia, DateTime ngaysanxuat, DateTime ngayhethan)
        { 

            this.mahang = mahang;
            this.tenhang = tenhang;
            this.dongia = dongia;
            this.ngaysanxuat = ngaysanxuat;
            this.ngayhethan = ngayhethan;
        }

        public string getMahang()
        {
            return mahang;
        }

        public void setMahang(string mahang)
        {
            if (this.mahang == "")
            {
                Console.WriteLine("Loi, ma hang rong!");
            }
            else
            {
                this.mahang = mahang;
            }
        }

        public string getTenhang()
        {
            return tenhang;
        }

        public void setTenhang(string tenhang)
        {
            if (this.tenhang == "")
            {
                this.tenhang = "xxx";
            }
            else
            {
                this.tenhang = tenhang;
            }
        }

        public double getDongia()
        {
            return dongia;
        }

        public void setDongia(double dongia)
        {
            if (this.dongia < 0)
            {
                this.dongia = 0;
            }
            else
            {
                this.dongia = dongia;
            }
        }

        public DateTime getNgaysanxuat()
        {
            return ngaysanxuat;
        }

        public void setNgaysanxuat(DateTime ngaysanxuat)
        {
            int result = DateTime.Compare(this.ngaysanxuat, DateTime.Now);
            if (result > 0)
            {
                this.ngaysanxuat = DateTime.Now;
            }
            else
            {
                this.ngaysanxuat = ngaysanxuat;
            }
        }

        public DateTime getNgayhethan()
        {
            return ngayhethan;
        }

        public void setNgayhethan(DateTime ngayhethan)
        {
            int result = DateTime.Compare(this.ngayhethan, this.ngaysanxuat);
            if (result < 0)
            {
                this.ngayhethan = this.ngaysanxuat;
            }
            else
            {
                this.ngayhethan = ngayhethan;
            }
        }

        public string checkHetHan()
        {
            int result = DateTime.Compare(this.ngayhethan, DateTime.Now);
            return result < 0 ? "Hang het han" : "";
        }

        public string toString()
        {
            return String.Format("{0,10} {1,10} {2,20:#,##0.00VND} {3,20} {4,20} {5,20}\n", this.mahang, this.tenhang, this.dongia, this.ngaysanxuat.ToString("dd/MM/yyyy"), this.ngayhethan.ToString("dd/MM/yyyy"), this.checkHetHan());
        }
    }
}

        
    
