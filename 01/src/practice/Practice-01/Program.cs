using System;

namespace BogdanUdincev.Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("������� ����������� � �����������: ");
            bool BTempF = double.TryParse(Console.ReadLine(), out double tempF);
            double tempC;
            if (BTempF)
            {
                tempC = (tempF - 32) * 5 / 9;
            }
            else
            {
                Console.WriteLine("Error!");
                return;
            }
            Console.WriteLine($"� ��������: {tempC}");
        }
    }
}
