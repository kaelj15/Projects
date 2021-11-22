
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAndSort
{
    class Person
    {
        private int age;
        private string firstName;
        private string lastName;


        public int Age
        {
            get { return age; }

            set { age = value; }
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


        public Person()
        {
            Age = 0;
            firstName = "Unkown";
            lastName = "Unkown";
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}
