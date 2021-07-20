using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Player
    {
        public Queue<Card> hand = new Queue<Card>();
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
