using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdincevBogdan.Practice_01
{
    public class Owner
    {
        public event EventHandler FeedPet;
        public event EventHandler HealedPet;
        public event EventHandler WalkedPet;
        public event EventHandler MakePetAsSleepPet;
        public event EventHandler PlayPet;
    }
}
