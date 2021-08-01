using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Customer
    {
        private string status = "Заходит в центр выдачи";
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public Customer()
        {
            EnterCenter += Handler_EnterCenter;
            StartService += Handler_StartService;
            ReportedOrder += Handler_ReportedOrder;
            AcceptedGoods += Handler_AcceptedGoods;
        }

        public delegate void CustomerAction();

        public event CustomerAction EnterCenter;
        public event CustomerAction StartService;
        public event CustomerAction ReportedOrder;
        public event CustomerAction ReceivedGoods;
        public event CustomerAction AcceptedGoods;

        private void Handler_EnterCenter() 
        {
            status = "Ожидает обслуживания в очереди";
        }

        private void Handler_StartService() 
        {
            status = "Запрашивает заказ";
        }

        private void Handler_ReportedOrder() 
        {
            status = "Ожидает выдачи заказа";
        }

        public void Handler_ReceivedGoods() 
        {
            status = "Принимает товары";
        }

        public void Handler_AcceptedGoods() 
        {
            status = "Выходит из центра выдачи";
        }
        public void Invoke_EnterCenter() 
        {
            EnterCenter.Invoke();
        }

        public void Invoke_StartService() 
        {
            StartService.Invoke();
        }

        public void Invoke_ReportedOrder() 
        {
            ReportedOrder.Invoke();
        }

        public void Invoke_ReceivedGoods() 
        {
            ReceivedGoods.Invoke();
        }

        public void Invoke_AcceptedGoods() 
        {
            AcceptedGoods.Invoke();
        }

    }
}
