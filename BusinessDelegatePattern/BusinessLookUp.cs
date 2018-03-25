using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    class BusinessLookUp
    {
        public IBusinessService GetBusinessService(string type)
        {
            if (type.ToUpper() == "EJB")
            {
                return new EJBService();
            }
            else
            {
                return new JMSService();
            }
        }
    }
}
