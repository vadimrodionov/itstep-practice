﻿using System;
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
            uint weight=0;
            for (int i=2; i <= 10; i++)
            {
                deck[number++] = new Card("Spides", i.ToString(),weight);
                deck[number++] = new Card("Hearts", i.ToString(), weight);
                deck[number++] = new Card("Clubs", i.ToString(), weight);
                deck[number++] = new Card("Diamonds", i.ToString(), weight);
                weight++;
            }
            deck[number++] = new Card("Spides", "Jack", weight);
            deck[number++] = new Card("Hearts", "Jack", weight);
            deck[number++] = new Card("Clubs", "Jack", weight);
            deck[number++] = new Card("Diamonds", "Jack", weight);
            weight++;
            deck[number++] = new Card("Spides", "Queen",weight);
            deck[number++] = new Card("Hearts", "Queen", weight);
            deck[number++] = new Card("Clubs", "Queen", weight);
            deck[number++] = new Card("Diamonds", "Queen", weight);
            weight++;
            deck[number++] = new Card("Spides", "King", weight);
            deck[number++] = new Card("Hearts", "King", weight);
            deck[number++] = new Card("Clubs", "King", weight);
            deck[number++] = new Card("Diamonds", "King", weight);
            weight++;
            deck[number++] = new Card("Spides", "Ace", weight);
            deck[number++] = new Card("Hearts", "Ace", weight);
            deck[number++] = new Card("Clubs", "Ace", weight);
            deck[number++] = new Card("Diamonds", "Ace", weight);
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
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Игровой стол:");
            Console.ForegroundColor = ConsoleColor.Red;

            foreach (Player item in players)
	        {
                gameTable.AddFirst(PutCards(item));
	        }
            int i=0;

            foreach (Card item in gameTable)
           	{
                if (i==players.Count)
                {
                    break;
                }
                Console.WriteLine($"Игрок {i+1} Карта:|{item.Suit}/{item.Value}|");
                i++;
	        }
            Console.ResetColor();

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
               Console.WriteLine($"|{card.Suit}/{card.Value}/{card.Weight}|");
               i++;
           }
        }

        public void Round() //Запуск раунда
        {
            GameTable();
        }

        public Card PutCards(Player player) //Выкладывание карт на стол
        {
            return player.hand.Dequeue();
        }

        public void CheckBiggestCard() //Определение большей карты
        {
            Card biggestCard = new Card();


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
