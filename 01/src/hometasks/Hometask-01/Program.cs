using System;

namespace ElenaPlotnikova.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите символ: ");
            char symbol;
            int count = 0;
            do
            {
                symbol = (char)Console.ReadKey().KeyChar;
                if (symbol == ' ')
                    count++;
            }
            while (symbol != '.');
            Console.WriteLine("\nКоличество введенных пробелов: " + count);
        }
    }
}
