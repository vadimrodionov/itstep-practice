//Программа находит число, полученное при прочтении введенного целого числа справа налево

using System;
using System.Linq;

namespace ElenaPlotnikova.Hometask_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число: ");
            int number = int.Parse(Console.ReadLine());
            int reverse = int.Parse(new string(number.ToString().Reverse().ToArray()));
            Console.Write("Реверс целого числа: " + reverse);

        }
    }
}
