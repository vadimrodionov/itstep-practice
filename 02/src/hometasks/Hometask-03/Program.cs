using System;
using System.Linq;

namespace ElenaPlotnikova.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа, предлагает пользователю ввести число " +
                "и считает, сколько раз это число встречается в массиве");
            Console.WriteLine("Введите размер массива: ");
            int index = 0;
            index = int.Parse(Console.ReadLine());
            Console.WriteLine("Массив: ");
            int[] array = new int[index];
            Random rand = new Random();
            for (int i = 0; i < index; i++)
            {
                array[i] = rand.Next(0, 10);
                Console.Write(array[i] + " ");
               
            }
            Console.WriteLine();
            Console.WriteLine("Введите любое число от 1 до 10: ");
            int value = 0;
            value = int.Parse(Console.ReadLine());
            if (value < 0)
            {
                Console.WriteLine("Вы ввели неверное число!");
            }
            else
            {
                var sum = array.Count(num => num == value);
                Console.WriteLine("Число повторяется " + sum + " раз(а)");
            }       
        }
    }
}
