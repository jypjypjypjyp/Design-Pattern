using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Originator
    {
        public string State { get; set; }
        public Memento Save()
        {
            return new Memento() { State = this.State };
        }
        public void LoadSave(Memento memento)
        {
            State = memento.State;
        }
    }
}
