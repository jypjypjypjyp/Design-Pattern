using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class HexObserver:Observer
    {
        public HexObserver(Subject s)
        {
            subject = s;
            subject.Attach(this);
        }
        public override void Update()
        {
            Console.WriteLine("Hex String: " + Convert.ToString(subject.State, 16));
        }
    }
}
