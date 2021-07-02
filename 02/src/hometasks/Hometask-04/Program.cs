using System;

namespace vovazuev.Hometask_04
{
    class Program
    {
        static void printArr(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for(int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.Write("\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа в двумерном массиве порядка M на N меняет местами заданные столбцы.\n");
            int m, n;
            Console.WriteLine("Введите количество строк М массива (от 2 до 20): ");
            bool success1 = int.TryParse(Console.ReadLine(), out m);
            Console.WriteLine("Введите число столбцов N массива (от 2 до 20): ");
            bool success2 = int.TryParse(Console.ReadLine(), out n);
            if(success1 && success2)
            {
                if((m >= 2 && m <= 20) && (n >= 2 && n <= 20))
                {
                    Random rand = new Random();
                    int[,] arr = new int[m, n];
                    for(int i = 0; i < m; ++i)
                    {
                        for(int j = 0; j < n; ++j)
                        {
                            arr[i, j] = rand.Next(m);
                        }
                    }
                    Console.WriteLine("Исходный массив: ");
                    printArr(arr);
                    int col1, col2;
                    Console.WriteLine($"Введите индекс первого столбца для замены (от 0 до {n - 1}): ");
                    bool succ1 = int.TryParse(Console.ReadLine(), out col1);
                    Console.WriteLine($"Введите индекс второго столбца для замены (от 0 до {n - 1}): ");
                    bool succ2 = int.TryParse(Console.ReadLine(), out col2);
                    if(succ1 && succ2)
                    {
                        if(col1 == col2)
                        {
                            Console.WriteLine("Неверный ввод. Номера столбцов не должны совпадать.");
                            return;
                        }
                        if((col1 >=0 && col1 < n) && (col2 >= 0 && col2 < n))
                        {
                            for(int i = 0; i < m; ++i)
                            {
                                int temp = arr[i, col1];
                                arr[i, col1] = arr[i, col2];
                                arr[i, col2] = temp;
                            }
                            Console.WriteLine("Измененный массив: ");
                            printArr(arr);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Неверный ввод. Нужно было ввести целые числа.");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Введенные числа не входят в диапазон от 2 до 20.");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Нужно было ввести 2 целых числа.");
                return;
            }
        }
    }
}
