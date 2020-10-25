﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAbstractClassAssignmentStep237
{
   public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Name of Person Added To System: " + fullName);
        }
    }
}
