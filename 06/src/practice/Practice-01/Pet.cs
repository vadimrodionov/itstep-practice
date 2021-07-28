using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using VadimRodionov.Practice_01.Enums;
using VadimRodionov.Practice_01.EventArgModels;

namespace VadimRodionov.Practice_01
{
    public class Pet
    {
        private readonly static Random _rand = new Random();

        private const double defaultTimerInterval = 5000;
        private const double extendedTimerInterval = 10000;
        private const double unsatisfiedRequestsThreshold = 3;

        readonly List<Action> _healthyActions;
        readonly Timer _timer;
        
        readonly DateTime _dateOfBirth;
        DateTime? _dateOfDeath;

        HealthState _health;
        Age Age => (DateTime.Now - _dateOfBirth).TotalSeconds switch {
            var age when age < 30               => Age.Young,
            var age when age >= 30 && age < 120 => Age.Adult,
            var age when age >= 120             => Age.Old,
            _ => throw new ArgumentOutOfRangeException(nameof(Age))
        };

        int _unsatisfiedRequests;
        int _totalSatisfiedRequests;


        Action _lastRequest;

        public event EventHandler RequestedFood;
        public event EventHandler RequestedPlay;
        public event EventHandler RequestedSleep;
        public event EventHandler RequestedWalk;
        public event EventHandler RequestedHeal;

        public event EventHandler Satisfied;
        public event EventHandler Unsatisfied;
        public event EventHandler Died;

        public Pet()
        {
            _dateOfBirth = DateTime.Now;

            _health = HealthState.Healthy;
            _unsatisfiedRequests = 0;
            _totalSatisfiedRequests = 0;
            _timer = new Timer(defaultTimerInterval);
            _timer.AutoReset = false;

            _healthyActions = new List<Action>() {
                RequestFood, RequestPlay, RequestSleep, RequestWalk
            };

            Died += OnDeath;
        }

        public string Stats => _health == HealthState.Dead
            ? $"Время жизни: {((_dateOfDeath ?? DateTime.Now) - _dateOfBirth).TotalSeconds} секунд, выполненных просьб: {_totalSatisfiedRequests}"
            : $"Состояние здоровья: {GetHealthDescription()}, Возраст: {GetAgeDescription()}";

        public void Initialize()
        {
            _timer.Elapsed += OnIdleTimerElapsed;
            _timer.Start();
        }

        public void RequestAction()
        {
            _timer.Stop();

            if (_health == HealthState.Sick)
            {
                _lastRequest = RequestHeal;
            }
            else
            {
                var availableActions = _healthyActions.Where(a => a != _lastRequest).ToList();
                var actionIndex = _rand.Next() % availableActions.Count;
                _lastRequest = availableActions[actionIndex];
            }

            _lastRequest();

            _timer.Interval = defaultTimerInterval;
            _timer.Elapsed -= OnIdleTimerElapsed;
            _timer.Elapsed += OnActionTimerElapsed;
            _timer.Start();
        }

        private void Heal()
        {
            _health = HealthState.Healthy;
        }

        private void SatisfyRequest(double idleTimeout = defaultTimerInterval)
        {
            // stop action timer
            _timer.Stop();
            _timer.Elapsed -= OnActionTimerElapsed;

            // raise Satisfied
            Satisfied(this, EventArgs.Empty);

            // adjust state
            _totalSatisfiedRequests++;
            _unsatisfiedRequests = 0;

            // start idle timer
            _timer.Interval = idleTimeout;
            _timer.Elapsed += OnIdleTimerElapsed;
            _timer.Start();
        }

        private string GetHealthDescription() => _health switch
        {
            HealthState.Healthy => "Здоров",
            HealthState.Sick => "Болен",
            HealthState.Dead => "Мёртв",
            _ => throw new ArgumentOutOfRangeException(nameof(_health))
        };

        private string GetAgeDescription() => Age switch
        {
            Age.Young => "Молодой",
            Age.Adult => "Взрослый",
            Age.Old => "Старый",
            _ => throw new ArgumentOutOfRangeException(nameof(Age))
        };

        public void OnUserAction<TEventArgs>(object sender, TEventArgs e) where TEventArgs : EventArgs
        {
            switch (e)
            {
                case PlayEventArgs:
                    if (_lastRequest == RequestPlay)
                        SatisfyRequest();
                    break;
                case WalkEventArgs:
                    if (_lastRequest == RequestWalk)
                        SatisfyRequest();
                    break;
                case SleepEventArgs:
                    if (_lastRequest == RequestSleep)
                        SatisfyRequest(extendedTimerInterval);
                    break;
                case FeedEventArgs:
                    if (_lastRequest == RequestFood)
                        SatisfyRequest();
                    break;
                case HealEventArgs:
                    if (_lastRequest == RequestHeal)
                    {
                        Heal();
                        SatisfyRequest(extendedTimerInterval);
                    }
                    break;
                default: break;
            }
        }

        private void OnIdleTimerElapsed(object sender, EventArgs e)
        {
            RequestAction();
        }

        private void OnActionTimerElapsed(object sender, EventArgs e)
        {
            _timer.Stop();

            if (_health == HealthState.Sick)
            {
                Died(this, EventArgs.Empty);
                return;
            }

            Unsatisfied(this, EventArgs.Empty);

            _unsatisfiedRequests++;
            if (_unsatisfiedRequests >= unsatisfiedRequestsThreshold)
                _health = HealthState.Sick;


            _timer.Elapsed -= OnActionTimerElapsed;
            _timer.Elapsed += OnIdleTimerElapsed;
            _timer.Start();
        }

        private void OnDeath(object sender, EventArgs e)
        {
            _health = HealthState.Dead;
            _dateOfDeath = DateTime.Now;
        }

        private void RequestFood() => RequestedFood(this, new FeedEventArgs());
        private void RequestPlay() => RequestedPlay(this, new PlayEventArgs());
        private void RequestSleep() => RequestedSleep(this, new SleepEventArgs());
        private void RequestWalk() => RequestedWalk(this, new WalkEventArgs());
        private void RequestHeal() => RequestedHeal(this, new HealEventArgs());
    }
}
