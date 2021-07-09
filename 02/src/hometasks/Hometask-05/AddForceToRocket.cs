using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdincevBogdan.Hometask_05
{
    partial class Rocket
    {
        public void AddForceToRocket(ref Rocket rocket, double Force)
        {
            rocket.SpecificImpulse += Force;
        }
    }
}
