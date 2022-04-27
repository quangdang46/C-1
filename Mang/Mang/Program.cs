using System;

namespace Mang
{

    /*
        1)Nhap gia tri ngau nhien mang co n phan tu
        2)Xuat cac gia tru trong mang
        3)Dao nguoc mang
        4)Sap xep mang
        5)Tinh tong cac phan tu trong mang
        6)Tim kiem trong mang
     
    */

    class Program
    {
        static void Nhap(int[] arr, int n)
        {
            Random rd = new Random();
            for(int i = 0; i < n; ++i)
            {
                arr[i] = rd.Next(100);
            }
        }
        static void Xuat(int[] arr,int n)
        {
            for(int i = 0; i < n; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static int sumArray(int[] arr,int n)
        {
            int sum = 0;
            foreach(int k in arr)
            {
                sum += k;
            }
            return sum;
        }
        static void Find(int[] arr,int k)
        {
            bool check = false;
            foreach(int it in arr)
            {
                if (it == k)
                {
                    check = true;
                }
            }
            if (check)
            {
                Console.WriteLine("Co phan tu trong mang");
            }
            else
            {
                Console.WriteLine("Khong tim thay phan tu!!");
            }
        }


        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] arr = new int[100];
            Console.WriteLine("Nhap gia tri n:");
            int n = int.Parse(Console.ReadLine());
            Nhap(arr,n);
            Xuat(arr,n);
            Console.WriteLine("Tong mang: "+sumArray(arr,n));
            Console.WriteLine("\nMang sau khi dao nguoc");
            Array.Reverse(arr);
            Xuat(arr,n);
            Console.WriteLine("\nMang sau khi sap xep");
            Array.Sort(arr);
            Xuat(arr,n);
            Console.WriteLine();
            //Tim gia tri trong mang
            Find(arr, 2);




        }
    }
}
