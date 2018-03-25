using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class BuyStock : IOrder
    {
        private Stock stock;
        public BuyStock(Stock s)
        {
            stock = s;
        }
        public void Execute()
        {
            stock.Buy();
        }
    }
}
