using System;

namespace artem_buzinov.Practice_01
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowIntroduction();
            
        }

        static void ShowIntroduction()
        {
            Console.WriteLine("������ ������? ([y] - ������ ����, [n] - �����) ");
        }

        static void InitializeGameSession()
        {

        }

        static void GameLoop()
        {

        }

        void OnPetEvent()
        {

        }

        void ProcessuserInput() 
        {
            var key = Console.ReadKey();

            switch (key.KeyChar)
            {
                case 'f':
                    break;
                case 'w':
                    break;
                case 'p':
                    break;
                case 's':
                    break;
                case 'h':
                    break;
                default:
                    break;
            }

        }

        
    }
}
