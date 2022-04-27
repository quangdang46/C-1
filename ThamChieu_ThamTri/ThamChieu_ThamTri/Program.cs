using System;

namespace ThamChieu_ThamTri
{
    class Program
    {
        static void sz(int a)
        {
            a++;
        }
        static int szcheck(ref int x)
        {
            x+=1;
            return x;
        }
        static void Main(string[] args)
        {
            //tu khoa out va ref
            int a=2;
            Console.WriteLine("a truoc:{0}",a);//2
            sz(a);
            Console.WriteLine("a sau:{0}",a);//2
            int b = szcheck(ref a);
            //out bat buoc phai gan gia tri cho bien truoc khi thoat ham
            //ref bat buoc khoi tao gia tri cho bien
            Console.WriteLine("a sau:{0}", a);//3
            Console.WriteLine("a sau:{0}", b);//3



        }
    }
}
