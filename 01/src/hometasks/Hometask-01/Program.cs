using System;

namespace BogdanUdincev.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            char n;
            int i = 0;
            do
            {
                Console.Write($"Ввод символа: ");
                n = Console.ReadKey().KeyChar;
                if (n != '.') i++;
                Console.Write('\n');
            } while (n != '.');
            Console.Write($"Всего символов: {i}\n");
        }
    }
}
