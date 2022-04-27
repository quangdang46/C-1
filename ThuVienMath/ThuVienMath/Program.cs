using System;

namespace ThuVienMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Moi ban nhap a: ");
            a = int.Parse(Console.ReadLine());
            //cach 2 de nhap du lieu
            int b;
            Console.WriteLine("Moi ban nhap b: ");
            b = Convert.ToInt32(Console.ReadLine());
            //Can bac hai
            Console.WriteLine("Can bac hai cua a:{0}",Math.Sqrt(a));
            //mu
            Console.WriteLine("Binh phuong a:{0}", Math.Pow(a,2));
            //a^b;
            Console.WriteLine("a^b:{0}", Math.Pow(a,b));
            //tri tuyet doi
            Console.WriteLine("abs(a):{0}", Math.Abs(a));
            //cos
            Console.WriteLine("Cos(a):{0}", Math.Cos(a));
            //sin
            Console.WriteLine("Sin(a):{0}", Math.Sin(a));
            //Lam tron
            double c;
            c = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Round:{0}", Math.Round(c,2));







        }
    }
}
