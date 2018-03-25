using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ShapeCache.LoadCache();
            Rectangle A = (ShapeCache.GetShapePrototype("Rectangle") as Rectangle).Constructor(10,3.4);
            Circle B = (ShapeCache.GetShapePrototype("Circle") as Circle).Constructor(3.5);

            A.Draw();
            B.Draw();
        }
    }
}
