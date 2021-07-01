using System;

namespace vovazuev.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Эта программа считывает с клавиатуры и конвертирует все символы нижнего регистра в символы верхнего регистра, и наоборот.");
            Console.WriteLine("Введите букву ASCII в верхнем или нижнем регистре: ");
            int key = Console.ReadKey().KeyChar;
            if(key >= 65 && key <= 90)
            {
                key += 32;
                Console.WriteLine("\nЭта буква в нижнем регистре: " + (char)key);
            }
            else if(key >= 97 && key <= 122)
            {
                key -= 32;
                Console.WriteLine("\nЭта буква в верхнем регистре: " + (char)key);
            }
            else
            {
                Console.WriteLine("\nВы ввели не букву ASCII.");
                return;
            }
        }
    }
}
