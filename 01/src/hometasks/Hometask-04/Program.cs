using System;

namespace BogdanUdincev.Hometask_04
{
    class Program
    {
        static void Main(string[] args)
        {
            uint A, B;
            Console.WriteLine("Введите число A и число B (A < B): ");
            A = uint.Parse(Console.ReadLine());
            B = uint.Parse(Console.ReadLine());
            for (int i = (int)A; i <= (int)B; i++)
            {
                for (int l = 0; l < (int)A; l++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
                A++;
            }
        }
    }
}
