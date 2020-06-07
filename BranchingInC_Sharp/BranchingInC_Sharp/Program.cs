using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BranchingInC_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("What is your favorite number?");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 15 ? "That is my fav number too!" : "That's a cool number!";

            //Console.WriteLine(result);
            //Console.ReadLine();


            ////int currentTemp = 70;
            //int roomTemp = 70;

            //Console.WriteLine("Hi, What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi ," + name + ", what is the temperature where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp");
            //}
            //else if (currentTemp > roomTemp )
            //{
            //    Console.WriteLine("It is hotter than room temp");
            //}
            //else if (currentTemp < roomTemp)
            //{
            //    Console.WriteLine("It is colder than room temp");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong!");
            //}

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temp");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("Is is hotter in here than outside.");
            //}
            //else
            //{
            //    Console.WriteLine("It isn't room temp");
            //}

            //string compareResult = currentTemp == roomTemp ? "It is room temp" : "It isn't room temp";
            //Console.WriteLine(compareResult);
            //Console.ReadLine();

            Console.WriteLine("Welcome to Package Express, Please follow the instructions below.");
            Console.WriteLine("How much does your package weigh?");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("How wide is your package?");
                int pkgWidth = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("How tall is your package?");
                int pkgHeight = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What is the length of your package?");
                int pkgLength = Convert.ToInt32(Console.ReadLine());

                if (pkgWidth + pkgLength + pkgHeight > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                }
                else
                {
                    int quote = (pkgWeight * (pkgHeight * pkgLength * pkgWidth)) / 100;

                    Console.WriteLine("Your package will cost $" + quote + ".00 to ship.");
                    Console.WriteLine("Thank you!");
                    Console.ReadLine();
                }
            }
        }
    }
}
