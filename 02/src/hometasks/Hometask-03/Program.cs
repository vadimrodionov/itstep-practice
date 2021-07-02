using System;

namespace vovazuev.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа предлагает пользователю ввести число и считает, сколько раз это число встречается в массиве.\n");
            Console.WriteLine("Введите целое число от 1 до 9: ");
            int number;
            bool success = int.TryParse(Console.ReadLine(), out number);
            if(success)
            {
                if(number > 0 && number < 10)
                {
                    // Создаем массив и заполняем его случайными числами
                    Random rand = new Random();
                    int dimension = 20;
                    int[] arr = new int[dimension];
                    for (int i = 0; i < dimension; ++i)
                    {
                        arr[i] = rand.Next(10);
                    }
                    // Выводим исходный массив и считаем, сколько раз в нём встречается введенное число
                    int count = 0;
                    Console.Write("Исходный массив: ");
                    foreach (int n in arr)
                    {
                        if (n == number) ++count;
                        Console.Write($"{n} ");
                    }
                    Console.WriteLine($"\nВведенное число встречается в данном массиве {count} раз.\n");
                }
                else
                {
                    Console.WriteLine("Неверный ввод. Ружно было ввести число от 1 до 9");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Неверный ввод. Нужно было ввести целое число.");
                return;
            }
        }
    }
}
