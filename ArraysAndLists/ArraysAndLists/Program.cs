using System;
using System.Collections.Generic;



class Program
{
    static void Main()
    {

        //List<int> intList = new List<int>(); //creates a list of integers
        //intList.Add(4);
        //intList.Add(10);
        //intList.Remove(10);
        //Console.WriteLine(intList[0]);
        //Console.ReadLine();

        //int[] numArray = new int[5]; //five being the length of the array
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 500;
        //numArray[4] = 2000;

        //int[] numArray1 = new int[] { 5, 2, 10, 500, 2000 }; // does the same as above

        //int[] numArray2 = { 5, 2, 10, 200, 5000 };// does the same as above

        //numArray2[4] = 650;

        //Console.WriteLine(numArray2[4]);
        //Console.ReadLine();


        //**********One dimensional array of strings**********//
        //string[] strArray = { "Forest", "Abii", "Taylor", "Keely", "Sasha", "Tom", "Natty" };

        //Console.WriteLine("Pick a number:");
        //int num = Convert.ToInt32(Console.ReadLine());
        //while (num > 6 || num < 0)
        //{
        //    Console.WriteLine("Please pick a number between 0 and 6");
        //    num = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine("You picked: " + num + ", with an array value of: " + strArray[num]);
        //Console.ReadLine();

        ////**********One dimensional array of integers**********//
        //int[] intArray = { 5, 10, 15, 33, 53, 1234, 4231, 234643, };

        //Console.WriteLine("Pick another number:");
        //int num2 = Convert.ToInt32(Console.ReadLine());
        //while (num2 > 7 || num2 < 0)
        //{
        //    Console.WriteLine("Please pick a number between 0 and 7");
        //    num2 = Convert.ToInt32(Console.ReadLine());
        //}
        //Console.WriteLine("You picked: " + num2 + ", with an array value of: " + intArray[num2]);
        //Console.ReadLine();

        //**********List of strings**********//

        List<string> strList = new List<string>();

        strList.Add("Samus");
        strList.Add("Link");
        strList.Add("Mario");
        strList.Add("Kirby");
        strList.Add("Marth");

        Console.WriteLine("Player One: Select a number between 0 and 4 to pick your character:");
        int character = Convert.ToInt32(Console.ReadLine());
     
        while (character > 4 || character < 0) 
        {
            Console.WriteLine("Please pick a number between 0 and 4");
            character = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Player Two: Select a number between 0 and 4 to pick your character:");
        int character2 = Convert.ToInt32(Console.ReadLine());

        while (character2 > 4 || character2 < 0 || character2 == character)
        {
            if (character2 == character)
            {
                Console.WriteLine("You may not pick the same character, Please Pick again:");
                character2 = Convert.ToInt32(Console.ReadLine());
                
            }
            if (character2 > 4 || character2 < 0)
            {
                Console.WriteLine("Please pick a number between 0 and 4");
                character2 = Convert.ToInt32(Console.ReadLine());
            }
            
        }

      

        Console.WriteLine("Player one chose " + strList[character] + "!");
        Console.WriteLine("Player two chose " + strList[character2] + "!.....\n FIGHT!");
        Console.ReadLine();
    }
}
