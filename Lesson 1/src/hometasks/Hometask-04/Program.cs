using System;
using System.Threading;

namespace BuzinovArtem.Hometask_04
{
    /// <summary>
    /// Провел работу над ошибками. Избавился от goto, вынес првоерку входных данных в отдельный метод
    /// </summary>
    class Program
    {
        public static uint numberCheck(string message)
        {
            uint num;
            do
            {
                Console.WriteLine($"{message}");
            }
            while (!uint.TryParse(Console.ReadLine(), out num));

            return num;
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\t\tМассив цифр");
            Console.ResetColor();
            Thread.Sleep(3000);
            uint a = numberCheck("Введите число А");
            uint b = numberCheck("Введите число В");

            if (b < a)
            {
                uint buffer = a;
                a = b;
                b = buffer;
            }

            if (a > 1)
            {
                b = b - a + 1;
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;

            for (int i = 0; i < b; i++)
            {
                for (int j = 0; j < a; j++)
                {
                    Console.Write(a);
                }

                Console.WriteLine();
                a++;
            }
            Console.ResetColor();

            Console.ReadLine();
        }


    }
}
