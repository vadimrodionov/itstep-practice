using System;
using System.Threading;

namespace BuzinovArtem.Hometask_02
{
    /// <summary>
    /// Провел code review. Избавился от goto. Добавил метод для вывода цветной консоли
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
            Console.ForegroundColor = ConsoleColor.Green;
            WriteColoredLine(ConsoleColor.Green, "\t\t\t\t\tПроверка счастливого билета");
            Console.ResetColor();
            Thread.Sleep(3000);
            int Ticket;
            string Tick = "";
            do
            {
                Console.WriteLine("Введите номер билета (6 цифр!): ");
                Tick=Console.ReadLine();

            } while (!int.TryParse(Tick, out Ticket)||Tick.Length!=6);


            int backSum = 0;
            int temp = Ticket;
               for (int i = 0; i < 3; i++)
                  {
                       backSum = backSum + temp % 10;
                       temp = temp / 10;
                   }
                   temp = Ticket/1000;
                   int frontSum = 0;
                   for (int i = 0; i < 3; i++)
                   {
                       frontSum = frontSum + temp % 10;
                       temp = temp / 10;
                    }

                    if (frontSum==backSum)
                    {
                         WriteColoredLine(ConsoleColor.Green, "Ура! У вас счастливый билет");
                    }
                    else
                    {
                           WriteColoredLine(ConsoleColor.Yellow, "Увы! Вам не повезло");
                    
                    }

        }
    }
}
