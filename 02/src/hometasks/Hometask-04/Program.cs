using System;
using System.Runtime.InteropServices;

namespace UdincevBogdan.Hometask_04
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
            int m = 3, n = 3;
            int[,] array2d = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    array2d[i, j] = rand.Next(10);
                }
            }
            Print(array2d, m, n);
            int s1, s2;
            Console.WriteLine("Введите номера столбиков: ");
            s1 = int.Parse(Console.ReadLine());
            s2 = int.Parse(Console.ReadLine());
            int tmp;
            for (int i = 0; i < m; i++)
            {
                tmp = array2d[i, s1];
                array2d[i, s1] = array2d[i, s2];
                array2d[i, s2] = tmp;
            }
            Print(array2d, m, n);
        }
        static void Print(int[,] array2d, int m, int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array2d[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}