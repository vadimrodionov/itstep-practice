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
        private DateTime OpenTime;
        private DateTime CloseTime;

        public string Status 
        {
            get { return status; }
            set { status = value; }
        }
        public IssuingCenter() 
        {
            OpenCenter += HandlerOpenCenter;
            CloseCenter += HandlerCloseCenter;
        }

        public delegate void CenterAction();

        public event CenterAction OpenCenter;
        public event CenterAction CloseCenter;

        private void HandlerOpenCenter() 
        {
            status = "Центр открыт";
        }

        private void HandlerCloseCenter() 
        {
            status = "Центр закрыт";
        }
        public void Invoke_OpenCenter() 
        {
            OpenCenter.Invoke();
        }

        public void Invoke_CloseCenter() 
        {
            CloseCenter.Invoke();
        }


    }
}
