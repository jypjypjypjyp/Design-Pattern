using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class BinaryObserver : Observer
    {
        public BinaryObserver(Subject s)
        {
            subject = s;
            subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Binary String: " + Convert.ToString(subject.State,2));
        }
    }
}
