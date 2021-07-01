using System;

namespace vovazuev.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа считывает символы с клавиатуры, пока не будет введена точка. Программа считает количество введенных пользователем пробелов.");
            char key;
            int spaces = 0;
            do
            {
                key = Console.ReadKey().KeyChar;
                if (key == ' ') ++spaces;
            }
            while (key != '.');
            Console.WriteLine($"Количество введенных пробелов: {spaces}.");
        }
    }
}
