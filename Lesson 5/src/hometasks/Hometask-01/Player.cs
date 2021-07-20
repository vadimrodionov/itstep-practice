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

        public Queue<Card> hand = new Queue<Card>();
        public Player(string name) 
        {
            this.name = name;
        }
        public void TakeCard(Card card) 
        {
            hand.Enqueue(card);
        }
        public Card PutCard()
        {
            return hand.Dequeue();
        }
     
    }
}
