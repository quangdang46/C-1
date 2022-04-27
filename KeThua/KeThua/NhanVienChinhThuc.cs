using System;
using System.Collections.Generic;
using System.Text;

namespace KeThua
{
    class NhanVienChinhThuc:NhanVien
    {

        public new void TinhLuong()
        {
            base.TinhLuong();
            Console.WriteLine("Tinh luong nhan vien chinh thuc!!");
        }
    }
}
