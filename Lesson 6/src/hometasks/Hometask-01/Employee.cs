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
        }

        public delegate void EmpAction();

        public event EmpAction UnloadFinished;

        private void Handler_UnloadFinished()
        {
            status = "В месте приема товара принимает товар";
        }

        public void Invoke_UnloadFinished() 
        {
            UnloadFinished.Invoke();
        }
        public void OpenCenter(IssuingCenter center)
        {
            center.Invoke_OpenCenter();
        }
        public void CloseCenter(IssuingCenter center)
        {
            center.Invoke_CloseCenter();
        }

    }
}
