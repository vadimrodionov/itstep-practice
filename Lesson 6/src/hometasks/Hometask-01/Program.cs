using System;
using System.Threading;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Status(IssuingCenter center, Employee emp, Customer customer) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"����� ������ �������: {center.Status};\n" +
                              $"��������� ������: {emp.Status};\n" +
                              $"��������: {customer.Status}");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
            IssuingCenter center = new IssuingCenter();
            Employee emp = new Employee();
            Customer cust = new Customer();
            PlaceOfReceipt place = new PlaceOfReceipt();

            Status(center, emp, cust);
                
        }
    }
}
