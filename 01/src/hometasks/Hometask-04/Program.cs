using System;

namespace vovazuev.Hometask_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа принимает 2 целых положительных числа (a < b) и выводит \nвсе числа от а до b, каждое число на новой строке, \nи количество выводов равно значению этого числа.\n");
            int a, b;
            Console.WriteLine("Введите целое положительное число (a): ");
            bool success1 = int.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Введите целое положительное число (b): причем b > a: ");
            bool success2 = int.TryParse(Console.ReadLine(), out b);
            if(success1 && success2)
            {
                if(a > 0 && b > 0)
                {
                    if(a < b)
                    {
                        for(int i = a; i <= b; ++i)
                        {
                            for(int j = 0; j < i; j++)
                            {
                                Console.Write(i + " ");
                            }
                            Console.Write("\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод: второе число должно быть больше первого.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод: числа должны быть положительными.");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не числа, либо не целые числа.");
            }
            
        }
    }
}
