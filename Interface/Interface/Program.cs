using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IQuittable Forest = new Employee() { FirstName = "Forest", LastName = "Moher" };
            Forest.Quit();           

            Console.ReadLine();
        }
    }
}
