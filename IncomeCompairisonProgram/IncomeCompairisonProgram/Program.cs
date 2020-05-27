using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeCompairisonProgram
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Anonymous Income Compairison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?:");
            string hourRateOneStr = Console.ReadLine();
            Console.WriteLine("Hours worked per week?:");
            string hourPerWeekOneStr = Console.ReadLine();

            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?:");
            string hourRateTwoStr = Console.ReadLine();
            Console.WriteLine("Hours worked per week?:");
            string hourPerWeekTwoStr = Console.ReadLine();

            decimal hourRateOne = Convert.ToDecimal(hourRateOneStr);
            decimal hourPerWeekOne = Convert.ToDecimal(hourPerWeekOneStr);
            decimal salaryOne = (hourRateOne * hourPerWeekOne) * 52;
            Console.WriteLine("Annual salary of Person 1: " + salaryOne);

            decimal hourRateTwo = Convert.ToDecimal(hourRateTwoStr);
            decimal hourPerWeekTwo = Convert.ToDecimal(hourPerWeekTwoStr);
            decimal salaryTwo = (hourRateTwo * hourPerWeekTwo) * 52;
            Console.WriteLine("Annual salary of Person 1: " + salaryTwo);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money than Person 2?: " + (salaryOne > salaryTwo));
            Console.ReadLine();


        }
    }
}
