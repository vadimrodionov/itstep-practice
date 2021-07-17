using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Game : IGameControl
    {
        private Dictionary<uint, Card> deck = new Dictionary<uint, Card>(52);
        public void InicializeDeck()
        {
            uint number = 0;
            for (uint i = 2; i <= 10; i++,number+=4)
            {
                string value = i.ToString();
                deck.Add(number, new Card("Spides", value));
                deck.Add(number+1, new Card("Hearts", value));
                deck.Add(number+2, new Card("Clubs", value));
                deck.Add(number+3, new Card("Diamonds", value));
            }
            deck.Add(++number, new Card("Spides", "Jack"));
            deck.Add(++number, new Card("Hearts", "Jack"));
            deck.Add(++number, new Card("Clubs", "Jack"));
            deck.Add(++number, new Card("Diamond", "Jack"));

            deck.Add(++number, new Card("Spides", "Queen"));
            deck.Add(++number, new Card("Hearts", "Queen"));
            deck.Add(++number, new Card("Clubs", "Queen"));
            deck.Add(++number, new Card("Diamond", "Queen"));

            deck.Add(++number, new Card("Spides", "King"));
            deck.Add(++number, new Card("Hearts", "King"));
            deck.Add(++number, new Card("Clubs", "King"));
            deck.Add(++number, new Card("Diamond", "King"));

            deck.Add(++number, new Card("Spides", "Ace"));
            deck.Add(++number, new Card("Hearts", "Ace"));
            deck.Add(++number, new Card("Clubs", "Ace"));
            deck.Add(++number, new Card("Diamond", "Ace"));

        }
        public void PrintDeck() 
        {
            foreach (var item in deck)
            {
                Console.WriteLine($"Номер карты:{item.Key}\t Масть: { item.Value.Suit}\t, Карта: {item.Value.Value}");
            }
        }
        public void InicializePlayers()
        {
            throw new NotImplementedException();
        }
        public void Mix()
        {
            throw new NotImplementedException();
        }
        public void Distribute()
        {
            throw new NotImplementedException();
        }
    }
}
