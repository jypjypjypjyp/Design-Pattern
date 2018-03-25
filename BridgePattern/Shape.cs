using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    abstract class Shape
    {
        protected IDraw drawApi;
        protected Shape(IDraw d)
        {
            drawApi = d;
        }
        public abstract void Draw();
    }
}
