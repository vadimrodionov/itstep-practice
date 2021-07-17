using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using UdincevBogdan.Practice_01.Enums;

namespace UdincevBogdan.Practice_01
{
    public class Pet
    {
        HealthState _healthStae;
        HealthState _age;
        Request _currentRequest;

        public event EventHandler RequestedPlay;

        Timer timer;

        void Play(object a, EventArgs args) { 
        
        }
        void Walk() { }
        void Sleep() { }
        void Eat() { }
        void Heal() { }

        void MakeRequest()
        {

        }
    }
}
