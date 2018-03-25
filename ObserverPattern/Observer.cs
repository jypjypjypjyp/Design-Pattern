﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    abstract class Observer : IObserver
    {
        protected Subject Subject;
        public override abstract void Update();
    }
}
