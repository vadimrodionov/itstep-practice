using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    interface IBankOperation
    {
        void Withdraw(uint sum);
        void Replenish(uint sum);
        void CheckBalance();
        void GetHistory();
        void Close();
        void Information();
    }
}
