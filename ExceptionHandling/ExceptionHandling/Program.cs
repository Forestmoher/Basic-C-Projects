using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //try
        //{
        //    Console.WriteLine("Enter a number");
        //    int number1 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Enter a second number");
        //    int number2 = Convert.ToInt32(Console.ReadLine());
        //    Console.WriteLine("Dividing the two...");
        //    int number3 = number1 / number2;
        //    Console.WriteLine(number1 + " divided by " + number2 + " equals " + number3);
        //    Console.ReadLine();
        //}
        //catch(FormatException ex)
        //{
        //    Console.WriteLine("Please type a whole number");
        //}
        //catch(DivideByZeroException ex)
        //{
        //    Console.WriteLine("Please don't divide by zero");
        //}
        //catch(Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //    Console.ReadLine(); 
        //}


        try
        {
            List<int> numbers = new List<int> { 12, 22, 45, 65, 82, 100 };
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine("_____________\nEnter a number to divide the list of numbers by:");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing......");
            foreach (int number in numbers)
            {
                int answer = number / dividend;
                Console.WriteLine(answer);
            }
        }
        catch (FormatException ex)
        {
            Console.WriteLine("Please type a whole number");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("Can not divide by zero");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Program has exited 'Try Catch' block");
      

        Console.ReadLine();
    
    }
}

