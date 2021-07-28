using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01.Actors
{
    class Customer
    {
        #region FIELDS
        private string name; //имя клиента
        #endregion
        public Customer(string name) //конструктор
        {
            this.name = name;
        }
        #region PROPERTIES
        public string Name
        {
            get { return name; }
        }
        #endregion
        #region DELEGATES
        public delegate void CustomerAction (); //делагат представляющий действие клиента
        #endregion
        #region METHODS
        public void Status() 
        {
            if (ComeIntoCentre!=null)
            {
                ComeIntoCentre.Invoke();
            }
            else
            {
                Console.WriteLine("Обработчик не привязан");
            }
            
        }
        #endregion
        #region EVENTS
        public event CustomerAction ComeIntoCentre; //событие - клиент пришел в центр выдачи
        #endregion
        #region EVENT_HANDLERS
        public void IntoCentre() 
        {
            Console.WriteLine("Клиент пришел в центр выдачи заказов");
        }
        #endregion

    }
}
