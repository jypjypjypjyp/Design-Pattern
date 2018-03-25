using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    class BusinessDelegate
    {
        private BusinessLookUp lookUp = new BusinessLookUp();
        private IBusinessService businessService;
        private string serviceType;
        public string ServiceType { set => serviceType = value; }
        public void Do()
        {
            businessService = lookUp.GetBusinessService(serviceType);
            businessService.Do();
        }
    }
}
