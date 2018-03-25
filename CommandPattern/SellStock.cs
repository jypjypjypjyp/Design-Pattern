using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class SellStock:IOrder
    {
        private Stock stock;
        public SellStock(Stock s)
        {
            stock = s;
        }
        public void Execute()
        {
            stock.Sell();
        }
    }
}
