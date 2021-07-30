using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using artem_buzinov.Hometask_01.Location;

namespace artem_buzinov.Hometask_01.Actors
{
    class Employee
    {
        private string name;

        private string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public Employee(string name)
        {
            this.name = name;
        }


    }
}
