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

        public virtual String sendInternalMessage(string message)
        {
            var sb = new StringBuilder();

            var timestamp = string.Format("Sent on {0:D} at {0:t}", DateTime.Now);
            sb.AppendLine(timestamp);
            sb.AppendLine("");
            sb.AppendLine("Dear" + this.FirstName + ",");
            sb.AppendLine(message);
            return sb.ToString();
            
        }
    }
}
