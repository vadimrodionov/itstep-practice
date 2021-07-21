using System;

namespace ElenaPlotnikova.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Программа cжимает массив, удалив из него все 0, и заполняет освободившиеся справа" +
                " элементы значениями –1.");
            int[] array = new int[] { 0, 1, 2, 3, 0, 4, 5, 0, 6, 0, 7, 8, 9, 0, 10 };
            Console.WriteLine("Массив 1: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();

            Console.WriteLine("Массив 2: ");
            int zero = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    zero++;
                }
                else
                {
                    array[i - zero] = array[i];
                }
            }
            Array.Resize(ref array, array.Length - zero);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            for (int j = array.Length - zero; j < array.Length; j++)
            {
                array[j] = -1;
                Console.Write(array[j]);
            }      
        }
    }
}
