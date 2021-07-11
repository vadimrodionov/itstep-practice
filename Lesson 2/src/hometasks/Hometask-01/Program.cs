using System;
using System.Threading;

namespace artem_buzinov.Hometask_01
{
    /// <summary>
    /// Так как условие задания было неполным,
    /// я выбрал фиксированный размер стартового массива из 10 элементов 
    /// и строил алгоритм выполнения изходя из этого
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\tУдаление нулей из массива и замена свободных ячеек на -1\n");
            Thread.Sleep(3000);
            Console.ResetColor();
            Console.Clear();

            int[] arr = new int[10] {1,2,0,4,0,9,11,18,0,15 };
            Console.WriteLine("Вывод массива\n");
            foreach (int i in arr)
            {
                Console.Write(i+"\t");
            }
            Console.WriteLine();

            Console.WriteLine("\nУдаление нулей и замена свободного места\n");
            Thread.Sleep(3000);
            int nullCounter=0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==0)
                {
                    nullCounter++;
                }
            }

            int[] arr2 = new int[arr.Length];

            for (int i = 0,j=0; i < arr.Length;i++,j++)
            {
                if (arr[i]==0)
                {
                    i++;
                }
                arr2[j] = arr[i];
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                if (arr2[i]==0)
                {
                    arr2[i] = -1;
                }
            }

            foreach (int i in arr2)
            {
                Console.Write(i + "\t");
            }


            Console.ReadLine();
        }
    }
}
