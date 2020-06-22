using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
   public class Deck
    {
        public Deck() //constructor
        {
            cards = new List<Card>();
          
            for (int i = 0; i < 13; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Card card = new Card();
                    card.face = (Face)i;// this is another method of casting. the datatype you are casting to is in the ( )
                    card.suit = (Suit)j;
                    cards.Add(card);
                }
            }
        }
        public List<Card> cards { get; set; }

        public void Shuffle(int times = 1)
        {
           
            for (int i = 0; i < times; i++)
            {         
                List<Card> TempList = new List<Card>();//creates a new emtpy list to put our random ordered cards into
                Random random = new Random();//built in List function

                while (cards.Count > 0)
                {
                    int randomIndex = random.Next(0,cards.Count); //takes a random number between 0 and 52
                    TempList.Add(cards[randomIndex]);// adds the card at that index to a new list
                    cards.RemoveAt(randomIndex);//removes the card from the deck.cards list at the random index
                }
                cards = TempList; //adds back in all cards in the tempList to the original list( they will be in new random order
            }
        }
    }
}
