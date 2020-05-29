using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsInC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            try
            {
                Console.WriteLine("We are gonna do some simple math operations");
                Console.WriteLine("Enter a number:");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a another number:");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Calculating.........");
                Console.ReadLine();

                int answerOne = calculator.Multiply(numOne, numTwo);
                int answerTwo = calculator.Divide(numOne, numTwo);
                int answerThree = calculator.Add(numOne, numTwo);

                Console.WriteLine(numOne + " times " + numTwo + " equals " + answerOne);
                Console.WriteLine(numOne + " divided by " + numTwo + " equals " + answerTwo);
                Console.WriteLine(numOne + " plus " + numTwo + " equals " + answerThree);
                Console.ReadLine();

            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a valid whole number");
            }
            finally
            {
                Console.ReadLine();

            }


        }
    }
}
