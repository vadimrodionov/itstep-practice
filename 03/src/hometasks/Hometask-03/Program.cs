using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UdincevBogdan.Hometask_03
{
    class Fraction
    {
        public int Numerator;
        public int Denominator;

        public Fraction()
        {
            Numerator = 1;
            Denominator = 1;
        }
        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public string PrintUsual()
        {
            return (Numerator + "/" + Denominator);
        }
        public bool CorrectFraction()
        {
            if (Numerator > Denominator) return false;
            else return true;
        }
        public double Decimal()
        {
            return (double)Numerator / Denominator;
        }
        public Fraction Parse(string str)
        {
            int numerator = 1, denominator = 1;
            string[] vals = str.Split('/');
            if (vals.Length > 2)
                throw new ArgumentException("Строке может быть только одна дробная черта!");
            numerator = int.Parse(vals[0]);
            if (vals.Length > 1)
                denominator = int.Parse(vals[1]);
            return new Fraction(numerator, denominator);
        }

        public override bool Equals(object obj)
        {
            return obj is Fraction fraction &&
                   Numerator == fraction.Numerator &&
                   Denominator == fraction.Denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public static bool operator ==(Fraction a, Fraction b) => a.Decimal().Equals(b.Decimal());
        public static bool operator !=(Fraction a, Fraction b) => !a.Decimal().Equals(b.Decimal());
        public static bool operator <(Fraction a, Fraction b) => a.Decimal() < b.Decimal();
        public static bool operator >(Fraction a, Fraction b) => a.Decimal() > b.Decimal();
        public static bool operator >=(Fraction a, Fraction b) => a.Decimal() > b.Decimal() || a.Decimal() == b.Decimal();
        public static bool operator <=(Fraction a, Fraction b) => a.Decimal() < b.Decimal() || a.Decimal() == b.Decimal();

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();
            result.Numerator = (fraction1.Numerator * fraction2.Denominator) + (fraction2.Numerator * fraction1.Denominator);
            result.Denominator = fraction1.Denominator * fraction2.Denominator;
            return result;
        }
        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();
            result.Numerator = (fraction1.Numerator * fraction2.Denominator) - (fraction2.Numerator * fraction1.Denominator);
            result.Denominator = fraction1.Denominator * fraction2.Denominator;
            return result;
        }
        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();
            result.Numerator = fraction1.Numerator * fraction2.Numerator;
            result.Denominator = fraction1.Denominator * fraction2.Denominator;
            return result;
        }
        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            Fraction result = new Fraction();
            result.Numerator = fraction1.Numerator * fraction2.Denominator;
            result.Denominator = fraction1.Denominator * fraction2.Numerator;
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction();
            Fraction fraction2 = new Fraction();
            Fraction result = new Fraction();

            Console.Write("Введите первую дробь: ");
            fraction1 = fraction1.Parse(Console.ReadLine());
            Console.Write("Введите вторую дробь: ");
            fraction2 = fraction2.Parse(Console.ReadLine());

            Console.WriteLine($"Дробь 1: {fraction1.PrintUsual()} или {fraction1.Decimal()}");
            Console.WriteLine($"Дробь 2: {fraction2.PrintUsual()} или {fraction2.Decimal()}");

            result = fraction1 + fraction2;
            Console.WriteLine($"Сложение: " + result.PrintUsual());
            result = fraction1 - fraction2;
            Console.WriteLine($"Вычетание: " + result.PrintUsual());
            result = fraction1 * fraction2;
            Console.WriteLine($"Умножение: " + result.PrintUsual());
            result = fraction1 / fraction2;
            Console.WriteLine($"Деление: " + result.PrintUsual());

            Console.WriteLine($"Правильность дроби 1: " + fraction1.CorrectFraction());
            Console.WriteLine($"Правильность дроби 2: " + fraction2.CorrectFraction());

            Console.WriteLine($"Дробь 1 == Дробь 2: " + (fraction1 == fraction2));
            Console.WriteLine($"Дробь 1 != Дробь 2: " + (fraction1 != fraction2));
            Console.WriteLine($"Дробь 1 > Дробь 2: " + (fraction1 > fraction2));
            Console.WriteLine($"Дробь 1 < Дробь 2: " + (fraction1 < fraction2));
            Console.WriteLine($"Дробь 1 >= Дробь 2: " + (fraction1 >= fraction2));
            Console.WriteLine($"Дробь 1 <= Дробь 2: " + (fraction1 <= fraction2));
        }
    }
}
