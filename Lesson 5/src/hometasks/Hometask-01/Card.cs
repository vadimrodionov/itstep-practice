using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Card 
    {
        private string suit;
        private string value;
        public string Suit
        {
            get { return suit; }

        }

        public string Value 
        {
            get { return value; }

        }
        public Card(string suit, string value) 
        {
            this.suit = suit;
            this.value = value;
        }

    }
}
