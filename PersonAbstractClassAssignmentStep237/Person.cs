using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractClassAssignmentStep237
{
<<<<<<< Updated upstream
   public abstract class Person
=======
   public abstract class Person 
>>>>>>> Stashed changes
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

<<<<<<< Updated upstream
        public virtual void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Name of Person Added To System: " + fullName);
=======

       
        
        

        public virtual void SayName()
        {
            Console.WriteLine("Enter Employee First Name: ");
            var firstName = Console.ReadLine();

            Console.WriteLine("Enter Employee Last Name: ");
            var lastName = Console.ReadLine();
            
            var fullName = $"{firstName} { lastName}";
         
>>>>>>> Stashed changes
        }
    }
}
