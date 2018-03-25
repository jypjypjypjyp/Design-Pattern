using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class OctalObserver:Observer
    {
        public OctalObserver(Subject s)
        {
            subject = s;
            subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Octal String: " + Convert.ToString(subject.State, 8));
        }
    }
}
