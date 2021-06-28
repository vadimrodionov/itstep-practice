using System;

namespace buzinovartem.Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            const int COLS = 3;
            const int ROWS = 4;
            double[,] B = new double[COLS, ROWS];
            Random random = new Random();
            #region Fill arrays
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Заполнение массива А");
            System.Threading.Thread.Sleep(1000);

            for (int i = 0; i < 5; )
            {
                Console.WriteLine("Введите число " + (i + 1) + ":");
                var newNumber = int.TryParse(Console.ReadLine(), out int number);
                if (newNumber)
                {
                    A[i] = number;
                    i++;
                }
                else
                {
                    Console.WriteLine("Вы ввели не корректное значение");
                }
                
            }
            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    B[i, j] = random.NextDouble();
                }
            }

            #endregion
            #region Print arrays
            Console.WriteLine("Вывод массива А:\n ");

            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine("\n");
            Console.WriteLine("Вывод массива B: \n");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {

                    Console.Write(B[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
            #endregion

            #region MaxValue
            int maxValueA = A[0];

            for (int i = 0; i < 5; i++)
            {
                if (A[i]>maxValueA)
                {
                    maxValueA = A[i];
                }
            }

            Console.WriteLine($"Максимальное значение массива А: {maxValueA}");

            double maxValueB = B[0,0];

            for (int i = 0; i < COLS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    if (B[i,j]>maxValueB)
                    {
                        maxValueB = B[i, j];
                    }
                }
            }

            Console.WriteLine($"Максимальное значение массива В: {maxValueB}");
            #endregion

            #region MinValue
            int minValueA = A[0];

            for (int i = 0; i < 5; i++)
            {
                if (A[i] < minValueA)
                {
                   minValueA = A[i];
                }
            }

            Console.WriteLine($"Минимальное значение массива А: {minValueA}");

            double minValueB = B[0, 0];

            for (int i = 0; i < COLS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    if (B[i, j] < minValueB)
                    {
                        minValueB = B[i, j];
                    }
                }
            }

            Console.WriteLine($"Максимальное значение массива В: {minValueB}");

            #endregion

            #region Sum
            int sumA = 0;

            for (int i = 0; i < 5; i++)
            {
                sumA += A[i];
            }

            Console.WriteLine($"Сумма элементов массива А: {sumA}");

            double sumB = 0;

            for (int i = 0; i < COLS; i++)
            {
                for (int j = 0; j < ROWS; j++)
                {
                    sumB += B[i, j];
                }
            }

            Console.WriteLine($"Сумма элементов массива B: {sumB}");
            #endregion

            

            Console.ReadLine();
        }
    }
}
