using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    class CustomerFactory
    {
        public static readonly string[] Names = { "Rob", "Joe", "Juile" };
        public static AbstractCustomer GetCustomer (string name)
        {
            foreach(var i in Names)
            {
                if (i.ToUpper() == name.ToUpper())
                    return new RealCustomer(name);
            }
            return new NullCustomer();
        }
    }
}
