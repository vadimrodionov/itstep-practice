using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Practice_01
{
    class Owner 
    {
        public event EventHandler FeedPet;
        public event EventHandler WalkedPet;
        public event EventHandler MakePetAsSleep;
        public event EventHandler PlayPet;
        public event EventHandler HealedPet;

    }
}
