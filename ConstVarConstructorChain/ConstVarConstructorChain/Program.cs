using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConstVarConstructorChain
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is a karaoke business that required song credits to perform songs
            // a new customer object is created and initialized with 1 song credit

            const string title = "Twin Dragon Karaoke";
            Console.WriteLine("Welcome to {0}! \n Please enter your name:", title);
            Customer singerOne = new Customer(Console.ReadLine());
            Console.WriteLine("Hello {0}, you have a beginning song credit balance of {1}\n\n", singerOne.Name, singerOne.songCredits);
            Console.WriteLine("Please pick the number of the song you would like to perform:");

            //this will display availible songs and direct user to pick a number 
            var songDictionary = new Dictionary<int, string>()
            {
                { 1 , "Hit the Road Jack" },
                { 2, "Bohemian Rapsody"},
                { 3, "Wrecking Ball" },
                { 4, "Still Rock and Roll to ME"}
            };

            foreach (KeyValuePair<int, string> song in songDictionary)
            {
                Console.WriteLine(song.Key + "...." + song.Value);
            }

            // song is chosen and credit is deducted from customer song credits
            int songChoice = Convert.ToInt32(Console.ReadLine());
            singerOne.songCredits--;
            Console.WriteLine("You chose {0}, your remaining balance is: {1}", songDictionary[key: songChoice], singerOne.songCredits);

            Console.ReadLine();
        }
    }
}
