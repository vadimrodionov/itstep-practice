using System;

namespace vovazuev.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа сжимает массив, удаляя из него все 0, и заполняя освободившиеся справа элементы значениями –1.\n");
            // Создаем массив и заполняем его случайными числами
            Random rand = new Random();
            int[] arr = new int[10];
            for(int i = 0; i < 10; ++i)
            {
                arr[i] = rand.Next(3);
            }
            // Выводим исходный массив
            Console.Write("Исходный массив: ");
            foreach (int n in arr)
            {
                Console.Write($"{n} ");
            }
            Console.WriteLine("\n");
            // Отсортировываем 0 вправо
            for (int i = 0; i < 10; ++i)
            {
                for (int j = 0; j < 9 - i; ++j)
                {
                    if (arr[j] == 0 && arr[j + 1] != 0)
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            // Заменяем 0 на - 1
            for (int i = 0; i < 10; ++i)
            {
                if (arr[i] == 0)
                {
                    arr[i] = -1;
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
