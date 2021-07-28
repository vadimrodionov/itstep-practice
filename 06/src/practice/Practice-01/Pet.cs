using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
using System.Threading.Tasks;
using UdincevBogdan.Practice_01.Enums;
using UdincevBogdan.Practice_01.EventArgsModels;

namespace UdincevBogdan.Practice_01
{
    public class Pet
    {
        private const double defaultTimerInterval = 5000;
        private const double timerInterval = 15000;
        private const double unsatisfiedRequestsThreshold = 5000;
        private static Random _random = new Random();

        readonly DateTime _dateOfBirthDay;

        HealthState _health;
        Age _age;

        int _unsatisfiedRequets;

        Timer _timer;

        EventHandler _LastRequest;
        List<EventHandler> _healthyActions;


        public event EventHandler RequestedPlay;
        public event EventHandler RequestedWalk;
        public event EventHandler RequestedHeal;
        public event EventHandler RequestedEat;
        public event EventHandler RequestedSleep;

        public Pet()
        {
            _health = HealthState.Healthy;
            _age = Age.Young;
            _timer = new Timer(timerInterval);
            _timer.BeginInit();
            _unsatisfiedRequets = 0;

            _dateOfBirthDay = DateTime.Now;

            _healthyActions = new List<EventHandler>() { RequestedEat, RequestedHeal, RequestedPlay, RequestedSleep, RequestedWalk };
            Died += OnDeath;
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
            if (_health == HealthState.Sick)
            {
                _health = HealthState.dead;
                return;
            }
            _unsatisfiedRequets++;
            if (_unsatisfiedRequets >= unsatisfiedRequestsThreshold) _health = HealthState.Sick;
            _timer.Elapsed -= OnActionTimerElapsed;
            _timer.Elapsed += OnIdleTimerElapsed;
            _timer.Start();
        }
        private void OnDeath(object sender, EventArgs e)
        {
            _health = HealthState.dead;
        }
        public void OnUserAction<IEventArgs>(object sender, IEventArgs e) where IEventArgs : EventArgs
        {
            switch (e)
            {
                case PlayEventArgs:
                    if (_LastRequest == RequestedPlay) SatisfyRequest();
                    break;
                case WalkEventArgs:
                    if (_LastRequest == RequestedWalk) SatisfyRequest();
                    break;
                case SleepEventArgs:
                    if (_LastRequest == RequestedSleep) SatisfyRequest(timerInterval);
                    break;
                case HealEventArgs:
                    if (_LastRequest == RequestedHeal)
                    {
                        Heal();
                        SatisfyRequest(timerInterval);
                    }
                    break;
                case FeedEventArgs:
                    if (_LastRequest == RequestedEat) SatisfyRequest();
                    break;
            }
        }
        private void Heal()
        {
            _health = HealthState.Healthy;
        }


        private void SatisfyRequest(double idleTimeout = timerInterval)
        {
            _timer.Stop();
            _timer.Elapsed -= OnActionTimerElapsed;

            _unsatisfiedRequets = 0;

            _timer.Interval = idleTimeout;
            _timer.Elapsed += OnIdleTimerElapsed;
            _timer.Start();
        }

        public void RequestAction()
        {
            if (_health == HealthState.Sick)
            {
                _LastRequest = RequestedHeal;
                RequestedHeal(this, new EventArgs());
            }
            else
            {
                var availableActions = _healthyActions.Where(a => a != _LastRequest).ToList();
                var actionIndex = _random.Next() % availableActions.Count;
                var request = availableActions[actionIndex];
                _LastRequest = request;
                request(this, new EventArgs());
            }
            _timer.Interval = defaultTimerInterval;
            _timer.Elapsed -= OnIdleTimerElapsed;
            _timer.Elapsed += OnActionTimerElapsed;
            _timer.Start();
        }
        //public event EventHandler FailedToStaisfyRequest;


        //void Play(object e, EventArgs args)
        //{

        //}
        //void Walk() { }
        //void Sleep() { }
        //void Eat() { }
        //void Heal() { }

        //void MakeRequest()
        //{

        //}
    }
}
