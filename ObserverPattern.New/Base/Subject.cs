using System.Collections.Generic;

namespace ObserverPattern.New.Base
{
    public class Subject
    {
        private readonly List<Observer> _observers = new List<Observer>();

        public void AttachObserver(Observer observer)
        {
            _observers.Add(observer);
        }

        public void DetachObserver(Observer observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObserver(Subject subject, object arg)
        {
            _observers.ForEach((obj) => obj.Notify(subject, arg));
        }
    }
}