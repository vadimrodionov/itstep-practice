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
        private Card[] deck = new Card[52];
        public void InicializeDeck() 
        {
            int number = 0;
            for (int i=2; i <= 10; i++)
            {
                deck[number++] = new Card("Spides", i.ToString());
                deck[number++] = new Card("Hearts", i.ToString());
                deck[number++] = new Card("Clubs", i.ToString());
                deck[number++] = new Card("Diamonds", i.ToString());
            }
            deck[number++] = new Card("Spides", "Jack");
            deck[number++] = new Card("Hearts", "Jack");
            deck[number++] = new Card("Clubs", "Jack");
            deck[number++] = new Card("Diamonds", "Jack");

            deck[number++] = new Card("Spides", "Queen");
            deck[number++] = new Card("Hearts", "Queen");
            deck[number++] = new Card("Clubs", "Queen");
            deck[number++] = new Card("Diamonds", "Queen");

            deck[number++] = new Card("Spides", "King");
            deck[number++] = new Card("Hearts", "King");
            deck[number++] = new Card("Clubs", "King");
            deck[number++] = new Card("Diamonds", "King");

            deck[number++] = new Card("Spides", "Ace");
            deck[number++] = new Card("Hearts", "Ace");
            deck[number++] = new Card("Clubs", "Ace");
            deck[number++] = new Card("Diamonds", "Ace");
        }
        public void PrintDeck() 
        {
            foreach (Card card in deck)
            {
                Console.WriteLine($"{card.Suit}  {card.Value}");
            }
        }
        public void InicializePlayers()
        {
            throw new NotImplementedException();
        }
        public void Mix () // алгоритм Фишера-Йетса
        {
            Random rand = new Random();
            for (int i = deck.Length-1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                Card tmp = deck[j];
                deck[j] = deck[i];
                deck[i] = tmp;
            }
        }

        //Maybe i should use params here?
        public void Distribute()
        {
            throw new NotImplementedException();
        }
    }
}
