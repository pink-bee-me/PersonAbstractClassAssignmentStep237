using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractClassAssignmentStep237
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();



            Employee.GetName();
            Employee.SayName(firstName, lastName);
            var employee2 = new Employee();
            employee2.GetName();
            employee2.SayName(employee2.FirstName, employee2.LastName);
            employee2.Quit(employee2);



        }
    }
}
