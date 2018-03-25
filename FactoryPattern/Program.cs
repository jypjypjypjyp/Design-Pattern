using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory sf = new ShapeFactory();
            Rectangle r = (Rectangle)sf.CreateInstance("Rectangle");
            Square s = (Square)sf.CreateInstance("Square");
            Console.Write(r.Name());
            Console.Write(s.Name());
        }
    }
}
