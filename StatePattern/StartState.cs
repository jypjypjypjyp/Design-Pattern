using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class StartState : IState
    {
        public override string ToString()
        {
            return "Start State";
        }
        public void Do(Context context)
        {
            Console.WriteLine("Player in start state!");
            context.state = this;
        }
    }
}
