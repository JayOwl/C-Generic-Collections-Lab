using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab04
{
    class Person : IComparable<Person>
    {
        private string firstName;
        private string lastName;
        private int age;

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

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public int CompareTo(Person productObjectArgument)
        {
            if (productObjectArgument == null)
            {
                return 1;
            }

            return this.LastName.CompareTo(productObjectArgument.FirstName);
        }
    }
}
