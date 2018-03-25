using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class BeefHamburger : Hamburger
    {
        public override string Name() => "Beef "+base.Name();

        public override decimal Price() => (Condiment != null) ? Condiment.Price()+50.0m : 50.0m;
    }
}
