using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Forest = new Employee()
            {
                FirstName = "Forest",
                LastName = "Moher",
                ID = 001
            };
            Employee Tom = new Employee()
            {
                FirstName = "Tom",
                LastName = "Elam",
                ID = 002
            };
            bool outcome = Tom == Forest;
            Console.WriteLine(outcome);
            Console.ReadLine();

        }
    }
}
