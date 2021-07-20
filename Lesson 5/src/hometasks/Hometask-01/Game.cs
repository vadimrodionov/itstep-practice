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

        private int numberOfPlayers;

        public ArrayList gameTable = new ArrayList();

        public List<Player> players = new List<Player>();

        //public Player[] players;
        public Game(int numberOfPlayers) 
        {
            this.numberOfPlayers = numberOfPlayers;
            InicializePlayers();
            Distribute();
            InicializeDeck();
        }

        public void ShowPlayers() 
        {
            foreach (Player item in players)
            {
                Console.WriteLine(item);
            }
        }

        public void Mix() // алгоритм Фишера-Йетса
        {
            Random rand = new Random();
            for (int i = deck.Length - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                Card tmp = deck[j];
                deck[j] = deck[i];
                deck[i] = tmp;
            }
        }
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

            Mix();
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
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player($"Игрок № {i + 1}"));
            }

        }
        public void Distribute()
        {
            int cardInHand = 52 / numberOfPlayers;

            for (int i = 0, j = 0; i < numberOfPlayers; i++)
            {
                for (int k = 0; k < cardInHand; j++, k++)
                {
                    players[i].hand.Enqueue(deck[j]);
                }
            }
        }
    }
}
