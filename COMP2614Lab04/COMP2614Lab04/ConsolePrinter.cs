using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP2614Lab04
{
    class ConsolePrinter
    {
        public static void PrintCollection(PersonCollection people)
        { 
            int totalAge = 0;
            int totalPeople = 0;
            Console.WriteLine("{0,-15} {1,-15} {2,5}", "Last Name", "First Name", "Age");
            Console.WriteLine(new string('-', 37));
            foreach (Person person in people)
            {               
                totalAge += person.Age;
                totalPeople++;
                Console.WriteLine($"{person.LastName,-15} {person.FirstName,-15} {person.Age,4}");
            }
            Console.WriteLine(new string('-', 37));
            Console.WriteLine("{0,-25} {1,-15}", "Total average is: ", totalPeople);
            Console.WriteLine("{0,-25} {1,-15}", "Total age is:", totalAge);
            Console.WriteLine("{0,-25} {1,-15:N2}", "Average age is:",(double)totalAge/totalPeople);
        }
    }
}
