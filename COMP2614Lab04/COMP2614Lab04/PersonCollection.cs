using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab04
{
    class PersonCollection : List<Person>
    {
        public PersonCollection()
        {

        }

        public PersonCollection(int age) : base(age) //super age
        {

        }

    }
}
