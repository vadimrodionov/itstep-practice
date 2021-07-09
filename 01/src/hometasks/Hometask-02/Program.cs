using System;

namespace BogdanUdincev.Hometask_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] bil = new int[6];
            int sum1 = 0, sum2 = 0;
            Console.WriteLine("Введите 6 цифр билета:");
            for (int i = 0; i < bil.Length; i++)
            {
                Console.Write($"{i + 1}. ");
                bil[i] = (Console.ReadKey().KeyChar - '0');
                Console.WriteLine();
            }
            for (int i = 0; i < bil.Length - 3; i++) sum1 += bil[i];
            for (int i = 3; i < bil.Length; i++) sum2 += bil[i];
            Console.WriteLine("Билет счастливый: " + (sum1 == sum2 ? true : false));
        }
    }
}
