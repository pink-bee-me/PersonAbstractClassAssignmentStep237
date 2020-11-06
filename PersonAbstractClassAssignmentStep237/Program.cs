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

<<<<<<< Updated upstream
=======

            Employee employee1 = new Employee();
            employee1.GetName();
            employee1.SayName(firstName, lastName);

            var employee2 = new Employee();
            employee2.GetName();
            employee2.SayName(employee2.FirstName, employee2.LastName);
            employee2.Quit(employee2);



>>>>>>> Stashed changes
        }
    }
}
