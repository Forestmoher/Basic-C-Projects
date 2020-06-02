using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethod
{
    class Class1
    {
        public void voidMethod(int numOne, int numTwo)
        {
            int total = numOne * 10;
            Console.WriteLine(numOne + " times ten equals: " + total);
            Console.WriteLine(numTwo);
        }
    }
}
