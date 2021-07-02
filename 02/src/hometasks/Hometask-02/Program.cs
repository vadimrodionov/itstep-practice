using System;

namespace vovazuev.Hometask_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа преобразовывает массив так, чтобы сначала шли все отрицательные элементы, а потом положительные(0 считается положительным).\n");
            // Создаем массив и заполняем его случайными числами
            Random rand = new Random();
            int dimension = 10;
            int[] arr = new int[dimension];
            for (int i = 0; i < dimension; ++i)
            {
                arr[i] = rand.Next(-10, 10);
            }
            // Выводим исходный массив
            Console.Write("Исходный массив: ");
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine("\n");
            // Отсортировываем отрицательные числа влево
            for (int i = 0; i < dimension; ++i)
            {
                for (int j = 0; j < dimension - i - 1; ++j)
                {
                    if (arr[j] > 0 && arr[j + 1] < 0)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            // Выводим конечный массив
            Console.Write("Конечный массив: ");
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
        }
    }
}
