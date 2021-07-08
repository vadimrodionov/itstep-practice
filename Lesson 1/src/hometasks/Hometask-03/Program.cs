using System;
using System.Threading;

namespace BuzinovArtem.Hometask_03
{
    /// <summary>
    /// Провел работу над ошибками. Удалил goto, вынес цветную консоль в отдельный метод
    /// </summary>
    class Program
    {
        public static void WriteColoredLine(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{message}");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteColoredLine(ConsoleColor.Red, "\t\t\t\t\tИзменение регистра символов");
            Thread.Sleep(3000);
            Console.ResetColor();
            char variable;
            do
            {
                Console.WriteLine("Введите буквенный символ");


            } while (!char.TryParse(Console.ReadLine(), out variable));

            int integer = (int)variable;

            if (integer >= 65 && integer <= 90)
            {
                integer += 32;
                WriteColoredLine(ConsoleColor.Green, $"Символ в нижнем регистре: {(char)integer}");
            }
            else if (integer >= 97 && integer <= 122)
            {
                integer -= 32;
                WriteColoredLine(ConsoleColor.Green, $"Символ в верхнем регистре: {(char)integer}");
            }
            else
            {
                WriteColoredLine(ConsoleColor.Red, "Вы ввели не буквенный символ!");
            }

        }
    }


}


