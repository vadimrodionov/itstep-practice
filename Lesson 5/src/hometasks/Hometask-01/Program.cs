using System;

namespace artem_buzinov.Hometask_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.FillDeck();
            game.ShowDeck();
            Console.ReadLine();

        }
    }
}
