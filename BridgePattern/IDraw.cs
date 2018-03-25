using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    interface IDraw//桥接接口
    {
        void DrawCircle(double r, double x, double y);
    }
}
