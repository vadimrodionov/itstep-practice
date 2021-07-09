using System;
using System.Threading;

namespace artem_buzinov.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tПоиск числа в массиве\n");
            Thread.Sleep(3000);
            Console.ResetColor();
            Console.Clear();
            Random random = new Random();
            int[,] arr = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = random.Next(99);
                }
            }
            int number;
            do
            {
                Console.WriteLine("Введите число для поиска в массиве:");
            } 
            while (!int.TryParse(Console.ReadLine(), out number));

                int countNumber = 0;
                for (int i = 0; i < 10; i++)
                {
                    for (int j = 0; j < 10; j++)
                    {
                        if (arr[i,j]==number)
                        {
                            countNumber++;
                        }
                    }
                    
                }
                Console.WriteLine($"Введенное число встречается в программае {countNumber}, раз(a)\n");
                Thread.Sleep(2000);

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
