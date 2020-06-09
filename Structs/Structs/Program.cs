using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Number Number = new Number();
            Number.Amount = 3.14m;
            Console.WriteLine(Number.Amount);
            Console.ReadLine();
        }
    }
}
