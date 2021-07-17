using System;
using System.Timers;

namespace UdincevBogdan.Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            var owner = new Owner();
            var pet = new Pet();

            Timer timer;
        }
        void OnPetEvent()
        {

        }

        void ProcessUserInput()
        {
            var key = Console.ReadKey();
            switch (key.KeyChar)
            {
                //events
                case 'f': break;
                case 'w': break;
                case 'p': break;
                case 's': break;
                case 'h': break;
                default: break;
            }
        }
    }
}
