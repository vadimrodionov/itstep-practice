using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01.Location
{
    class PlaceOfReceipt
    {
        private bool isOpen; //статус - открыт/закрыт
        public bool IsOpen 
        {
            get { return isOpen; }
            set { isOpen = value; }
        } //свойство для устновки, получения статуса
        public PlaceOfReceipt() 
        {
            
        } //конструктор
    }
}
