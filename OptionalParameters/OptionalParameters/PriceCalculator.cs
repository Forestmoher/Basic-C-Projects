using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameters
{
    class PriceCalculator
    {
        public int totalCost(int tickets, int passes = 0)
        {
            int total = (tickets * 10) + (passes * 8);
            return total;
        }
    }
}
