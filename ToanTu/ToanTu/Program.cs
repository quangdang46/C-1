using System;

namespace ToanTu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int a = 3, b = 6;
            int c = a + b;
            Console.WriteLine("Gia tri cua c {0}",c);
            c += 2;
            Console.WriteLine("Gia tri cua c {0}", c);
            Console.WriteLine("Moi ban nhap mot so: ");
            int a = int.Parse(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("{0} la so chan",a);
            }
            else
            {
                Console.WriteLine("{0} la so le", a);

            }
            */
            //Kiem tra nam nhuan
            /*
            int nam;
            Console.WriteLine("Moi ban nhap nam: ");
            nam = int.Parse(Console.ReadLine());
            if((nam%4==0 && nam%100!=0) || nam % 400 == 0)
            {
                Console.WriteLine("{0} la nam nhuan",nam);
            }
            else
            {
                Console.WriteLine("{0} khong phai nam nhuan", nam);

            }
            */
            //toan tu ++ -- !
            int a=2;
            a++;
            Console.WriteLine(a);
            a--;
            Console.WriteLine(a);
            Console.WriteLine(++a);
            Console.WriteLine(--a);
            bool check = true;

            if (!check)
            {
                Console.WriteLine("Sai");
            }
            else
            {
                Console.WriteLine("Dung");
            }

            Console.ReadLine();

        }

    }
}
