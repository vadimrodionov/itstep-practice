using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class IssuingCenter
    {
        private string status = "Центр закрыт";
        private DateTime openTime;
        private DateTime closeTime;
        private Employee emp;
        public string Status 
        {
            get { return status; }
            set { status = value; }
        }
        public DateTime OpenTime 
        {
            get { return openTime; }
            set { openTime = value; }
        }
        public DateTime CloseTime 
        {
            get { return closeTime; }
            set { closeTime = value; }
        }
        public IssuingCenter() 
        {
            OpenCenter += Handler_OpenCenter;
            CloseCenter += Handler_CloseCenter;
        }

        public delegate void CenterAction();
        public delegate void CenterOpenClose(Employee emp);

        public event CenterAction OpenCenter;
        public event CenterAction CloseCenter;
        public event CenterOpenClose OpenTimeEvent;
        public event CenterOpenClose CloseTimeEvent;

        private void Handler_OpenCenter() 
        {
            status = "Центр открыт";
        }

        private void Handler_CloseCenter() 
        {
            status = "Центр закрыт";
        }

        public void Handler_OpenTime(Employee emp) 
        {
            this.emp = emp;
            openTime = DateTime.Now;
            emp.Status = "В точке выдачи ожидает заказчика";
        }

        public void Handler_CloseTime(Employee emp)
        {
            this.emp = emp;
            closeTime = DateTime.Now;
            emp.Status = "В центре выдачи";
        }

        public void Invoke_OpenCenter() 
        {
            OpenCenter.Invoke();
        }

        public void Invoke_CloseCenter() 
        {
            CloseCenter.Invoke();
        }

        public void Invoke_OpenTimeEvent() 
        {
            OpenTimeEvent.Invoke(emp);
        }


    }
}
