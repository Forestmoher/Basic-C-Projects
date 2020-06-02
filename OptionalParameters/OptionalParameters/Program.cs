using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceCalculator price = new PriceCalculator();
            Console.WriteLine("Welcome to the Portland Zoo \n How many tickets would you like to purchase?");
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Would you like to buy any passes to feed the monkeys? If so, how many?");
            string answer = Console.ReadLine();
            if (answer != "")
            {
                int passes = Convert.ToInt32(answer);
                
                int total = price.totalCost(tickets, passes);
                Console.WriteLine("Total cost for " + tickets + " ticket(s), and  " + passes + " monkey passe(s) is: $" + total + ".00");
                Console.ReadLine();
            }
            else
            {
                int total = price.totalCost(tickets);
                Console.WriteLine("Total cost for " + tickets + " ticket(s) is: $" + total + ".00");
                Console.ReadLine();
            }
            
          
           
        }
    }
}
