﻿

using System;
using System.Text;

namespace SchoolLibrary
{

    
    public class School
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }

        private string _twitterAddress;
        public string TwitterAddress
        {
            //make sure twitter address starts with @sign
            get { return TwitterAddress; }
            set
            {
                if (value.StartsWith("@"))
                {
                    _twitterAddress = value;
                }
                else
                {
                    throw new Exception("the twitter address must begin with @");
                }
            }
        }
        public School()
        {
            Name = "Untitled school";
            PhoneNumber = "555-1234";
        }

        public School(string SchoolName, string schoolPhoneNumber)
        {
            Name = SchoolName;
            PhoneNumber = schoolPhoneNumber;
        }

        //public float AverageThreeScores(float a , float b, float c)
        //{
        //    var result = (a + b + c) / 3;
        //    return result;
        //}

        public static float AverageThreeScores(float a, float b, float c) => (a + b + c) / 3;

        public static int AverageThreeScores(int a, int b, int c)
        {
            var result = (a + b + c) / 3;
            return result;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(Name);
            sb.AppendLine(Address);
            sb.AppendLine(City);
            sb.Append(",");
            sb.Append(State);
            sb.Append(",");
            sb.Append(Zip);

            return sb.ToString();
        }
    }
}
