using System;


namespace MathAndComparisonOperators
{
    class Program
    {
        static void Main()
        {
            //int total = 5 + 10;
            //int otherTotal = 12 + 22;
            //int combined = total + otherTotal;
            //Console.WriteLine("Five plus ten equals: " + total.ToString());
            //Console.ReadLine();

            //int difference = 10 - 5;
            //Console.WriteLine("Ten minus five equals: " + difference.ToString());

            //int product = 10 * 5;
            //Console.WriteLine("Ten times five equals: " + product.ToString());

            //int quotient = 100 / 5;
            //Console.WriteLine("One hundred divided by five equals: " + quotient.ToString());
            //Console.ReadLine();

            //int remainder = 10 % 2;
            //Console.WriteLine(remainder);
            //Console.ReadLine();

            //bool trueOrFalse = 12 > 5;
            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            //int roomTemp = 70;
            //int currentTemp = 72;

            //bool isWarm = currentTemp >= roomTemp;
            //bool isWarm = currentTemp == roomTemp;
            //Console.WriteLine(isWarm);
            //Console.ReadLine();

            Console.WriteLine("Please enter a number:");           
            int numOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numOne + " times 50 equals: " + numOne * 50);
            Console.ReadLine();

            Console.WriteLine("Please enter another number:");
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int sum = numTwo + 25;

            Console.WriteLine(numTwo + " plus 25 equals: " + sum);
            Console.ReadLine();

            Console.WriteLine("Please enter another number:");
            int numThree = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(numThree + " divided by 12.5 equals: " + numThree / 12.5);
            Console.ReadLine();

            Console.WriteLine("Please enter another number:");
            int numFour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Is " + numFour + " greater than 50?: " + (numFour > 50));
            Console.ReadLine();

            Console.WriteLine("Please enter another number:");
            int numFive = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The remainder of " + numFive + " divided by 7 is: " + numFive % 7);
            Console.ReadLine();
        }
    }
}
