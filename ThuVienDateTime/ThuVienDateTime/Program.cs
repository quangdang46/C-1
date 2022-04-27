using System;

namespace ThuVienDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime bt = new DateTime(2022, 4, 6);
            Console.WriteLine(bt.ToString("dd/MM/yyyy"));
            //chuyen doi chuoi thanh ngay thang
            DateTime d = DateTime.Parse("4/6/2003");
            Console.WriteLine(d.ToString("dd/MM/yyyy"));

            
        }

    }
}
