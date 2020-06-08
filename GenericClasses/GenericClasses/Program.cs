using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasses
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> employee = new Employee<string>();
            employee.Things = new List<string>() { "Forest", "Moher", "Chef" };
            Employee<int> employeeTwo = new Employee<int>();
            employeeTwo.Things = new List<int>() { 27, 55, 22 };

            foreach (string thing in employee.Things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in employeeTwo.Things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
