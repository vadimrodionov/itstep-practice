using System;
using System.Threading;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Status(IssuingCenter center, Employee emp, Customer customer) 
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Прогресс:\n" +
                              $"Центр выдачи заказов: {center.Status};\n" +
                              $"Сотрудник центра: {emp.Status};\n" +
                              $"Заказчик: {customer.Status}");
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
            Console.WriteLine("Модель работы центра выдачи заказов\n");
            Thread.Sleep(2000);
            Console.WriteLine("Перед открытием\n");
            Status(center, emp, cust);
            Console.WriteLine("Прибыл грузовик для разгрузки\n");
            place.Invoke_TruckArrived();
            Status(center, emp, cust);
            Console.WriteLine("Прием товара окончен\n");
            place.Invoke_ReceptionIsOver();
            Status(center, emp, cust);
            Console.WriteLine("Грузовиик уехал\n");
            place.Invoke_TruckLeave();
            Status(center, emp, cust);
            Console.WriteLine("Открытие центра\n");
            emp.OpenCenter(center,cust);
            center.Invoke_OpenCenter();
            Status(center, emp, cust);
            Console.WriteLine("Начало обслуживания\n");
            cust.Invoke_EnterCenter();
            emp.Invoke_BeginService();
            Status(center, emp, cust);
            Console.WriteLine("В процессе обслуживания\n");
            cust.Invoke_StartService();
            Status(center, emp, cust);
            Console.WriteLine("В процессе обслуживания\n");
            emp.Invoke_AcceptedOrderNumber();
            cust.Invoke_ReportedOrder();
            Status(center, emp, cust);
            Console.WriteLine("Завершение обслуживания\n");
            emp.Invoke_TookAllGoods();
            cust.Invoke_ReceivedGoods();
            Status(center, emp, cust);
            Console.WriteLine("Завершение обслуживания\n");
            emp.Invoke_CloseOrder();
            cust.Invoke_AcceptedGoods();
            Status(center, emp, cust);
            Console.WriteLine("Закрытие центра\n");
            emp.CloseCenter(center,cust);
            center.Invoke_CloseCenter();
            Status(center, emp, cust);







        }
    }
}
