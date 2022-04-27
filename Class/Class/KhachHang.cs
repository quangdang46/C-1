using System;
using System.Collections.Generic;
using System.Text;

namespace Class
{
    public class KhachHang
    {
        
        public string Ten
        {
            get;
            set;
        }
        public string Ma
        {
            get;
            set;
        } 
        public string Phone
        {
            get;
            set;
        }

        public KhachHang Copy()
        {
            return this.MemberwiseClone () as KhachHang;
        }
    }

}
