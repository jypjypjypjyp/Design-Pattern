using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        private int _state;
        public int State
        {
            get
            {
                return _state;
            }
            set
            {
                _state = value;
                NotifyAllObservers();
            }
        }

        public void Attach(IObserver o)
        {
            observers.Add(o);
        }

        public void NotifyAllObservers()
        {
            foreach(var i in observers)
            {
                i.Update();
            }
        }

    }
}
