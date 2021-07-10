using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_03
{
    class Fraction
    {
        #region Fields
        private int numerator;
        private int denominator;
        #endregion
        #region Properties
        public int Numenator { get; set; }
        public int Denominator { get; set; }
        #endregion
        #region Constructors
        public Fraction() { } // default ctor
        public Fraction(int numenator, int denominator) 
        {
            this.numerator = numenator;
            this.denominator = denominator;
        }
        public Fraction(Fraction fraction) 
        {
            this.numerator = fraction.numerator;
            this.denominator = fraction.denominator;
        } //copy ctor
        #endregion
        #region Operators_overload
        public static Fraction operator+(Fraction f1, Fraction f2) 
        {
            return new Fraction
            {
                numerator = ((f1.numerator * f2.denominator) + (f1.denominator * f2.numerator)),
                denominator = (f1.denominator*f2.denominator)
            };
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            Fraction NewFraction=new Fraction 
            {
                numerator = ((f1.numerator * f2.denominator) - (f2.numerator * f1.denominator)),
                denominator = (f1.denominator * f2.denominator)
            };
            if (NewFraction.Numenator==0)
            {
                return new Fraction(0,0);
            }
            else
            {
                return NewFraction;
            }
        }
        public static Fraction operator*(Fraction f1, Fraction f2) 
        {
            return new Fraction
            {
                numerator = f1.numerator * f2.numerator,
                denominator = f1.denominator * f2.denominator
            };
        }
        public static Fraction operator/(Fraction f1, Fraction f2) 
        {
            return new Fraction
            {
                numerator = f1.numerator*f2.denominator,
                denominator = f1.denominator*f2.numerator
            };
        }
        public static bool operator==(Fraction f1, Fraction f2) 
        {
            return (f1.numerator * f2.denominator == f2.numerator * f1.denominator);
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return (f1.numerator * f2.denominator != f2.numerator * f1.denominator);
        }
        public static bool operator >(Fraction f1, Fraction f2) 
        {
            return (f1.numerator * f2.denominator > f2.numerator * f1.denominator);
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            return (f1.numerator * f2.denominator < f2.numerator * f1.denominator);
        }
        public static bool operator >=(Fraction f1, Fraction f2)
        {
            return (f1.numerator * f2.denominator >= f2.numerator * f1.denominator);
        }
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            return (f1.numerator * f2.denominator > f2.numerator * f1.denominator);
        }
        public static bool operator true(Fraction f1) 
        {
            if (f1.numerator < f1.denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
        public static bool operator false(Fraction f1)
        {
            if (f1.numerator > f1.denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion
        #region Methods
        public static Fraction Parse(string f)
        {

            if (!f.Contains('/'))
            {
                return new Fraction(0,0);
            }
            f = f.Replace(" ", "");
            int delimiter = f.IndexOf('/') + 1;
            string denominator = f.Substring(delimiter);
            string numerator = f.Remove(delimiter - 1);
            if (denominator == "0")
            {
                return new Fraction(0, 0);
            }
            return new Fraction
            {
                numerator = int.Parse(numerator),
                denominator = int.Parse(denominator)
            };
        }
        public static Fraction FInput(string message) 
        {
            string fraction;
            do
            {
                Console.WriteLine($"{message}");
                fraction = Console.ReadLine();

            } while (!fraction.Contains('/'));

           Fraction NewFraction = Fraction.Parse(fraction);
           return NewFraction;
        }
        public static void WriteColoredLine(ConsoleColor color, string message, bool ResetColor = false) 
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{message}");
            if (ResetColor)
            {
                Console.ResetColor();
            }
        }
        public static void Comparison(Fraction A, Fraction B) 
        {
            if (A==B)
            {
                WriteColoredLine(ConsoleColor.Yellow, "Дроби равны", true);
            }
            else if (A>B)
            {
                WriteColoredLine(ConsoleColor.Yellow, "Дробь 1 больше дроби 2 ", true);
            }
            else if (A<B)
            {
                WriteColoredLine(ConsoleColor.Yellow, "Дробь 1 меньше дроби 2 ", true);
            }
        }
        public void Print() 
        {
            Console.WriteLine($"{numerator}/{denominator}\n");
        }
        #endregion


    }
}
