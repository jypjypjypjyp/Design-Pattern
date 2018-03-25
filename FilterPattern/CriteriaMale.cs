using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    class CriteriaMale : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> p)
        {
            return (from i in p where i.Gender.ToUpper() == "MALE" select i).ToList();
        }
    }
}
