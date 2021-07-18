using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.InicializeDeck();
            game.Mix();
            game.PrintDeck();


        }
    }
}
