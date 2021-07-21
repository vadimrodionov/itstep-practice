using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("This is a programm that'll help you count amount of symbols untill the symbol .")
            Console.WriteLine("Enter some symbols: ");
            char input;
            int spaceCount = 0;
            do
            {
                input = (char)Console.ReadKey(); // по разному пытался, не понимаю как правильно это сделать
                if (input == ' ')
                    spaceCount++;
            }
            while (input != '.');

            Console.WriteLine("Quantity of spaces: " + spaceCount);

        }
    }
}
