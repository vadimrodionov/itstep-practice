using System;

namespace UdincevBogdan.Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static void ShowIntroduction()
        {

        }
        static void InitializeGameSesstion()
        {
            Console.WriteLine();
            Console.WriteLine("√отовы начать? ([y] - начать играть, [n] - закончить)");
        }
        static void GameLoop()
        {

        }
        static void ShowSessionStats()
        {

        }
        void OnPetEvent()
        {

        }
        static bool ProcessStartInput()
        {
            char input;
            do
            {
                input = Console.ReadKey().KeyChar;
                if (input == 'y' || input == 'n') return input == 'y';
            } while (input == 'y' || input == 'n');
            Console.ReadKey();
            return false;
        }

        void ProcessUserInput()
        {
            var key = Console.ReadKey();
            switch (key.KeyChar)
            {
                case 'f': break;
                case 'w': break;
                case 'p': break;
                case 's': break;
                case 'h': break;
                default: break;
            }
        }
    }
}
