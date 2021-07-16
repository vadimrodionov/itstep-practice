using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Card <T>
    {
        string suit;
        T value;
        string Suit { get; }
        T Value { get; }
        public Card(string suit, T value) 
        {
            this.suit = suit;
            this.value = value;
        }
    }
}
