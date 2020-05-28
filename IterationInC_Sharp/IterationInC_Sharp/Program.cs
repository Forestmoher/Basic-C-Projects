using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;

class Program
{
    static void Main(string[] args)
    {
        //    int[] testScores = { 98, 99, 96, 74, 82, 43, 75, 100 };

        //    for (int i = 0; i < testScores.Length; i++)
        //    {
        //        if (testScores[i] > 85)
        //        {
        //            Console.WriteLine("Passing test score: " + testScores[i]);
        //        }
        //    }

        //    Console.ReadLine();

        //string[] names = { "forest", "james", "kyla", "sage" };

        //for (int j = 0; j < names.Length; j++)
        //{
        //    if (names[j] == "forest")
        //    {
        //        Console.WriteLine(names[j]);
        //    }
        //}

        //Console.ReadLine();

        //List<int> testScores = new List<int>();

        //testScores.Add(98);
        //testScores.Add(60);
        //testScores.Add(40);
        //testScores.Add(93);
        //testScores.Add(85);

        //foreach (int score in testScores)
        //{
        //    if (score >= 85)
        //    {
        //        Console.WriteLine("Passing scores: " + score);
        //    }
        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "forest", "abii", "jesse", "bob" };

        //foreach (string name in names)
        //{
        //    if (name == "forest")
        //    {
        //        Console.WriteLine(name);
        //    }
        //}
        //Console.ReadLine();

        //List<int> testScores = new List<int>() { 98, 88, 76, 54, 99, 100 };
        //List<int> passingScores = new List<int>();

        //foreach (int score in testScores)
        //{
        //    if (score >= 85)
        //    {
        //        passingScores.Add(score);
        //    }
        //}

        //Console.WriteLine(passingScores.Count);
        //Console.ReadLine();



        //*********Array of strings*********//
        string[] things = { "bear", "beet", "star", "paper" };
        for (int i = 0; i < things.Length; i++)
        {
            Console.WriteLine(things[i]);
        }
        Console.WriteLine("Type an 's' to make these items plural");
        string S = Console.ReadLine();
        for (int i = 0; i < things.Length; i++)
        {
            things[i] += S;
            Console.WriteLine(things[i]);
        }
        Console.ReadLine();

        //*********Infinite Loop*********//
        //for (int i = 0; i < things.Length;)
        //{
        //    Console.WriteLine("infinite Loop");
        //}

        for (int i = 0; i < things.Length; i++)
        {
            Console.WriteLine("No infinite loop here");
        }

        //*********Loop With <= operator**********//
        for (int i = 0; i <= 6; i++)
        {
            Console.WriteLine(i + 1);
        }
        Console.ReadLine();

        //**********List of Strings as Movies**********//
        Console.WriteLine("Stephen King Movies: \n___________________");
        List<string> movies = new List<string>() { "It", "Shawshank Redemption", "The Shinning", "Misery", "Cujo" };
        foreach (string movie in movies)
        {
            Console.WriteLine(movie);
        }

        //user will select one of the above movies and an index will be returned if movie exists in list.
        Console.WriteLine("___________________ \nWhich of these Movies is your favorite?");
        string answer = Console.ReadLine();

        foreach (string movie in movies)
        {
            if (movies.Contains(answer))
            {
                int index = movies.IndexOf(answer);
                Console.WriteLine("That movie has an index of " + index);
                break;
            }
            else
            {
                Console.WriteLine("That movie is not on the list. Please enter a movie from the above list:");
                answer = Console.ReadLine();
            }
        }

        //**********List of Strings as Names**********//
        List<string> names = new List<string>() { "Forest", "Tony", "Billy", "Billy", "Sarah" };

        //user will select a name to see the index/indices
        Console.WriteLine("Type one of the following Names to see the index value: Forest, Tony, Billy, or Sarah.");
        string answer2 = Console.ReadLine();

        //this will check if name is in the list then display the index(s)
        for (int i = 0; i < names.Count; i++)
        {
            if (names.Contains(answer2))
            {
                break;
            }
            else
            {
                Console.WriteLine("That name is not on the list, please try again:");
                answer2 = Console.ReadLine();
            }
        }
        for (int i = 0; i < names.Count; i++)
        {
            if (names[i] == answer2)
            {
                Console.WriteLine("That name is at index: " + i);
            }

        }
        Console.ReadLine();

        //**********List of Strings as Ingredients**********//
        List<string> ingredients = new List<string>() { "eggs", "flour", "milk", "milk", "baking soda", "sugar" };
        List<string> dupItems = new List<string>();
        Console.WriteLine("List of Cake ingredients");
        //this will iterate through the list and push items to a new list where will evaluate if the item already exists
        foreach (string item in ingredients)
        {
            if (dupItems.Contains(item))
            {
                Console.WriteLine("(duplicate): " + item);
                
            }
            else
            {
                dupItems.Add(item);
                Console.WriteLine(item);
            }
        }
       
        
        Console.ReadLine();
    }
}

