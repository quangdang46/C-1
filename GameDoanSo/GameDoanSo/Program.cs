using System;

namespace GameDoanSo
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int cnt = 0,songuoi;
            int somay = rd.Next(51);
            bool flag = true;
            Console.WriteLine("Check {0}",somay);
            while (flag)
            {
                Console.WriteLine("Moi ban nhap so ban chon:");
                songuoi = int.Parse(Console.ReadLine());
                cnt++;
                if (songuoi > somay)
                {
                    Console.WriteLine("So ban chon >so may!!");
                }else if (songuoi < somay)
                {
                    Console.WriteLine("So ban chon <so may!!");
                }
                else
                {
                    Console.WriteLine("Ban da chon dung roi!!");
                    flag = false;
                }
                if(!flag || cnt == 7) {
                
                    Console.WriteLine("Ban co muon tiep tuc khong!!");
                    char choice;
                    Console.WriteLine("Moi ban chon C/K");
                    choice = Console.ReadLine()[0];
                    if (choice == 'c' || choice=='C')
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }


            }
        }
    }
}
