using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class InsufficientFundsException:ApplicationException
    {
        private string message;
        public InsufficientFundsException(string message) 
        {
            this.message = message;
        }
        public override string Message => $"Error: {message}";

    }
}
