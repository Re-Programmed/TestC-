using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finnss
{
    public class Program
    {
        public static void Main()
        {
            //Program start code
            Person p = new Person("Bobbi", "Jo");

            printPerson(p);
        }

        static void printPerson(Person person)
        {
            Console.WriteLine(person.GetFullName());
        }
    }
}
