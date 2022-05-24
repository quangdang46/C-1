using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 1, 4, 4, 2, 2, 5, 5, 5, 3 };
            //sort
            Array.Sort(array);
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (dict.ContainsKey(array[i]))
                {
                    dict[array[i]]++;
                }
                else
                {
                    dict.Add(array[i], 1);
                }
            }
            int len = dict.Values.Max();
            int[] arr = dict.Keys.ToArray();
            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) <= 1)
                {
                    len = Math.Max(len, dict[arr[i]] + dict[arr[i + 1]]);
                }
            }
            Console.Write(len);
            Console.ReadKey();
        }
    }
}
