using System;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using VadimRodionov.Practice_01.EventArgModels;
using static System.Console;

namespace VadimRodionov.Practice_01
{
    class Program
    {
        static Owner Owner;
        static Pet Pet;

        static bool ActiveSession = false;

        public static event EventHandler StartGame;

        static async Task Main(string[] args)
        {
            Initialize();
            ShowIntroduction();
            PromptStart();
            await GameLoop();
        }

        #region main actions
        static void Initialize() => StartGame += OnStartGame;

        static void ShowIntroduction() =>
            WriteLine(File.ReadAllText("res/intro.txt"));

        static void PromptStart()
        {
            WriteLine("Готовы начать? ([y] - начать игру, [n] - выйти)");

            while (true)
            {
                var key = ReadKey().KeyChar;
                
                if (!"yn".Contains(key))
                {
                    WriteLine("Пожалуйста, нажмите [y], чтобы начать игру, или [n], чтобы выйти.");
                    continue;
                }

                if (key == 'y')
                    StartGame(typeof(Program), EventArgs.Empty);

                break;
            }
        }

        static async Task GameLoop()
        {
            while (ActiveSession) {
                await Task.Delay(120000);
            }
        }
        #endregion
        
        #region event handlers
        static void OnStartGame(object sender, EventArgs e)
        {
            ActiveSession = true;
            InitializeGameSession();
        }

        static void OnPetActionRequestEvent<TEventArgs>(object sender, TEventArgs e) where TEventArgs : EventArgs
        {
            // process pet action request event
            var (color, message) = e switch
            {
                FeedEventArgs => (ConsoleColor.Yellow, "Покорми меня!"),
                PlayEventArgs => (ConsoleColor.Yellow, "Поиграй со мной!"),
                WalkEventArgs => (ConsoleColor.Yellow, "Погуляй со мной!"),
                SleepEventArgs => (ConsoleColor.Yellow, "Хочу спать!"),
                HealEventArgs => (ConsoleColor.Red, "Что-то мне нехорошо..."),
                _ => throw new ArgumentException($"Incorrect argument type: {e.GetType().Name}")
            };

            // show message
            WriteColoredLine(color, message);

            // wait for input
            ProcessUserInput();
        }

        static void OnPetSatisfied(object sender, EventArgs e)
        {
            WriteColoredLine(ConsoleColor.DarkGreen, "Просьба выполнена");
            ShowSessionStats();
        }

        static void OnPetUnsatisfied(object sender, EventArgs e)
        {
            WriteColoredLine(ConsoleColor.DarkYellow, "Просьба не выполнена");
            ShowSessionStats();
        }

        static void OnPetDied(object sender, EventArgs e) {
            ShowSessionStats();
            ActiveSession = false;
            PromptRestart();
        }
        #endregion

        #region event reactions
        static void InitializeGameSession()
        {
            // initialize owner and pet objects
            Pet = new Pet();
            Owner = new Owner();

            // subscribe to pet's events
            Pet.RequestedFood += OnPetActionRequestEvent;
            Pet.RequestedPlay += OnPetActionRequestEvent;
            Pet.RequestedSleep += OnPetActionRequestEvent;
            Pet.RequestedWalk += OnPetActionRequestEvent;
            Pet.RequestedHeal += OnPetActionRequestEvent;
            Pet.Satisfied += OnPetSatisfied;
            Pet.Unsatisfied += OnPetUnsatisfied;
            Pet.Died += OnPetDied;

            // subscribe to owner's events
            Owner.FeedPet += Pet.OnUserAction;
            Owner.PlayedPet += Pet.OnUserAction;
            Owner.WalkedPet += Pet.OnUserAction;
            Owner.MadePetAsleep += Pet.OnUserAction;
            Owner.HealedPet += Pet.OnUserAction;

            // start a loop
            Pet.Initialize();
        }

        static void ProcessUserInput()
        {
            var key = ReadKey().KeyChar;
            switch (key)
            {
                // todo: raise events
                case 'f': Owner.Feed(); break;
                case 'w': Owner.Walk(); break;
                case 'p': Owner.Play(); break;
                case 's': Owner.Sleep(); break;
                case 'h': Owner.Heal(); break;
                default: WriteLine($"Неизвестное действие: [{key}]. Доступные действия: [f,w,p,s,h]."); break;
            };
        }

        static void ShowSessionStats() =>
            WriteColoredLine(ConsoleColor.Gray, Pet.Stats);

        static void PromptRestart()
        {
            WriteLine("Хотите попробовать ещё раз? ([y] - начать игру ещё раз, любая другая клавиша - выход)");
            if (ReadKey().KeyChar == 'y') PromptStart();
        }
        #endregion

        #region helpers
        static void WriteColoredLine(ConsoleColor color, string line)
        {
            var originalColor = ForegroundColor;
            ForegroundColor = color;
            WriteLine(line);
            ForegroundColor = originalColor;
        }
        #endregion
    }
}
