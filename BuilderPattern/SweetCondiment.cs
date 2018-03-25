using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class SweetCondiment : Condiment
    {
        public override string Name() => "Sweet";

        public override decimal Price() => 2.0m;
    }
}
