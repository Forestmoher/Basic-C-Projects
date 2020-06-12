using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The current time is {0}", DateTime.Now);
            Console.WriteLine("Please enter a number:");
            int num = Convert.ToInt32(Console.ReadLine());
            DateTime now = DateTime.Now;
            TimeSpan tspan = new TimeSpan(0, num, 0, 0);
            
            Console.WriteLine("In {0} hours it will be {1}", num, now.Add(tspan));

            Console.ReadLine();
        }
    }
}
