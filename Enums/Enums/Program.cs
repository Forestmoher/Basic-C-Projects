using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Program
    {
        public enum DaysOfTheWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }

        static void Main(string[] args)
        {
            bool correctDay = false;
            do //this loop will check input of user and loop until proper answer is input
            {
                try
                {   //user will enter in a day of the week
                    Console.WriteLine("What day is it today?");
                    string answer = Console.ReadLine();

                    //this will parse the string to see if it matches any value in the enum 
                    DaysOfTheWeek enumAnswer = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), answer);

                    //if it matches, this code will execute and program will end
                    if (Enum.IsDefined(typeof(DaysOfTheWeek), enumAnswer))
                    {
                        Console.WriteLine("Today is {0}", enumAnswer);
                        correctDay = true;
                    }
                    
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Pleases enter a valid day of the week");
                    correctDay = false;
                }
                finally
                {
                    Console.WriteLine("Thank you!");
                }
            }
            while (correctDay == false);
            
            Console.ReadLine();

           
        }
    }
    
}
