using System;
using System.Collections.Generic;
using System.Text;

namespace schoolLibrary
{
    public class School
    {
        public String schoolName { get; set; }

        private String _twitterAddress;
        public String twitterAddress
        {
            //make sure the address starts with an @ symbol
            get { return _twitterAddress; }
            set
            {
                if(value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("Twitter address must begin with @");
                }
            }
        }

        public School()
        {
            schoolName = "United School";

        }

        public static float averagenumber(float a, float b)
        {
            return a + b;
        }


        public School(string schoolName)
        {
            this.schoolName = schoolName;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("this is the overriden toString method()");
            sb.AppendLine(this.schoolName);
            return sb.ToString();
        }
    }
}
