// Проверка трамвайного билета, является ли данный билет счастливым 

using System;
using System.Linq;

namespace ElenaPlotnikova.Hometask_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер трамвайного билета: ");
            string str = Console.ReadLine();
            char[] number = new char[str.Length];
            number = str.ToCharArray();
            int[] ticket_number = number.Select(s => Convert.ToInt32(s)).ToArray();
            if (number.Length != 6)
            {
                Console.WriteLine("Вы ввели неверное число!");
            }
            else
            {
                int leftNumber = 0;
                int rightNumber = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticket_number[i];
                    }
                    else rightNumber += ticket_number[i];
                }
                if (leftNumber == rightNumber)
                {
                    Console.WriteLine("У Вас счастливый билет!");
                }
                else Console.WriteLine("У Вас несчастливый билет!");
            }
        }
    }
}
