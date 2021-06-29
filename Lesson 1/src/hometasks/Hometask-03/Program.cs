using System;

namespace BuzinovArtem.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\t\t\t\t\tИзменение регистра символов");
            System.Threading.Thread.Sleep(3000);
            Console.ResetColor();
            begin:
            Console.WriteLine( "Введите буквенный символ");
            char variable;
            if (char.TryParse(Console.ReadLine(),out variable))
            {
                int integer=(int)variable;

                if (integer>=65&&integer<=90||integer>=97&&integer<=122)
                {
                    if (integer >= 65 && integer <= 90)
                    {
                        integer += 32;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Символ в нижнем регистре: {(char)integer}");
                        Console.ResetColor();
                      
                    }
                    else
                    {
                        integer -= 32;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Символ в верхнем регистре: {(char)integer}");
                        Console.ResetColor();
                      
                    }
                    
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введены не корректные данные");
                    Console.ResetColor();
                    goto begin;
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Введены не корректные данные");
                Console.ResetColor();
                goto begin;
            }
            
            
        }
    }
}
