using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQ
{
    class Staff
    {
        string firstName;
        string lastName;
        string office;

        public string Office
        {
            get { return office; }
            set { office = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public Staff()
        {
            firstName = "unknown";
            lastName = "unknown";
            office = "01-1-01";
        }

        public Staff(string f, string l, string o)
        {
            firstName = f;
            lastName = l;
            office = o;
        }

        public override string ToString()
        {
            return firstName + " " + lastName + " " + office;
        }
    }
}
