using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    class JMSService : IBusinessService
    {
        public void Do()
        {
            Console.WriteLine("Processing task by invoking JMS Service");
        }
    }
}
