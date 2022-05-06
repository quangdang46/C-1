using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiBanXe
{
    
    public class KhachHang
    {
        public int THUE =200;
        public double PHU_THU_DEN=0.05;
        public String Ten { get; set; }
        public String DiaChi { get; set; }
        public String SoDienThoai { get; set; }
        public int GiaXe { get;set; }
        public String MauXe { get; set; }
        public double ThanhTien
        {
            get
            {
                if (this.MauXe == "Den")
                {
                    return (double)this.GiaXe * 3 + this.GiaXe * PHU_THU_DEN;
                }
                return (double)this.GiaXe * 3;
            }
        }
    }
}
