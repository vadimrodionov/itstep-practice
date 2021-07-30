using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using artem_buzinov.Hometask_01.Location;

namespace artem_buzinov.Hometask_01.Actors
{
    class Employee
    {
        private string name;
        public Employee(string name)
        {
            this.name = name;
        }

        public delegate void EmpAction(PlaceOfReceipt centre); //делегат для представления действий сотрудника центра

        public event EmpAction ComeToCentre;

        public void CentreStatus(PlaceOfReceipt centre) //обработчик событий для открытия центра
        {
            if (ComeToCentre!=null)
            {
                centre._CentreStatus();
                Console.WriteLine("EVENT! Сотрудник открыл центр");
            }
            else
            {
                centre._CentreStatus();
                Console.WriteLine("В центре никого нет");
            }
        }

        public void GoToCentre(PlaceOfReceipt centre) 
        {
            ComeToCentre += CentreStatus;
            centre.CentreIsOpen += centre.OpenCentre;
            centre.CentreIsClosed -= centre.CloseCentre;
        }


        public void GoOutCentre(PlaceOfReceipt centre) 
        {
            ComeToCentre -= CentreStatus;
            centre.CentreIsClosed += centre.CloseCentre;
            centre.CentreIsOpen -= centre.OpenCentre;
        }


    }
}
