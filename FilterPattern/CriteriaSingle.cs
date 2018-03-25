using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    class CriteriaSingle : ICriteria
    {
        public List<Person> MeetCriteria(List<Person> p)
        {
            return (from i in p where i.MaritalStatus.ToUpper() == "SINGLE" select i).ToList();
        }
    }
}
