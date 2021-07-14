//Вывести все целые числа от A до B включительно; каждое число должно выводиться на новой строке;
//При этом каждое число должно выводиться количество раз, равное его значению.

using System;

namespace ElenaPlotnikova.Hometask_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целые положительные числа A и B, при этом A < B");
            Console.WriteLine("Число A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Число B: ");
            int b = int.Parse(Console.ReadLine());
            if (a >= b)
            {
                Console.WriteLine("Ошибка! Число A должно быть меньше числа B!");
            }
            else
            {
                for (Console.WriteLine(); a <= b; Console.WriteLine(), a++)
                for (int i = 1; i <= a; i++)
                Console.Write("{0}", a);
            }
        }
    }
}
