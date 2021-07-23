﻿using System;
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
        private uint weight;
        private uint _playerId;
        public string Suit
        {
            get { return suit; }

        }

        public string Value 
        {
            get { return value; }

        }

        public uint Weight 
        {
            get { return weight; }
        }

        public uint PlayerId
        {
            get { return _playerId; }
            set { _playerId = value; }
        }
        public Card() { }
        public Card(string suit, string value, uint weight=0) 
        {
            this.suit = suit;
            this.value = value;
            this.weight = weight;
        }

    }
}
