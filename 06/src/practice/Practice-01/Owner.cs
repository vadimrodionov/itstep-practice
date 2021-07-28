using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VadimRodionov.Practice_01.EventArgModels;

namespace VadimRodionov.Practice_01
{
    class Owner
    {
        public event EventHandler<FeedEventArgs> FeedPet;
        public event EventHandler<WalkEventArgs> WalkedPet;
        public event EventHandler<SleepEventArgs> MadePetAsleep;
        public event EventHandler<PlayEventArgs> PlayedPet;
        public event EventHandler<HealEventArgs> HealedPet;

        public void Feed() => FeedPet(this, new FeedEventArgs());
        public void Play() => PlayedPet(this, new PlayEventArgs());
        public void Sleep() => MadePetAsleep(this, new SleepEventArgs());
        public void Walk() => WalkedPet(this, new WalkEventArgs());
        public void Heal() => HealedPet(this, new HealEventArgs());
    }
}
