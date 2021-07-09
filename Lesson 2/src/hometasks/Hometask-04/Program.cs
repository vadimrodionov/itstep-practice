using System;
using System.Threading;

namespace artem_buzinov.Hometask_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tSwap rows in array\n");
            Thread.Sleep(3000);
            Console.ResetColor();
            Console.Clear();
            #region array creation and fill
            Random random = new Random();
            int[,] arr = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = random.Next(99);
                }
            }
            #endregion
            #region вывод базового массива
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion
            Console.WriteLine("\nВведите номер столбцов для замены\n");
            Thread.Sleep(2000);
            int firstRow;
            int secondRow;
            do
            {
                Console.WriteLine("Первый столбец: ");
            }
            while (!int.TryParse(Console.ReadLine(), out firstRow) || firstRow >= 10 && firstRow > 0);

            do
            {
                Console.WriteLine("Второй столбец: ");
            }
            while (!int.TryParse(Console.ReadLine(), out secondRow) || secondRow >= 10 && secondRow > 0);

            for (int i = 0; i < 10; i++)
            {
                int buffer = arr[i, firstRow];
                arr[i, firstRow] = arr[i, secondRow];
                arr[i, secondRow] = buffer;
            }
            Console.WriteLine("Массив после замены столбцов:\n");
            Console.ForegroundColor = ConsoleColor.Yellow;
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

