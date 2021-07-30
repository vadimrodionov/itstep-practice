using System;
using System.Threading;
using artem_buzinov.Hometask_01.Actors;
using artem_buzinov.Hometask_01.Location;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            PlaceOfReceipt OZON = new PlaceOfReceipt();
            Employee employee = new Employee("Jack");
            DeliveryServiceTruck truck = new DeliveryServiceTruck();
            Console.WriteLine("Начало истории");
            Thread.Sleep(2000);
            OZON.CentreStatus_Call();
            Thread.Sleep(2000);
            Console.WriteLine(employee.Status); 
            employee.GoToCentre();
            Console.WriteLine(employee.Status);
            Thread.Sleep(2000);
            truck.TruckCometoCentre += employee.GoToOffload;
            Thread.Sleep(2000);
            truck.ComeToCentre_Call();
            Thread.Sleep(2000);
            Console.WriteLine(employee.Status);
            employee.OffloadFinished += employee.GoToCentre;
            employee.OffLoadFinished_Call();
            Thread.Sleep(2000);
            Console.WriteLine(employee.Status);







        }
    }
}
