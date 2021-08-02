using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class PlaceOfReceipt
    {
        private Employee emp;
        public PlaceOfReceipt(Employee emp) 
        {
            this.emp = emp;
            TruckArrived += HandlerTruckArrived;
            ReceptionIsOver += HandlerReceptionIsOver;
            TruckLeave += HandelerTruckLeave;
        }

        public delegate void PlaceOfReceiptAction(Employee emp);

        public event PlaceOfReceiptAction TruckArrived;
        public event PlaceOfReceiptAction ReceptionIsOver;
        public event PlaceOfReceiptAction TruckLeave;

        private void HandlerTruckArrived(Employee emp)
        {
            emp.Status = "В месте приема товара принимает товар";
        }

        private void HandlerReceptionIsOver(Employee emp) 
        {
            emp.Status = "На складе разгружает товар";
        }

        private void HandelerTruckLeave(Employee emp) 
        {

            emp.Status = "В центре выдачи";
        }

        public void Invoke_TruckArrived() 
        {
            TruckArrived.Invoke(emp);
        }

        public void Invoke_ReceptionIsOver() 
        {
            ReceptionIsOver.Invoke(emp);
        }

        public void Invoke_TruckLeave() 
        {
            TruckLeave.Invoke(emp);
        }
        
    }
}
