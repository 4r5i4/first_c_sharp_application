using System;
using System.Collections.Generic;
using System.Text;

namespace schoolLibrary
{
    public class Student : Person
    {
        public enum GradeLevels { Freshman, Sophomore, Junior, Senior }
        public GradeLevels GradeLevel { get; set; }

        public override float ComputeGradeAverage()
        {

            return 4.0f;
        }
    }
}
