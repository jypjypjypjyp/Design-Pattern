using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class ShapeCache
    {
        private static HashSet<ShapePrototype> ShapeCacheMap = new HashSet<ShapePrototype>();
        public static ShapePrototype GetShapePrototype(string type)
        {
            try
            {
                return ShapeCacheMap.Where(a => (a.Type == type)).Select(a => a).First();
            }
            catch
            {
                return null;
            }
        }
        public static void LoadCache()
        {
            ShapeCacheMap.Add(new Rectangle(1, 1));
            ShapeCacheMap.Add(new Circle(1));
        }
    }
}
