using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Behavioral.Observer
{
    public abstract class Subject
    {
        private ICollection<Observer> _observers = new List<Observer>();

        public virtual void Attach(Observer observer)
        {
            if (!_observers.Contains(observer))
                _observers.Add(observer);
        }

        public virtual void Detach(Observer observer)
        {
            if (_observers.Contains(observer))
                _observers.Remove(observer);
        }

        public virtual void Notify()
        {
            foreach (Observer observer in _observers)
                observer.Update(this);
        }
    }
}
