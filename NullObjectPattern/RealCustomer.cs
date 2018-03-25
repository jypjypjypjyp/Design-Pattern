using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            _name = name;
        }

        public override string Name => _name;

        public override bool IsNuLL()
        {
            throw new NotImplementedException();
        }
    }
}
