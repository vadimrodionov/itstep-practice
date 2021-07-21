﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    interface IGameProcess
    {
        void Round();
        Card PutCards(Player player);
        void CheckBiggestCard();
        void GetCards();
        void DropOutPlayer();

    }
}
