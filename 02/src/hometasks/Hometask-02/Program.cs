using System;

namespace ElenaPlotnikova.Hometask_02
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Программа преобразовает массив так,чтобы сначала шли все отрицательные элементы, а" +
                " потом положительные.");
             Console.WriteLine("Введите размер массива: ");
             int index = 0;
             index = int.Parse(Console.ReadLine());
             Console.WriteLine("Массив 1: ");
             int[] array = new int[index];
             Random rand = new Random();
             for (int i = 0; i < index; i++)
             {
                 array[i] = rand.Next(-100, 100); //ограничила разбег чисел, чтобы попадались и отрицательные и положительные числа
                 Console.Write(array[i] + " ");
             }
            //int[] array = new int[] {- 3,0,7,-4,4,-2,5};
            Console.WriteLine();
            Console.WriteLine("Массив 2: ");
            Array.Sort(array, (a, b) => Math.Sign(a) - Math.Sign(b));
            foreach (int a in array)
            {
                Console.Write($"{a} ");
            }
        }
    }
  
}
