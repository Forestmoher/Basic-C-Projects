using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Calculator
    {
        public int tipCalculator(int num)
        {
            int answer = (num / 5) + num;
            return answer;
        }

        public int tipCalculator(decimal tip, decimal cost)
        {
            int answer = Convert.ToInt32((tip * cost) + cost);
            return answer;
        }

        public int tipCalculator(string cost, string people)
        {
            int answer = Convert.ToInt32(cost) / Convert.ToInt32(people);
                return answer;
        }
    }

}
