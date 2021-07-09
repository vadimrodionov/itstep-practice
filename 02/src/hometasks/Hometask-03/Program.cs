using System;

namespace UdincevBogdan.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 12, 1, 12, 12, 5, 6, 5, 7};
            foreach(int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.Write("Введи число: ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == num) sum++;
            }
            Console.WriteLine($"Всего совпадений: {sum}");
        }
    }
}
