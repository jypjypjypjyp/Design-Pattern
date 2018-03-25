using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessDelegate businessDelegate = new BusinessDelegate
            {
                ServiceType = "EJB"
            };
            Client client = new Client(businessDelegate);
            client.Do();
            businessDelegate.ServiceType = "JMS";
            client.Do();
        }
    }
}
