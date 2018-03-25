using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    class StopState : IState
    {
        public override string ToString()
        {
            return "Stop State";
        }
        public void Do(Context context)
        {
            Console.WriteLine("Player in stop state!");
            context.state = this;
        }
    }
}
