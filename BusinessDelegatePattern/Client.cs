using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessDelegatePattern
{
    class Client
    {
        BusinessDelegate businessDelegate;
        public Client(BusinessDelegate businessDelegate)
        {
            this.businessDelegate = businessDelegate;
        }
        public void Do()
        {
            businessDelegate.Do();
        }
    }
}
