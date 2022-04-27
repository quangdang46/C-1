using System;

namespace Chuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.dem so chu hoa va chu thuong
            Console.WriteLine("Nhap chuoi ki tu:");
            string s = Console.ReadLine();
            int a = 0, b = 0,c=0;
            for(int i = 0; i < s.Length; ++i)
            {
                if (Char.IsUpper(s[i]))
                {
                    a++;
                }
                else if(Char.IsLower(s[i])){
                    b++;
                }
                if (Char.IsWhiteSpace(s[i]))
                {
                    c++;
                }
            }
            Console.WriteLine("Chu hoa:{0}\nChu thuong{1}",a,b);
            Console.WriteLine("So khoang trang:{0}",c);
        }
    }
}
