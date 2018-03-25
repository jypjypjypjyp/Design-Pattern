using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Square : IShape
    {
        private string name = "Square";

        public string Name()
        {
            return name;
        }
    }
}
