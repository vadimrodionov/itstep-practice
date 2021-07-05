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
        private int numenator;
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
            this.numenator = numenator;
            this.denominator = denominator;
        }
        public Fraction(Fraction fraction) 
        {
            this.numenator = fraction.numenator;
            this.denominator = fraction.denominator;
        } //copy ctor
        #endregion
        #region Operators_overload
        public static Fraction operator+(Fraction f1, Fraction f2) 
        {
            return new Fraction
            {
                numenator = ((f1.numenator * f2.denominator) + (f1.denominator * f2.numenator)),
                denominator = (f1.denominator*f2.denominator)
            };
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction
            {
                numenator = ((f1.numenator * f2.denominator) - (f1.denominator * f2.numenator)),
                denominator = (f1.denominator * f2.denominator)
            };
        }
        public static Fraction operator*(Fraction f1, Fraction f2) 
        {
            return new Fraction
            {
                numenator = f1.numenator * f2.numenator,
                denominator = f1.denominator * f2.denominator
            };
        }
        public static Fraction operator/(Fraction f1, Fraction f2) 
        {
            return new Fraction
            {
                numenator = f1.numenator*f2.denominator,
                denominator = f1.denominator*f2.numenator
            };
        }
        public static bool operator==(Fraction f1, Fraction f2) 
        {
            return (f1.numenator * f2.denominator == f2.numenator * f1.denominator);
        }
        public static bool operator !=(Fraction f1, Fraction f2)
        {
            return (f1.numenator * f2.denominator != f2.numenator * f1.denominator);
        }
        public static bool operator >(Fraction f1, Fraction f2) 
        {
            return (f1.numenator * f2.Denominator > f2.numenator * f1.Denominator);
        }
        public static bool operator <(Fraction f1, Fraction f2)
        {
            return (f1.numenator * f2.Denominator < f2.numenator * f1.Denominator);
        }
        public static bool operator >=(Fraction f1, Fraction f2)
        {
            return (f1.numenator * f2.Denominator >= f2.numenator * f1.Denominator);
        }
        public static bool operator <=(Fraction f1, Fraction f2)
        {
            return (f1.numenator * f2.Denominator > f2.numenator * f1.Denominator);
        }
        public static bool operator true(Fraction f1) 
        {
            if (f1.numenator < f1.denominator)
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
            if (f1.numenator > f1.denominator)
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
        public void Print() 
        {
            Console.WriteLine($"{this.numenator}/{this.denominator}\n");
        }
        #endregion


    }
}
