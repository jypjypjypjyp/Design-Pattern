using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectPattern
{
    abstract class AbstractCustomer
    {
        protected string _name;
        public abstract string Name { get; }
        public abstract bool IsNuLL();
    }
}
