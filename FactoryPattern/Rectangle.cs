using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Rectangle : IShape
    {
        private string name = "Rectangle";
        
        public string Name()
        {
            return name;
        }
    }
}
