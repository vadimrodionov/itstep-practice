using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }

        public Queue<Card> hand = new Queue<Card>();
        public Player(string name) 
        {
            this.name = name;
        }
        public void ShowHand() //help
        {
            foreach (Card item in hand)
            {
                Console.WriteLine(item);
            }
        }
     
    }
}
