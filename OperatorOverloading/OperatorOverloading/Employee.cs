using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public static string operator ==(Employee employeeOne, Employee employeeTwo)
        {
            string outcome;
            if (employeeOne.ID == employeeTwo.ID)
            {
                outcome = "**Employees have same employee ID";               
            }
            else
            {
                outcome = "**Employees have unique employee IDs";
            }
            return outcome;
        }
        public static string operator !=(Employee employeeOne, Employee employeeTwo)
        {
            string outcome;
            if (employeeOne.ID != employeeTwo.ID)
            {
                outcome = "**Employees have unique employee IDs";
            }
            else
            {
                outcome = "**Employees have same employee ID";
            }
            return outcome;
        }

    }
}
