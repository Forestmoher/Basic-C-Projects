using System;


namespace BooleanLogic
{
    class Program
    {
        static void Main()
        {
            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.ReadLine();

            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.ReadLine();

            //Console.WriteLine(true == false);
            //Console.WriteLine(true == true);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != false);
            //Console.WriteLine(true != true);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);
            //Console.ReadLine();
            Console.WriteLine("Car Insurance Approval Form");
            Console.WriteLine("What is you age?:");
            string ageStr = Console.ReadLine();
            int age = Convert.ToInt32(ageStr);

            Console.WriteLine("Have you ever had a DUI? Please enter true or false:");
            string duiStr = Console.ReadLine();
            bool dui = Convert.ToBoolean(duiStr);

            Console.WriteLine("How many speeding tickets do you have?:");
            string ticketsStr = Console.ReadLine();
            int tickets = Convert.ToInt32(ticketsStr);

            bool canInsure = age > 15 && dui == false && tickets <= 3;

            Console.WriteLine("Are you qualified for insurance?" + canInsure);
            Console.ReadLine();

        }
    }
}
