using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 example = new Class1();

            //void method 
            Console.WriteLine("Please enter a number: ");
            int numOne = Convert.ToInt32(Console.ReadLine());
            example.divide(numOne);

            //output parameters
            Console.WriteLine("Please enter a number: ");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int numthree = Convert.ToInt32(Console.ReadLine());
            int result;
            example.multiply(numTwo, numthree, out result);
            Console.WriteLine(numTwo + " times " + numthree + " equals " + result);

            //overloaded method
            Console.WriteLine("Please enter a number: ");
            int numFour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number: ");
            int numFive= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter one more number:");
            int numSix = Convert.ToInt32(Console.ReadLine());
            example.multiply(numFour, numFive, numSix);

            //static class method'
            Console.WriteLine("Please enter a number:");
            int numSeven = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a number:");
            int numEight = Convert.ToInt32(Console.ReadLine());
            int answer = Class2.Module(numSeven, numEight);
            Console.WriteLine("The remainder of " + numSeven + " divided by " + numEight + " equals " + answer);
            Console.ReadLine();
        }
    }
}
