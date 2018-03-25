using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Football : Game
    {
        protected override void EndPlay()
        {
            Console.WriteLine("Football Finished");
        }

        protected override void Initialize()
        {
            Console.WriteLine("Football Initialized");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Football Start");
        }
    }
}
