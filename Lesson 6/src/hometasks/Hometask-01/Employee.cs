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

        public Employee() { }

        public delegate void EmpAction();
    }
}
