using System;

namespace ElenaPlotnikova.Hometask_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа меняет местами заданные столбцы в двумерном массиве.");
            Console.WriteLine("");
            int n = 0;  //строки
            int m = 0;  //столбцы
            Console.WriteLine("Введите размер массива");
            Console.Write("Количество строк: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Количество столбцов: ");
            m = int.Parse(Console.ReadLine());

            int[,] array = new int[n, m];
            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    array[i, j] = rand.Next(100);
            }
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.Write("Введите номер первого столбца: ");
            int column1 = int.Parse(Console.ReadLine());
            Console.Write("Введите номер второго столбца: ");
            int column2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int index = array[i, column1];
                array[i, column1] = array[i, column2];
                array[i, column2] = index;
            }
            Console.WriteLine("Массив с переставленными столбцами: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + "  ");
                }
                Console.WriteLine();
            }
        }
    }
}
    
