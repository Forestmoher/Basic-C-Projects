using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace LoopsInC_Sharp
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine("Guess a Number:");
            //int num = Convert.ToInt32(Console.ReadLine());
            //bool isGuessed = num == 12;
            //do
            //{
            //    switch (num)
            //    {
            //        case 62:
            //            Console.WriteLine("You guessed 62, try again.");
            //            Console.WriteLine("Guess a Number:");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 29:
            //            Console.WriteLine("You guessed 29, try agin.");
            //            Console.WriteLine("Guess a Number:");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 55:
            //            Console.WriteLine("You guessed 55, try again");
            //            Console.WriteLine("Guess a Number:");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;
            //        case 12:
            //            Console.WriteLine("You guessed 12, That is Correct!");
            //            isGuessed = true;
            //            break;
            //        default:
            //            Console.WriteLine("You are wrong!");
            //            Console.WriteLine("Guess a Number:");
            //            num = Convert.ToInt32(Console.ReadLine());
            //            break;

            //    }
            //}

            //while (!isGuessed);




            //Console.ReadLine();


            //////While loop///////
            Console.WriteLine("What is the greatest Christmas movie of all time?");
            string movie = Console.ReadLine();
            bool rightAnswer = false;

            while(!rightAnswer)
            {
                switch(movie)
                {
                    case "die hard":
                        Console.WriteLine("That is Correct!");
                        rightAnswer = true;
                        break;
                    default:
                        Console.WriteLine("You guessed " + movie + ". That is incorrect!");
                        Console.WriteLine("What is the greatest Christmas movie of all time?");
                        movie = Console.ReadLine();
                        break;
                }
            }

            Console.ReadLine();
            

            //////Do while loop//////
            Console.WriteLine("What Year did Die Hard come out?");
            string year = Console.ReadLine();
            bool rightYear = false;

            do
            {
                switch (year)
                {
                    case "1988":
                        Console.WriteLine("Wow that is Correct! Great Job.");
                        rightYear = true;
                        break;
                    case "1987":
                        Console.WriteLine("Oh No! So close!");
                        Console.WriteLine("What Year did Die Hard come out?");
                        year = Console.ReadLine();
                        break;
                    case "1989":
                        Console.WriteLine("Oh No! So close!");
                        Console.WriteLine("What Year did Die Hard come out?");
                        year = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Nope! Try again.");
                        Console.WriteLine("What Year did Die Hard come out?");
                        year = Console.ReadLine();
                        break;

                }
            }

            while (!rightYear);

            Console.ReadLine();
         
        }
    }
}
