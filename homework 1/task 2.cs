using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите номер трамвайного билета:  ");
            string str = Console.ReadLine();
            char[] ch = new char[str.Length];
            ch = str.ToCharArray();
            int[] ticketNumber = ch.Select(s => int.Parse(s.ToString())).ToArray();
            if (ch.Length == 6)
            {
                int leftNumber = 0;
                int rightNumber = 0;

                for (int i = 0; i < ch.Length; i++)
                {
                    if (i < 3)
                    {
                        leftNumber += ticketNumber[i];
                    }

                    else rightNumber += ticketNumber[i];
                }

                if (leftNumber == rightNumber)
                {
                    Console.WriteLine("У вас счастливый билет: {0} = {1}", leftNumber, rightNumber);
                }

                else Console.WriteLine("У вас не счастливый билет: {0} != {1}", leftNumber, rightNumber);
            }

            else Console.WriteLine("Число введено не правильно!");

            Console.Read();
        }
    }
}