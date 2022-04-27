using System;

namespace VongLap
{

    class Program
    {
        static void GtDo()
        {
            int n;
            Console.WriteLine("Moi ban nhap:");
            n = int.Parse(Console.ReadLine());
            int cnt = 1;
            int i = 1;
            do
            {
                cnt *= i++;

            } while (i <= n);
            Console.WriteLine("{0}!={1}", n, cnt);
        }
        static void GtWhile()
        {
            int n;
            Console.WriteLine("Moi ban nhap:");
            n = int.Parse(Console.ReadLine());
            int cnt = 1;
            int i = 1;
            while (i <= n)
            {
                cnt *= i++;

            }
            Console.WriteLine("{0}!={1}", n, cnt);
        }
        static void GtFor()
        {
            int cnt = 1;
            int n;
            Console.WriteLine("Moi ban nhap:");
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                cnt *= i;
            }
            Console.WriteLine("{0}!={1}", n, cnt);

        }

        static void Main(string[] args)
        {
            GtDo();
            GtWhile();
            GtFor();
            Console.ReadLine();
        }
        
    }
}
