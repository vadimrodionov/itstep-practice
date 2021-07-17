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

        private ArrayList deck = new ArrayList(52)
        {

        };

        public ArrayList Deck { get; }

        public void FillDeck()
        {
            for (int i = 2; i <= 10; i++)
            {
                deck.Add(new Card<int>("Spides", i));
                deck.Add(new Card<int>("Hearts", i));
                deck.Add(new Card<int>("Clubs", i));
                deck.Add(new Card<int>("Diamonds", i));
            }
            deck.Add(new Card<string>("Spides", "Jack"));
            deck.Add(new Card<string>("Hearts", "Jack"));
            deck.Add(new Card<string>("Clubs", "Jack"));
            deck.Add(new Card<string>("Diamonds", "Jack"));

            deck.Add(new Card<string>("Spides", "Queen"));
            deck.Add(new Card<string>("Hearts", "Queen"));
            deck.Add(new Card<string>("Clubs", "Queen"));
            deck.Add(new Card<string>("Diamonds", "Queen"));

            deck.Add(new Card<string>("Spides", "King"));
            deck.Add(new Card<string>("Hearts", "King"));
            deck.Add(new Card<string>("Clubs", "King"));
            deck.Add(new Card<string>("Diamonds", "King"));

            deck.Add(new Card<string>("Spides", "Ace"));
            deck.Add(new Card<string>("Hearts", "Ace"));
            deck.Add(new Card<string>("Clubs", "Ace"));
            deck.Add(new Card<string>("Diamonds", "Ace"));
        }

        public void ShowDeck()
        {
            foreach (Card<int> card in deck)
            {
                card.PrintCard();
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
