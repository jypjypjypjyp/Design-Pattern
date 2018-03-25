using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    class OrCriteria:ICriteria
    {
        private ICriteria criteria;
        private ICriteria otherCriteria;

        public OrCriteria(ICriteria c,ICriteria oc)
        {
            criteria = c;
            otherCriteria = oc;
        }

        public List<Person> MeetCriteria(List<Person> p)
        {
            return criteria.MeetCriteria(p).Union(otherCriteria.MeetCriteria(p)).ToList();
        }
    }
}
