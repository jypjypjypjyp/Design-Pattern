using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    abstract class ShapePrototype
    {
        public volatile static int num = 0;
        public int Id { get; set; }
        public string Type { get; set; }
        public ShapePrototype()
        {
            Id = num++;
        }

        public abstract void Draw();
        public abstract object Clone();
    }
}
