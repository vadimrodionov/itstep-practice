using System;
using System.Threading;


namespace BuzinovArtem.Hometask_05
{
    /// <summary>
    /// Провел работу над ошибками. Избавился от goto
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tВычисление обратного числа");
            Thread.Sleep(3000);
            Console.ResetColor();
            ulong number;
            do
            {
                Console.WriteLine("Введите число: ");
            }
            while (!ulong.TryParse(Console.ReadLine(), out number));

            ulong inverseNumber = 0;
            while (number % 10 > 0)
            {
                inverseNumber = (inverseNumber * 10) + (number % 10);
                number = number / 10;
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Обратное число: {inverseNumber}");
            Console.ReadLine();
        }
    }
}


