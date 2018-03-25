using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Condiment : IItem
    {
        public virtual string Name() => "unkonwn";

        public virtual decimal Price() => 0m;
    }
}
