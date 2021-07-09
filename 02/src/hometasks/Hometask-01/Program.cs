using System;

namespace UdincevBogdan.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[] { 0, 9, 9, 0, 0, 0 };
            int n = mas.Length;
            for (int i = 0; i < n; i++)
            {
                if (mas[i] == 0)
                {
                    n--;
                    for (int j = i; j < n; j++)
                    {
                        mas[j] = mas[j + 1];
                    }
                    mas[n] = -1;
                    i--;
                }
            }
            foreach (int i in mas)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
        }
    }
}
