using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Forest";
            //string quote = "The man said, 'Hello there'.";
            //string quoteTwo = "The man said, \"Hello\". \n Hello on a new line \t hello on a tab";
            //string backslash = "Here is a backslash \\";
            //string fileName = @"C:\users\fmoher";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();

            //Console.WriteLine(length);
            //Console.Read();

            //StringBuilder sb = new StringBuilder();

            //sb.Append("My name is Forest");


            ////////Cloncatenate 3 Strings:
            string name = "Forest";
            string job = "Software developer";
            int age = 27;

            string concatString = "Hello, my name is " + name + ", I am " + age.ToString() + " and I am a " + job + ".";

            Console.Write(concatString);
            Console.ReadLine();

            //////////Convert String to UpperCase
            job = job.ToUpper();

            Console.WriteLine(job);
            Console.ReadLine();

            //////////StringBuilder

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("There once was a man from Nantucket");
            paragraph.Append("\n Who kept all his cash in a bucket");
            paragraph.Append("\n But his daughter, named Nan,");
            paragraph.Append("\n Ran away with a man");
            paragraph.Append("\n And as for his bucket, Nantucket.");

            Console.WriteLine(paragraph);
            Console.ReadLine();






        }
    }
}
