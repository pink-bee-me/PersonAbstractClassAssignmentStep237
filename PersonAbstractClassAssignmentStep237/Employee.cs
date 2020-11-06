using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractClassAssignmentStep237
{
   public class Employee : Person, IGetPersonalInfo

    {

        FirstName = firstName;
        LastName = lastName;

        public Employee()
        { }

        

        public Employee(string firstName, string lastName)
        {
         
          

        }

        public override void GetName()
        {
            {
                Console.WriteLine("Enter Employee First Name: ");
                var firstName = Console.ReadLine();

                Console.WriteLine("Enter Employee Last Name: ");
                var lastName = Console.ReadLine();

            }
        }

        public override void SayName()
        {
    
            base.SayName(FirstName,LastName);
            
        }

        public void Quit(Employee employee)
        {
            Console.WriteLine("Is " + employee.FullName + " a current employee? Enter 1 for \"Yes\" or 2 for \"No\": ");
            var employeeStatus = Convert.ToInt32(Console.ReadLine());

            var activeStatus = (employeeStatus == 1) ? "Employment Status: Active " : "Employment Status: InActive ";
            Console.WriteLine(activeStatus);
            
            if (employeeStatus == 2)
            {
                Console.WriteLine("Cause For InActive Status:\n  Enter < 1 > for Voluntary Resignation \n  Enter < 2 > for Official Termination ");
                var termsOfInActiveStatus = Convert.ToInt32(Console.ReadLine());

                var quitOrFired = (termsOfInActiveStatus == 1) ? "Eligible for Re-Employment" : "No Further Employment Allowed !!!";
            }
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }






    }
}
