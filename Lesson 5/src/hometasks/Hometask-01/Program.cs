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
            Game game = new Game(5);
            game.ShowPlayers();
            //game.PrintDeck();
            //game.Distribute();

            Console.WriteLine("---------------");

            //game.ShowHands  ();

            game.ShowGameTable();
            
            Console.ReadLine();

        }
    }
}
