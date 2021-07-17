using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Card <T>
    {
        private string suit;
        private T value;
        public string Suit { get; }
        public T Value { get; }
        public Card(string suit, T value) 
        {
            this.suit = suit;
            this.value = value;
        }
        public void PrintCard() 
        {
            Console.WriteLine("--------------\n" +
                             $"|{suit}     {value}|\n" +
                              "--------------");
        }
    }
}
