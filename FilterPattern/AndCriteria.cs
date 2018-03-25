using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    class AndCriteria : ICriteria
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public  AndCriteria(ICriteria c,ICriteria oc)
        {
            criteria = c;
            otherCriteria = oc;
        }

        public List<Person> MeetCriteria(List<Person> p)
        {
            return otherCriteria.MeetCriteria(criteria.MeetCriteria(p));
        }
    }
}
