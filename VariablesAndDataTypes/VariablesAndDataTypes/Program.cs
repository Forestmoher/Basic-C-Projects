using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            Console.WriteLine("What course are you on?");
            string currentCourse = Console.ReadLine();

            Console.WriteLine("What page are you on");
            string currentPageStr = Console.ReadLine();
            int currentPageNum = Convert.ToInt32(currentPageStr);

            Console.WriteLine("Do you need help with anything? Please answer 'True' or  'False'.");
            string helpStr = Console.ReadLine();
            bool helpBool = Convert.ToBoolean(helpStr);

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string posExp = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you'd like to provide? Pleasse be specific");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            string hoursStr = Console.ReadLine();
            int hoursStudied = Convert.ToInt32(hoursStr);

            Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Hava a great day!");
            Console.ReadLine();






        }
    }
}
