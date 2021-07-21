using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Game : IGameControl,IGameProcess
    {
        private Card[] deck = new Card[52];

        private int numberOfPlayers;

        private LinkedList<Card> gameTable = new LinkedList<Card>();

        private List<Player> players = new List<Player>();

        public Game(int numberOfPlayers) 
        {
            this.numberOfPlayers = numberOfPlayers;
            InicializePlayers();
            InicializeDeck();
            Distribute();
            
        }     

        private void Mix() 
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

        private void InicializeDeck() 
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

        private void InicializePlayers()
        {
            for (int i = 0; i < numberOfPlayers; i++)
            {
                players.Add(new Player($"Игрок № {i + 1}"));
            }

        }

        private void Distribute()
        {
            
            int cardInHand = 52 / numberOfPlayers;
            int remains = 52 - (numberOfPlayers*cardInHand);
            int cardNumber=0;
            for (int i = 0; i < numberOfPlayers; i++)
            {
                for (int k = 0; k < cardInHand; cardNumber++, k++)
                {
                    players[i].hand.Enqueue(deck[cardNumber]);
                }
            }
            if (remains!=0)
            {
                for (int i = cardNumber; i < deck.Length; i++)
                {
                    gameTable.AddFirst(deck[i]);
                }
                
            }

        }

        public void GameTable() 
        {
            //for (int i = 0; i < players.Count; i++)
	          //{
              //  gameTable[i]=PutCards(players[i]);
			//}

            foreach (Player item in players)
	        {
                gameTable.AddFirst(PutCards(item));
	        }
            int i=0;
            foreach (Card item in gameTable)
           	{
                Console.WriteLine($"Player {i++} |Card:{item.Suit}/{item.Value}|");
	        }

	}
        

        public void ShowPlayers()  //help
        {
           foreach (Player item in players)
           {
              Console.WriteLine($"{item.Name}");
           }
        }
        public void PrintDeck() //help
        {
            int i = 0;
           foreach (Card card in deck)
           {
               Console.WriteLine($"{deck[i]}{card.Suit}{card.Value}");
               i++;
           }
        }

        public void Round() //Запуск раунда
        {
            throw new NotImplementedException();
        }

        public Card PutCards(Player player) //Выкладывание карт на стол
        {
            return player.hand.Dequeue();
        }

        public void CheckBiggestCard() //Определение большей карты
        {
            throw new NotImplementedException();
        }

        public void GetCards() //Добавление карт игроку
        {
            throw new NotImplementedException();
        }

        public void DropOutPlayer() //Выбывание из игры
        {
            throw new NotImplementedException();
        }
    }

}
