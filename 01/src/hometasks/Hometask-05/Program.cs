using System;

namespace vovazuev.Hometask_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа принимает число и обращает его разряды.\n");
            Console.WriteLine("Введите целое число: ");
            int number;
            int result = 0;
            bool success = int.TryParse(Console.ReadLine(), out number);
            if(success)
            {
                // Определяем разрядность введенного числа
                int temp = number;
                int digits = 0;
                while(temp != 0)
                {
                    temp /= 10;
                    ++digits;
                }
                // Обращаем число
                for (int i = digits; i > 0; --i)
                {
                    result += (int)Math.Pow(10, i - 1) * (number % 10);
                    number /= 10;
                }
                Console.WriteLine("Обращенное число: " + result);
            }
            else
            {
                Console.WriteLine("Неверный ввод. Нужно ввести целое число.");
            }
        }
    }
}
