using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Deck
    {
        // To Genert Number For Shffling
        Random random = new Random();

        public string[] deck;

        // DECLARE CONSTRACTOR AND DECLARE ARRAY AND CALL FUNCTIONS
        public Deck(){
            deck = new string [52];
            generateCards();
            shuffleDeck();
        }

        // GENERATE CARDS FUNCTION
        void generateCards()
        {
             string [] suits =  { "Hearts", "Diamonds", "Clubs", "Spades" };

             string [] values = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};

            int k = 0;

            for(int i=0; i < suits.Length; i++)
            {
                k = 12 * i;

                for(int j=0; j<values.Length; j++)
                {
                    deck[i + j + k ] = values[j] + " of " + suits[i];
                    
                }
         
            }
        }

        // SHUFFLE THE DECK
        void shuffleDeck()
        {
            for(int i=0; i<deck.Length; i++)
            {
                int randomNuber = random.Next(52);
                string helper = this.deck[randomNuber];
                deck[i] = deck[randomNuber];
                deck[randomNuber] = helper;
            }
        }

        public void printArray()
        {
            foreach(string value in deck)
            {
                Console.WriteLine(value);
            }

            
        }
    }
}
