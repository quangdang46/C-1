using System;
using System.Collections.Generic;
using System.Text;

namespace KeThua
{
    class NhanVienThoiVu:NhanVien
    {
        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Tinh luong nhan vien thoi vu!!");
            
        }

    }
}
