using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractClassAssignmentStep237
{
   public abstract class Person : IGetPersonalInfo
    {


        public abstract void GetName();
        
        

        public virtual void SayName(string firstName, string lastName)
        {
          var fullName = firstName + " " + lastName;
            Console.WriteLine(fullName);
        }
    }
}
