using System;

namespace artem_buzinov.Hometask_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(2,3);
            Fraction f2 = new Fraction(3,4);
            Fraction f3 = new Fraction();
            f3 = f1 - f2;
            f1.Print();
            f2.Print();
            f3.Print();

            if (f1>f2)
            {
                Console.WriteLine("F1 больше");
            }
            else
            {
                Console.WriteLine("F2 больше");
            }

        }
    }
}
