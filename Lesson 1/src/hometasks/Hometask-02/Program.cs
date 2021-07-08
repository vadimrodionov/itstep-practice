using System;
using System.Threading;

namespace BuzinovArtem.Hometask_02
{
    /// <summary>
    /// Провел code review. Избавился от goto
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tПроверка счастливого билета");
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Ура! У вас счастливый билет");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Увы! Вам не повезло");
                        Console.ResetColor();
                    }

        }
    }
}
