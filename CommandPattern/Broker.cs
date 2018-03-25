using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Broker
    {
        private List<IOrder> list = new List<IOrder>();
        public void TakeOrder(IOrder o)
        {
            list.Add(o);
        }
        public void PlaceOrders()
        {
            foreach(var i in list)
            {
                i.Execute();
            }
            list.Clear();
        }
    }
}
