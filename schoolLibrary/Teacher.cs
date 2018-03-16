using System;
using System.Collections.Generic;
using System.Text;

namespace schoolLibrary
{
    public class Teacher : Person
    {
        public string Subject { get; set; }

        public override float ComputeGradeAverage()
        {
            return 3.5f;
        }
    }
}
