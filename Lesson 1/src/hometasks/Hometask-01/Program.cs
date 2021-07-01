using System;
using System.Threading;

namespace BuzinovArtem.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t\t\t\t��������� ���������� �������� � ����������");
            Thread.Sleep(3000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            char keySymbol = '0';
            byte counter = 0;
            while (keySymbol!='.')
            {
                if (keySymbol==' ')
                {
                    counter++;
                }
                Console.WriteLine("������� ������: ");
                if (char.TryParse(Console.ReadLine(), out keySymbol))
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"�� ����� '{keySymbol}'");
                }
                else
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("������� �� ���������� ��������");
                }
                Console.ResetColor();
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("���������� ������ ���������");
            Thread.Sleep(2000);
            Console.WriteLine($"������ ��� ������ {counter} ���(�)");
            Console.ReadLine();

        }
    }
}
