using System;

namespace SoSanhChuoi
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Nguyen     THi   tet    
            Console.WriteLine("Moi ban nhap:");
            string s = Console.ReadLine();
            s.Trim();
            string[] str = s.Split(new char[] {' '},StringSplitOptions.RemoveEmptyEntries);
            string tmp="";
            for(int i=0;i<str.Length;i++)
            {
                string word = str[i].ToLower();
                char[] arrWord = word.ToCharArray();
                arrWord[0] = char.ToUpper(arrWord[0]);
                string newWord = new string(arrWord);
                tmp += newWord + " ";
            }

            Console.WriteLine("Chuoi chuan hoa:{0}",tmp.Trim());


            Console.ReadLine();
        }
    }
}
