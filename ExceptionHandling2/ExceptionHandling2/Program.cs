using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ExceptionHandling2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validAnswer = false;
            do
            {
                try
                {
                    Console.WriteLine("How old are you?");
                    int age = Convert.ToInt32(Console.ReadLine());
                    if (age <= 0)
                    {
                        throw new AgeException();
                    }
                    Console.WriteLine("You were born in " + (2020 - age));
                    validAnswer = true;
                 
                }
                catch (AgeException)
                {
                    Console.WriteLine("You cannot be less than 1 years old");
                    Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Please enter only whole numbers using digits");
                    Console.ReadLine();
                }
            }
            while (!validAnswer);
            Console.ReadLine();









            //bool validAnswer = false;
            //int age = 0;
            //while (!validAnswer)
            //{
            //    Console.WriteLine("Hello, how old are you?");
            //    validAnswer = int.TryParse(Console.ReadLine(), out age);
            //    if (!validAnswer)
            //    {
            //        Console.WriteLine("Please enter only digits");
            //    } 
            //}
            //Console.WriteLine("You were born in " + (2020 - age));
            //Console.ReadLine();

        }
    }
}
