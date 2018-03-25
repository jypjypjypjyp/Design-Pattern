using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class HotCondiment : Condiment
    {
        public override string Name()
        {
            return "Hot";
        }
        public override decimal Price()
        {
            return 3.0m;
        }
    }
}
