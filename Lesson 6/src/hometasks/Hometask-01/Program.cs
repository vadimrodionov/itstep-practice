using System;
using System.Threading;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Status(IssuingCenter center, Employee emp, Customer customer) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"��������:\n" +
                              $"����� ������ �������: {center.Status};\n" +
                              $"��������� ������: {emp.Status};\n" +
                              $"��������: {customer.Status}");
            Console.ResetColor();
            Console.WriteLine("Press any key to continue.........");
            Console.ReadKey();
            Console.Clear();
        }
        static void Main(string[] args)
        {
            IssuingCenter center = new IssuingCenter();
            Employee emp = new Employee();
            Customer cust = new Customer();
            PlaceOfReceipt place = new PlaceOfReceipt(emp);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("������ ������ ������ ������ �������\n");
            Thread.Sleep(2000);
            Console.WriteLine("����� ���������\n");
            Status(center, emp, cust);
            Console.WriteLine("������ �������� ��� ���������\n");
            place.Invoke_TruckArrived();
            Status(center, emp, cust);
            Console.WriteLine("����� ������ �������\n");
            place.Invoke_ReceptionIsOver();
            Status(center, emp, cust);
            Console.WriteLine("��������� �����\n");
            place.Invoke_TruckLeave();
            Status(center, emp, cust);
            Console.WriteLine("�������� ������\n");
            emp.OpenCenter(center,cust);
            center.Invoke_OpenCenter();
            Status(center, emp, cust);
            Console.WriteLine("������ ������������\n");
            cust.Invoke_EnterCenter();
            emp.Invoke_BeginService();
            Status(center, emp, cust);





        }
    }
}
