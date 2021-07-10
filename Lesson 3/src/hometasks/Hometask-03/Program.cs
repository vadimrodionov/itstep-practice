using System;
using System.Threading;

namespace artem_buzinov.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction.WriteColoredLine(ConsoleColor.Green, "\t\t\t\t\tДействия над дробями", true);
            Thread.Sleep(3000);
            Console.Clear();
            int num;
            while (true)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("Выберите действие:\n" +
                                  "1. Умножение\n" +
                                  "2. Деление \n" +
                                  "3. Сложение \n" +
                                  "4. Вычитание \n" +
                                  "5. Сравнение ");

                } while (!int.TryParse(Console.ReadLine(), out num) || num < 1 || num > 5);
                Fraction F1;
                Fraction F2;
                Fraction F3;

                switch (num)
                {
                    case 1:
                        #region Case_1
                        Console.Clear();
                        Fraction.WriteColoredLine(ConsoleColor.Cyan, "Умножение дробей\n",true);
                        F1 = Fraction.FInput("Введите дробь №1");
                        F2 = Fraction.FInput("Введите дробь №2");
                        Console.Clear();
                        F3 = F1 * F2;
                        Fraction.WriteColoredLine(ConsoleColor.Yellow, "Результат умножения: ", false);
                        F3.Print();
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    #endregion
                    case 2:
                        #region Case_2
                        Console.Clear();
                        Fraction.WriteColoredLine(ConsoleColor.Cyan, "Деление дробей\n",true);
                        F1 = Fraction.FInput("Введите дробь №1");
                        F2 = Fraction.FInput("Введите дробь №2");
                        Console.Clear();
                        F3 = F1 / F2;
                        Fraction.WriteColoredLine(ConsoleColor.Yellow, "Результат деления: ", false);
                        F3.Print();
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    #endregion
                    case 3:
                        #region Case_3
                        Console.Clear();
                        Fraction.WriteColoredLine(ConsoleColor.Cyan, "Сложение дробей\n", true);
                        F1 = Fraction.FInput("Введите дробь №1");
                        F2 = Fraction.FInput("Введите дробь №2");
                        Console.Clear();
                        F3 = F1 + F2;
                        Fraction.WriteColoredLine(ConsoleColor.Yellow, "Результат сложения: ", false);
                        F3.Print();
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                        #endregion
                    case 4:
                        #region Case_4
                        Console.Clear();
                        Fraction.WriteColoredLine(ConsoleColor.Cyan, "Вычитание дробей\n", true);
                        F1 = Fraction.FInput("Введите дробь №1");
                        F2 = Fraction.FInput("Введите дробь №2");
                        Console.Clear();
                        F3 = F1 - F2;
                        Fraction.WriteColoredLine(ConsoleColor.Yellow, "Результат вычитания: ", false);
                        F3.Print();
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    #endregion
                    case 5:
                        Console.Clear();
                        Fraction.WriteColoredLine(ConsoleColor.Cyan, "Сравнение дробей\n", true);
                        F1 = Fraction.FInput("Введите дробь №1");
                        F2 = Fraction.FInput("Введите дробь №2");
                        Console.Clear();
                        Fraction.Comparison(F1, F2);
                        F1.Print();
                        F2.Print();
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }

            }

        }
    }
}
