using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    interface IGameControl
    {
        void InicializeDeck();
        void InicializePlayers();
        void Mix();
        void Distribute();

    }
}
