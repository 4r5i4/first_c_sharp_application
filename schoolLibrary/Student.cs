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

        //this is a virtual message -- overriden for the student class 
        public override string sendInternalMessage(string message)
        {
            var origianlMessage = base.sendInternalMessage(message);
            var sb = new StringBuilder(origianlMessage);
            sb.AppendLine("This is a disclaimer for student");
            return sb.ToString();
        }
    }
}
