using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Student model = new Student()
            {
                Name = "Robert",
                RollNo = "10"
            };
            StudentView view = new StudentView();
            StudentController controller = new StudentController()
            {
                Model = model,
                View = view
            };
            controller.UpdateView();
            controller.Model.Name = "John";
            controller.UpdateView();
        }
    }
}
