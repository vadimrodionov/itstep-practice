using System;
using System.Threading;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Status(PlaceOfReceipt place, Employee emp, Customer customer) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"����� ������ �������:{place.Status};\n" +
                              $"��������� ������: {emp.Status};\n" +
                              $"��������: {customer.Status}");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
                
        }
    }
}
