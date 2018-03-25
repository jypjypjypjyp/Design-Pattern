using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class NullCustomer : AbstractCustomer
    {
        public override string Name => "Not Available!";

        public override bool IsNuLL()
        {
            return true;
        }
    }
}
