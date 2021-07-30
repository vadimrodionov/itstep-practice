using System;
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
            employee.CentreStatus(OZON);
            employee.GoToCentre(OZON);
            employee.CentreStatus(OZON);

        }
    }
}
