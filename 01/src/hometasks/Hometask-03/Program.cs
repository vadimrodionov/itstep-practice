using System;

namespace BogdanUdincev.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            var isUpperCase = str.ToUpper() == str;
            if (isUpperCase == false) str = str.ToUpper();
            else if (isUpperCase == true) str = str.ToLower();
            Console.WriteLine(str);
        }
    }
}
