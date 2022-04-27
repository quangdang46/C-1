using System;

namespace KieuDuLieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding=System.Text.Encoding.UTF8;
            int a = 3;
            int b = 4;
            //Bien
            
            Console.WriteLine("Bieu thuc {0}+{1}={2}", a, b, a + b);
            //Ep kieu
            double z = (double)2 / 3;
            Console.WriteLine("Gia tri cua Z={0}",z);
            //kieu var
            var str = "Tran Quang Dang";
            Console.WriteLine(str);

            //hang so
            const double Pi= 3.14;
            Console.WriteLine("Gia tri cua Pi:{0}",Pi);
            Console.ReadLine();

            
        }
    }
}
