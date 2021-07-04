using System;
using System.Threading;

namespace artem_buzinov.Hometask_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t\tSwap rows in array\n");
            Thread.Sleep(3000);
            Console.ResetColor();
            Console.Clear();

            #region array creation and fill
            Random random = new Random();
            int[,] arr = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    arr[i, j] = random.Next(99);
                }
            }
            #endregion

            #region вывод базового массива
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            #endregion

            Console.WriteLine("\nВведите номер столбцов для замены\n");
            Thread.Sleep(2000);
        begin_firstRow:
            Console.WriteLine("Первый столбец: ");
            int firstRow;
            int secondRow;
            if (int.TryParse(Console.ReadLine(),out firstRow))
            {
                if (firstRow>=10||firstRow<0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Неверный индекс. " +
                                      "Индекс должен быть не больше 10 и не меньше 0");
                    Console.ResetColor();
                    goto begin_firstRow;
                }
                begin_secondRow:
                Console.WriteLine("Второй столбец: ");
                if (int.TryParse(Console.ReadLine(), out secondRow))
                {
                    if (secondRow >= 10 ||secondRow < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Неверный индекс. " +
                                          "Индекс должен быть не больше 10 и не меньше 0");
                        Console.ResetColor();
                        goto begin_secondRow;
                    }

                    if (secondRow==firstRow)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Индексы не могут быть равны");
                        Console.ResetColor();
                        goto begin_secondRow;
                    }
                    for (int i = 0; i < 10; i++)
                    {
                        int buffer = arr[i, firstRow];
                        arr[i, firstRow] = arr[i, secondRow];
                        arr[i, secondRow] = buffer;
                    }

                    Console.WriteLine("Массив после замены столбцов:\n");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write(arr[i, j] + "\t");
                        }
                        Console.WriteLine();
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы ввели не корректные данные");
                    Console.ResetColor();
                    goto begin_secondRow;
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Вы ввели не корректные данные");
                Console.ResetColor();
                goto begin_firstRow;

            }





            Console.ReadLine();
        }
    }
}
