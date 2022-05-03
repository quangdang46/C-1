using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTIenBanSach
{
    public class KhachHang
    {
        const double GIA=20000;
        public String MaKH { get; set; }
        public int SoLuong { get; set; }
        public bool LaSV { get; set;}
        public double TinhTien
        {
            get
            {
                if (this.LaSV)
                {
                    return this.SoLuong * GIA * 0.95;
                }
                else
                {
                    return this.SoLuong * GIA;
                }
            }
        }


    }
}
