using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassMethods
{
    class Class1
    {
        public void divide(int num)
        {
            int total = num / 2;
            Console.WriteLine(num + " divided by 2 equals " + total);
        }

        public void multiply(int numOne, int numTwo, out int result)
        {
            result = numOne * numTwo;
        }

        public void multiply(int numOne, int numTwo, int numThree)
        {
            int answer = numOne * numTwo * numThree;
            Console.WriteLine(numOne + " times " + numTwo + " times " + numThree + " equals " + answer);
        }

  
    }
}
