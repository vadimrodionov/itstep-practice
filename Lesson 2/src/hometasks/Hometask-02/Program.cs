using System;
using System.Threading;

namespace artem_buzinov.Hometask_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tСортировка по знаку\n");
            Thread.Sleep(3000);
            Console.ResetColor();
            Console.Clear();

            int[] arr = new int[10] { -1, 2, 0, -4, 0, -9, -11, 18, 0, 15 };
            Console.WriteLine("Вывод массива\n");
            foreach (int i in arr)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine();
            Thread.Sleep(3000);
            int[] arr2 = new int[arr.Length];
            int counter = 0;

            for (int i = 0,j=0; i < arr.Length; i++)
            {
                if (arr[i]<0)
                {
                    arr2[j]=arr[i];
                    j++;
                    counter++;
                }
            }

            for (int i = 0, j = counter; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    arr2[j] = arr[i];
                    j++;
                }
            }

            Console.WriteLine("\nВывод массива после сортировки по знаку: \n");
            Thread.Sleep(3000);
            foreach (int i in arr2)
            {
                Console.Write(i + "\t");
            }
            Console.WriteLine(); ;


        }
    }
}
