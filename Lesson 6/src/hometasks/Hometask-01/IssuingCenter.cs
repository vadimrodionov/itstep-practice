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
        public string Status 
        {
            get { return status; }
            set { status = value; }
        }

        public IssuingCenter() { }
    }
}
