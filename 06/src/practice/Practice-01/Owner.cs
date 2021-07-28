using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdincevBogdan.Practice_01.EventArgsModels;

namespace UdincevBogdan.Practice_01
{
    public class Owner
    {
        public event EventHandler<FeedEventArgs> FeedPet;
        public event EventHandler<WalkEventArgs> WalkedPet;
        public event EventHandler<SleepEventArgs> MakePetASleep;
        public event EventHandler<PlayEventArgs> PlayPet;
        public event EventHandler<HealEventArgs> HealedPet;
    }
}
