using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhTIenBanSach
{
    public class DanhSachKhachHang
    {
        public List<KhachHang> dsKh=new List<KhachHang>();
        public void Mua(KhachHang kh)
        {
            dsKh.Add(kh);
        }
        public List<KhachHang> Khachs
        {
            get
            {
                return dsKh;
            }
        }
        public int TongSo
        {
            get
            {
                return this.dsKh.Count;
            }
        }
        public int TongSoSv
        {
            get
            {
                int cnt = 0;
                foreach(KhachHang kh in this.dsKh)
                {
                    if (kh.LaSV)
                    {
                        cnt++;
                    }
                }
                return cnt;
            }
        }
        public double DoanhThu
        {
            get
            {
                double cnt = 0;
                foreach(KhachHang kh in dsKh)
                {
                    cnt += kh.TinhTien;
                }
                return cnt;
            }
        }
    }
}
