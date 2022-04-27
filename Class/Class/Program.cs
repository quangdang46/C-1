using System;

namespace Class
{
    class Program
    {
           
           
        static void Main(string[] args)
        {
            SinhVien sv = new SinhVien();
            //set
            sv.Ma = "100000000";
            sv.Ten = "Nguyen van Teo";
            Console.WriteLine(sv);
            //get
            string ten = sv.Ten;
            string ma = sv.Ma;
            Console.WriteLine(ten);
            Console.WriteLine(ma);
            //
            SinhVien sv1 = new SinhVien("52100174", "Nguyen Van A");
            Console.WriteLine(sv1);

        }
    }
}
