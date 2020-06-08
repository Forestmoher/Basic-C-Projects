using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Employee : Person, IQuittable
    {
        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            {
                LastName += " *Resigned*";
                Console.WriteLine("This emplyee has resigned: \n {0} {1}", FirstName, LastName );
            }
        }
    }
}
