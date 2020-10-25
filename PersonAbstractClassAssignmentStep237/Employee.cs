using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractClassAssignmentStep237
{
   public class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine("You have added a new Person Object to the Employee Class.");
            base.SayName();
            
        }
    }
}
