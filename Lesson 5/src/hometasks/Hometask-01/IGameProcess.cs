using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    interface IGameProcess
    {
        void Round();
        void PutCards();
        void CheckBiggestCard();
        void GetCards();
        void DropOutPlayer();

    }
}
