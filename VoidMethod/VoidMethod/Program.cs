using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int numOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            int numTwo = Convert.ToInt32(Console.ReadLine());

            Class1 voidExample = new Class1();
            voidExample.voidMethod(numOne: numOne, numTwo: numTwo);
            Console.ReadLine();
        }
    }
}
