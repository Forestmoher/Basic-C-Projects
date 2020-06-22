using System;
using System.Runtime.CompilerServices;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}";
            Console.WriteLine(msg);

            double tscore = 0.0;

            string path = @"C:\Users\fmohe\Documents\GitHub\Basic_C_Sharp_Projects\Scores\Scores\StudentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);

            Console.WriteLine("\nStudent Scores\n");
            foreach (string line in lines)
            {
                Console.WriteLine("\n" + line);
                double score = Convert.ToDouble(line);
                tscore += score;
            }

            double avg = tscore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avg);

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        }
    }
}
