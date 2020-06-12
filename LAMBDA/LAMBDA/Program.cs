using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAMBDA
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();


            ///instantiate 10 new employee objects and add to the list
            employees.Add(new Employee() { FirstName = "Bill", LastName = "Murray", ID = 001 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Stevens", ID = 002 });
            employees.Add(new Employee() { FirstName = "Mary", LastName = "Lewis", ID = 003 });
            employees.Add(new Employee() { FirstName = "Debrah", LastName = "Ramano", ID = 004 });
            employees.Add(new Employee() { FirstName = "Steven", LastName = "Schultz", ID = 005 });
            employees.Add(new Employee() { FirstName = "Forest", LastName = "Moher", ID = 006 });
            employees.Add(new Employee() { FirstName = "Julia", LastName = "Andrews", ID = 007 });
            employees.Add(new Employee() { FirstName = "Abii", LastName = "VanBemmel", ID = 008 });
            employees.Add(new Employee() { FirstName = "Joe", LastName = "Johnson", ID = 009 });
            employees.Add(new Employee() { FirstName = "Jill", LastName = "Jackson", ID = 0010 });


            //create new list for employees with name Joe to be entered
            List<Employee> Joe = new List<Employee>();

            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    Joe.Add(employee);
                }
            }
            foreach (Employee employee in Joe)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }

            //same function as above but using lambda functions 
            List<Employee> Joe2 = employees.Where(x => x.FirstName == "Joe").ToList();
            foreach (Employee joe in Joe2)
            {
                Console.WriteLine(joe.FirstName + " " + joe.LastName);
            }

            //this list id for employees with ID greater than 5
            List<Employee> greaterThanFive = employees.Where(x => x.ID > 005).ToList();
            foreach (Employee greater in greaterThanFive)
            {
                Console.WriteLine(greater.FirstName + " " + greater.LastName + " " + greater.ID);
            }
            Console.ReadLine();


        }
    }
}
