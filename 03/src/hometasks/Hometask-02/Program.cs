using System;

namespace UdincevBogdan.Hometask_02
{
    class Complex
    {
        public double r, i;

        public Complex()
        {
            this.r = 0.0;
            this.i = 0.0;
        }

        public static Complex Sum(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r + b.r;
            res.i = a.i + b.i;
            return res;
        }

        public static Complex Multiplication(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r * b.r - a.i * b.i;
            res.i = a.i * b.r + a.r * b.i;
            return res;
        }

        public static Complex Subtract(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.r = a.r - b.r;
            res.i = a.i - b.i;
            return res;
        }

        public static Complex operator +(Complex a, Complex b)
        {
            return Complex.Sum(a, b);
        }

        public static Complex operator -(Complex a, Complex b)
        {
            return Complex.Subtract(a, b);
        }

        public static Complex operator *(Complex a, Complex b)
        {
            return Complex.Multiplication(a, b);
        }

        public override string ToString()
        {
            return String.Format("{0} + i{1}", this.r, this.i);
        }

        public void Print(Complex a)
        {
            Console.Write(a);
        }

        public void PrintLine(Complex a)
        {
            Console.WriteLine(a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex();
            Complex c2 = new Complex(); 
            Console.Write("Введите целую часть первого комплексного числа: ");
            c1.r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            c1.i = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите целую часть второго комплексного числа: ");
            c2.r = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите мнимую часть первого комплексного числа: ");
            c2.i = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("Введенные комплексные числа: ");
            c1.PrintLine(c1);
            c2.PrintLine(c2);
            Console.WriteLine("\nДля продолжения нажмите [Enter]");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Сложение комплексных чисел:       {0} + {1}i", (c1 + c2).r, (c1 + c2).i);
            Console.WriteLine("Умножение комплексных чисел:      {0} + {1}i", (c1 * c2).r, (c1 * c2).i);
            Console.WriteLine("Вычитание комплексных чисел:      {0} + {1}i", (c1 - c2).r, (c1 - c2).i);
            Console.WriteLine("\nДля выхода из программы нажмите [Enter]");
            Console.ReadLine();
        }
    }
}
