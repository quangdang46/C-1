using System;

namespace Ham
{
    class Program
    {
        static void PTbac1()
        {
            int a, b;
            Console.WriteLine("Moi ban nhap a va b: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            if(a==0 && b == 0)
            {
                Console.WriteLine("Pt vo so nghiem!!");
            }else if(a==0 && b!=0)
            {
                Console.WriteLine("Pt vo nghiem!!");
            }
            else
            {
                Console.WriteLine("Pt co nghiem duy nhat:{0}",(double)-b/a);
            }
        }

        static int min(int a,int b)
        {
            return a < b ? a : b;
        }
        static void Gt()
        {
            int n;
            Console.WriteLine("Moi ban nhap n: ");
            n = int.Parse(Console.ReadLine());
            int cnt = 1;
            for(int i = 1; i <= n; i++)
            {
                cnt *= i;
            }
            Console.WriteLine("{0}!={1}",n,cnt);
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Gt();
            PTbac1();
            Console.WriteLine("Min 3 va 4 la:{0}", min(3, 4)) ;
            Console.ReadLine();

        }
    }
}
