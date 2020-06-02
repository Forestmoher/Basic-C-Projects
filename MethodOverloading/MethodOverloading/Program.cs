using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            //method takes in an integer
            Console.WriteLine("Enter the cost of the meal and we will add a 20% tip");
            int cost = Convert.ToInt32(Console.ReadLine());
            int total = calculator.tipCalculator(cost);
            Console.WriteLine("The total cost of the meal is " + total);
            Console.ReadLine();
   
            //method takes in two decimal values
            Console.WriteLine("Enter in the cost of the meal:");
            decimal costTwo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter the tip percentage you want (.10,.18,.20)");
            decimal tip = Convert.ToDecimal(Console.ReadLine());

            total = Convert.ToInt32(calculator.tipCalculator(tip, costTwo));
            Console.WriteLine("The total including tip is " + total);
            Console.ReadLine();

            //method takes in two strings 
            Console.WriteLine("Enter in the cost of the meal:");
            string costThree = Console.ReadLine();
            Console.WriteLine("Enter in the number of people in your party:");
            string people = Console.ReadLine();
            total = Convert.ToInt32(calculator.tipCalculator(costThree, people));
            Console.WriteLine("The cost per person is " + total);
            Console.ReadLine();
        }
    }
}
