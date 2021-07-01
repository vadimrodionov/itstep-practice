using System;
using System.Threading;

namespace BuzinovArtem.Hometask_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\t\tМассив цифр");
            Console.ResetColor();
            Thread.Sleep(3000);
            uint a , b; 
            enterA:
            Console.WriteLine("Введите число А:");
            if (uint.TryParse(Console.ReadLine(),out a))
            {
                enterB:
                Console.WriteLine("Введите число B:");
                if (uint.TryParse(Console.ReadLine(), out b))
                {

                    if (b<a)
                    {
                        uint buffer = a;
                        a = b;
                        b = buffer;
                    }

                    if (a>1)
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
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введены не корректные данные");
                    Console.ResetColor();
                    goto enterB;

                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены не корректные данные");
                Console.ResetColor();
                goto enterA;
            }

            Console.ReadLine();
        }


    }
}
