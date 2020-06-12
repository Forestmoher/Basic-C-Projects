using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics.CodeAnalysis;

namespace StreamWriterAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            string num = Console.ReadLine();
            using (StreamWriter file = new StreamWriter(@"C:\Users\fmohe\Logs\file.txt", true))
            {
                file.WriteLine(num);
            }
            using (StreamReader read = new StreamReader(@"C:\Users\fmohe\Logs\file.txt"))
            {
                string text = read.ReadToEnd();
                Console.WriteLine(text);
            }
            Console.ReadLine();
        }        
    }
}
