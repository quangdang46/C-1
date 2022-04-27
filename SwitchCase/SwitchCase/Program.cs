using System;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Moi ban nhap a va b");
            a = int.Parse(Console.ReadLine());
            b= int.Parse(Console.ReadLine());
            Console.WriteLine("Moi ban nhap phep tinh:");
            char c;
            c = Console.ReadLine()[0];
            switch (c)
            {
                case '+':
                    Console.WriteLine("{0}+{1}={2}",a,b,a+b);
                    break;
                case '-':
                    Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                    break;
                case '*':
                    Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                    break;
                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("Khong the thuc hien!!");
                    }
                    else
                    {
                        Console.WriteLine("{0}/{1}={2}", a, b,(double) a/b);
                    }
                    break;
                default:
                    Console.WriteLine("Khong co phep tinh nay");
                    break;
            }


            Console.ReadLine();
        }
    }
}
