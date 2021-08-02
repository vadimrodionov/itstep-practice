using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Timers;
using System.Threading.Tasks;

namespace artem_buzinov.Practice_01
{
    class Pet
    {
        HelthState _health;
        Age _age;
        Timer _timer;

        private EventHandler LastRequest;
        List<EventHandler> _healthyActions;

        public event EventHandler RequestFood;
        public event EventHandler RequestWalk;
        public event EventHandler RequestPlay;
        public event EventHandler RequestSleep;
        public event EventHandler RequestHeal;


        private static Random _rand = new Random();
        private const double timerInterval = 5000;
        public Pet() 
        {
            _health = HelthState.Health;
            _age = Age.Young;
            _timer = new Timer(timerInterval);
            _timer.BeginInit();
            _healthyActions = new List<EventHandler>();
        }

        public void Initialize() 
        {
            _timer.Elapsed += OnIdleTimerElapsed;
            _timer.Start();
        }

        public void OnIdleTimerElapsed(object sender, EventArgs e) 
        {
            RequestAction();
        }

        public void OnActionTimerElapsed(object sender, EventArgs e)
        {

        }
        public void OnUserAction(object sender, EventArgs e) 
        {

        }
        public void RequestAction() 
        {
            
            //raise a request
            if (_health==HelthState.Sick)
            {
                RequestHeal(this, new EventArgs());
                LastRequest = RequestHeal;
            }
            else
            {
                var availableActions = _healthyActions.Where(a => a != LastRequest).ToList();
                var actionNext = _rand.Next() % availableActions.Count;
                var request = availableActions[actionNext];
                LastRequest = request;
                request(this, new EventArgs());
            }

            _timer.Elapsed -= OnIdleTimerElapsed;
            _timer.Elapsed += OnActionTimerElapsed;
            _timer.Start();

        }


    }
}
