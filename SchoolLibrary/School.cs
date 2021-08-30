using System;

namespace SchoolLibrary
{
    class School
    {
        string Name { get; set; }
        string Address { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Zip { get; set; }
        string PhoneNumber { get; set; }


        private string _twitterAddress;
        public string TwitterAddress
        {
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
    }
}
