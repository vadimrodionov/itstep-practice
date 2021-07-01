using System;
using System.Threading;


namespace BuzinovArtem.Hometask_05
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tВычисление обратного числа");
            Thread.Sleep(3000);
            Console.ResetColor();
            begin:
            Console.WriteLine("Введите число: ");
            ulong number;
            if (ulong.TryParse(Console.ReadLine(),out number))
            {
                ulong inverseNumber = 0;
                while (number%10 > 0)
                {
                    inverseNumber=(inverseNumber*10)+(number%10);
                    number = number / 10;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Обратное число: {inverseNumber}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены не корректные данные!");
                Console.ResetColor();
                goto begin;
            }
            Console.ReadLine();
        }
    }
}
