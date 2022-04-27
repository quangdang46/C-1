using System;

namespace TryCatch
{
    class Program
    {

        static void Check()
        {
            
            int a,b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            if (b == 0)
            {
                throw new ArithmeticException("Loi mau =0");
            }
            double c = (double)a / b;
            Console.WriteLine(c);
        }
        static void Main(string[] args)
        {
            /*
            try
            {
                Console.WriteLine("Moi ban nhap ngay sinh");
                string s = Console.ReadLine();
                DateTime rd = DateTime.Parse(s);
                Console.WriteLine("Ngay sinh: "+rd.ToString("dd/MM/yyyy"));

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally {
                Console.WriteLine("Ban da nhap xong ngay thang!!");
            }
            */
            try
            {
                Check();
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
