using System;

namespace vovazuev.Hometask_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа определяет, является ли номер билета \"счастливым\".");
            Console.WriteLine("Введите номер билета (6-значное число).");
            int number;
            bool success = int.TryParse(Console.ReadLine(), out number);
            if(success)
            {
                if(number / 100000 > 0 && number / 100000 < 10)
                {
                    int left = 0;
                    int right = 0;
                    for(int i = 0; i < 3; i++)
                    {
                        right += number % 10;
                        number /= 10;
                    }
                    for (int i = 0; i < 3; i++)
                    {
                        left += number % 10;
                        number /= 10;
                    }
                    if(left == right)
                    {
                        Console.WriteLine("Билет \"счастливый\".");
                    }
                    else
                    {
                        Console.WriteLine("Билет не \"счастливый\".");
                    }
                }
                else
                {
                    Console.WriteLine("Вы ввели не 6-значное число.");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не число.");
            }
        }
    }
}
