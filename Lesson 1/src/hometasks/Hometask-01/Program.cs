using System;
using System.Threading;

namespace BuzinovArtem.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\tПрограмма считывания символов с клавиатуры");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            char keySymbol = '0';
            byte counter = 0;
            while (keySymbol!='.')
            {
                if (keySymbol==' ')
                {
                    counter++;
                }
                Console.WriteLine("Введите символ: ");
                if (char.TryParse(Console.ReadLine(), out keySymbol))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"Вы ввели '{keySymbol}'");
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введены не корректные значения");
                }
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Завершение работы программы");
            Thread.Sleep(2000);
            Console.WriteLine($"Пробел был введен {counter} раз(а)");
            Console.ReadLine();

        }
    }
}
