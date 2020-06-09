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

        public static bool operator ==(Employee employeeOne, Employee employeeTwo)
        {
            bool outcome;
            if (employeeOne.ID == employeeTwo.ID)
            {
                outcome = true;               
            }
            else
            {
                outcome = false;
            }
            return outcome;
        }
        public static bool operator !=(Employee employeeOne, Employee employeeTwo)
        {
            bool outcome;
            if (employeeOne.ID != employeeTwo.ID)
            {
                outcome = true;
            }
            else
            {
                outcome = false;
            }
            return outcome;
        }

    }
}
