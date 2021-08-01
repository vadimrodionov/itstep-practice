using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Employee
    {
        private string status = "В центре выдачи";
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Employee()
        {

            UnloadFinished += Handler_UnloadFinished;
            BeginService += Handler_BeginService;
            AcceptedOrderNumber += Handler_AcceptedOrderNumber;
            TookAllGoods += Handler_TookAllGoods;
            IssuedAll += Handler_IssuedAll;
            CloseOrder += Handler_CloseOrder;
        }

        public delegate void EmpAction();

        public event EmpAction UnloadFinished;
        public event EmpAction BeginService;
        public event EmpAction AcceptedOrderNumber;
        public event EmpAction TookAllGoods;
        public event EmpAction IssuedAll;
        public event EmpAction CloseOrder;

        private void Handler_UnloadFinished()
        {
            status = "В месте приема товара принимает товар";
        }
        private void Handler_BeginService() 
        {
            status = "В точке выдачи принимает заказ для выдачи";
        }
        private void Handler_AcceptedOrderNumber() 
        {
            status = "На складе забирает товары для выдачи";
        }
        private void Handler_TookAllGoods() 
        {
            status = "В точке выдачи выдаёт товары";
        }
        private void Handler_IssuedAll() 
        {
            status = "В точке выдачи заносит заказ в список выполненных";
        }
        private void Handler_CloseOrder()
        {
            status = "В точке выдачи ожидает заказчика";
        }
        public void Invoke_UnloadFinished() 
        {
            UnloadFinished.Invoke();
        }
        public void Invoke_BeginService() 
        {
            BeginService.Invoke();
        }
        public void Invoke_AcceptedOrderNumber() 
        {
            AcceptedOrderNumber.Invoke();
        }
        public void Invoke_TookAllGoods() 
        {
            TookAllGoods.Invoke();
        }
        public void Invoke_IssuedAll() 
        {
            IssuedAll.Invoke();
        }
        public void Invoke_CloseOrder() 
        {
            CloseOrder.Invoke();
        }
        public void OpenCenter(IssuingCenter center, Customer cust)
        {
            center.Invoke_OpenCenter();
            cust.Status = "Заходит в центр выдачи";
        }
        public void CloseCenter(IssuingCenter center)
        {
            center.Invoke_CloseCenter();
        }

    }
}
