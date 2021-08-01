using System;
using System.Threading;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Status(PlaceOfReceipt place, Employee emp, Customer customer) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Центр выдачи заказов:{place.Status};\n" +
                              $"Сотрудник центра: {emp.Status};\n" +
                              $"Заказчик: {customer.Status}");
            Console.ResetColor();
        }
        static void Main(string[] args)
        {
                
        }
    }
}
