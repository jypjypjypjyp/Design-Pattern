using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class ShapeFactory
    {
        public IShape CreateInstance(string name)
        {
            switch (name)
            {
                case "Square":return new Square();
                case "Rectangle":return new Rectangle();
                default:return null;
            }
        }
    }
}
