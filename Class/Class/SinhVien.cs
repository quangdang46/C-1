using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class SinhVien
    {
        private string ma;
        private string ten;
        private DateTime namsinh;
        public SinhVien()
        {
            this.ma = "221110";
            this.ten = "Tran Quang Dang";
        }
        public SinhVien(string ma, string ten)
        {
            this.ma = ma;
            this.ten = ten;
        }


        public string Ma
        {
            get
            {
                return this.ma;
            }
            set
            {
                this.ma = value;
            }
        }
        public string Ten
        {
            get
            {
                return this.ten;
            }
            set
            {
                this.ten = value;
            }

        }

        public DateTime NamSinh
        {
            get{
                return this.namsinh;
            }
            set
            {
                this.namsinh = value;
            }
        }


        //sp methods
        private bool CheckNamSinh()
        {
            return (DateTime.Now.Year - this.namsinh.Year) >= 18;
        }

        public void Xuat()
        {
            if (!CheckNamSinh()){
                Console.WriteLine("nam sinh khong hop le!");
            }
        }

        public override string ToString()
        {
            return "Sinh vien co ma "+this.ma+" co ten la "+this.ten;
        }

    }
}
