using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterPattern
{
    static class Helper
    {
        public static string ToPersonString(this List<Person> list)
        {
            return "Person:[" + String.Join(",", (list.Select(i => i.ToString()).ToArray())) + "]";
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>
            {
                new Person("Robert", "Male", "Single"),
                new Person("John", "Male", "Married"),
                new Person("Laura", "Female", "Married"),
                new Person("Diana", "Female", "Single"),
                new Person("Mike", "Male", "Single"),
                new Person("Bobby", "Male", "Single")
            };

            ICriteria male = new CriteriaMale();
            ICriteria female = new CriteriaFemale();
            ICriteria single = new CriteriaSingle();
            ICriteria singleMale = new AndCriteria(single, male);
            ICriteria singleOrFemale = new OrCriteria(single, female);

            Console.WriteLine("Males: ");
            Console.WriteLine(male.MeetCriteria(persons).ToPersonString());

            Console.WriteLine("\nFemales: ");
            Console.WriteLine(female.MeetCriteria(persons).ToPersonString());

            Console.WriteLine("\nSingle Males: ");
            Console.WriteLine(singleMale.MeetCriteria(persons).ToPersonString());

            Console.WriteLine("\nSingle Or Females: ");
            Console.WriteLine(singleOrFemale.MeetCriteria(persons).ToPersonString());
            
        }
    }
}
