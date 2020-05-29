using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsInC_Sharp
{
    class Calculator
    {
        public int value { get; set; }

        public int Multiply(int numOne, int numTwo)
        {
            int answerOne = numOne * numTwo;
            return answerOne;
        }

        public int Divide(int numOne, int numTwo)
        {
            int answerTwo = numOne / numTwo;
            return answerTwo;
        }

        public int Add(int numOne, int numTwo)
        {
            int answerThree = numOne + numTwo;
            return answerThree;
        }
    }
}
