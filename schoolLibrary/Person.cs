using System;
using System.Collections.Generic;
using System.Text;

namespace schoolLibrary
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string LastName { get; set; }

        // abstract methods have no code in them -- implementation is left up to the developer
        public abstract float ComputeGradeAverage();
    }
}
