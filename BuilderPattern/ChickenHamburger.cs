using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class ChickenHamburger : Hamburger
    {
        public override string Name() => "Chicken "+base.Name();

        public override decimal Price() => (Condiment != null) ? 45.0m + Condiment.Price() : 45.0m;
    }
}
