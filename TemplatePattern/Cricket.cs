using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePattern
{
    class Cricket : Game
    {

        protected override void EndPlay()
        {
            Console.WriteLine("Cricket Finished");
        }

        protected override void Initialize()
        {
            Console.WriteLine("Cricket Initialized");
        }

        protected override void StartPlay()
        {
            Console.WriteLine("Cricket Start");
        }
    }
}
