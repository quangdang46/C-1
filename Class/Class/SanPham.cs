﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    class SanPham
    {
        private int ma;
        private string ten;
        private int dongia;
        public SanPham()
        {
            this.ma= 1;
            this.ten = "";
            this.dongia = 1;
        }
        public SanPham(int ma)
        {
            this.ma = ma;
        }
        public SanPham(int ma,string ten,int dongia)
        {
            this.ma = ma;
            this.ten = ten;
            this.dongia = dongia;
        }
        public void Xuat(int x)
        {

        }
        public void Xuat(float x)
        {

        }
    }

}
