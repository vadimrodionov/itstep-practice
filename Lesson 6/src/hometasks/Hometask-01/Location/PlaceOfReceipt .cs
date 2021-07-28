using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01.Location
{
    class PlaceOfReceipt
    {
        private bool isOpen = false; //статус - открыт/закрыт
        public bool IsOpen 
        {
            get { return isOpen; }
            set { isOpen = value; }
        } //свойство для устновки, получения статуса
        public PlaceOfReceipt() { } //конструктор

        public delegate void CentreStatus(); //делегат для представления событий центра 

        public event CentreStatus CentreIsOpen; //событие - открытие центра

        public event CentreStatus CentreIsClosed; // событие - центр закрыт

        public void OpenCentre() //обработчик события - открытие центра
        {
            Console.WriteLine("Центр выдачи заказов открыт");
            isOpen = true;
        }

        public void CloseCentre() //обработчик событыя - закрытие центра
        {
            Console.WriteLine("Центр выдачи заказов закрыт");
            isOpen = false;
        }

    }
}
