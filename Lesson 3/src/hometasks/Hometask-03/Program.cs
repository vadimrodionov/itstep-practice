using System;
using System.Threading;

namespace artem_buzinov.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("\t\t\t\t\tДействия над дробями");
            //Thread.Sleep(3000);
            //Console.ResetColor();
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
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Умножение дробей\n");
                        Console.ResetColor();
                        string case1_firstFraction;
                        string case1_secondFraction; 
                        do
                        {
                            Console.WriteLine("Введите дробь №1: ");
                            case1_firstFraction = Console.ReadLine();

                        } while (!case1_firstFraction.Contains('/'));
                        do
                        {
                            Console.WriteLine("Введите дробь №2: ");
                            case1_secondFraction = Console.ReadLine();
                        } while (!case1_secondFraction.Contains('/'));
                        Console.Clear();
                        F1 = Fraction.Parse(case1_firstFraction);
                        F2 = Fraction.Parse(case1_secondFraction);
                        F3 = F1 * F2;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Результат умножения: ");
                        F3.Print();
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    #endregion
                    case 2:
                        #region Case_2
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Деление дробей\n");
                        Console.ResetColor();
                    Case2_First_fraction:
                        Console.WriteLine("Введите дробь №1: ");
                        string case2_firstFraction = Console.ReadLine();
                        if (!case2_firstFraction.Contains('/'))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неверный формат!");
                            Console.ResetColor();
                            goto Case2_First_fraction;
                        }
                    Case2_Second_fraction:
                        Console.WriteLine("Введите дробь №2: ");
                        string case2_secondFraction = Console.ReadLine();
                        if (!case2_secondFraction.Contains('/'))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неверный формат!");
                            Console.ResetColor();
                            goto Case2_Second_fraction;
                        }
                        Console.Clear();
                        F1 = Fraction.Parse(case2_firstFraction);
                        F2 = Fraction.Parse(case2_secondFraction);
                        F3 = F1 / F2;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Результат деления: ");
                        F3.Print();
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    #endregion
                    case 3:
                        #region Case_3
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Сложение дробей\n");
                        Console.ResetColor();
                    Case3_First_fraction:
                        Console.WriteLine("Введите дробь №1: ");
                        string case3_firstFraction = Console.ReadLine();
                        if (!case3_firstFraction.Contains('/'))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неверный формат!");
                            Console.ResetColor();
                            goto Case3_First_fraction;
                        }
                    Case3_Second_fraction:
                        Console.WriteLine("Введите дробь №2: ");
                        string case3_secondFraction = Console.ReadLine();
                        if (!case3_secondFraction.Contains('/'))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неверный формат!");
                            Console.ResetColor();
                            goto Case3_Second_fraction;
                        }
                        Console.Clear();
                        F1 = Fraction.Parse(case3_firstFraction);
                        F2 = Fraction.Parse(case3_secondFraction);
                        F3 = F1 + F2;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Результат сложения: ");
                        F3.Print();
                        Console.ResetColor();
                        Console.ReadLine();
                        #endregion
                        break;
                    case 4:
                        #region Case_4
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Вычитание дробей\n");
                        Console.ResetColor();
                    Case4_First_fraction:
                        Console.WriteLine("Введите дробь №1: ");
                        string case4_firstFraction = Console.ReadLine();
                        if (!case4_firstFraction.Contains('/'))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неверный формат!");
                            Console.ResetColor();
                            goto Case4_First_fraction;
                        }
                    Case4_Second_fraction:
                        Console.WriteLine("Введите дробь №2: ");
                        string case4_secondFraction = Console.ReadLine();
                        if (!case4_secondFraction.Contains('/'))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Неверный формат!");
                            Console.ResetColor();
                            goto Case4_Second_fraction;
                        }
                        Console.Clear();
                        F1 = Fraction.Parse(case4_firstFraction);
                        F2 = Fraction.Parse(case4_secondFraction);
                        F3 = F1 - F2;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("Результат вычитания: ");
                        F3.Print();
                        Console.ResetColor();
                        Console.ReadLine();
                        break;
                    #endregion
                    case 5:
                        break;
                    default:
                        break;
                }

            }

        }
    }
}
