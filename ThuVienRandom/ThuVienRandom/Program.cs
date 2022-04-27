using System;

namespace ThuVienRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            //ngau nhan 0 den 100
            int x = rd.Next(101);
            //ngau nhien -50 100
            int y = rd.Next(-50, 101);
            //ngau nhein so thuc
            double k = rd.NextDouble();
        }
    }
}
