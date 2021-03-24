using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            Card card = new Card();
            Hand hand = new Hand();

            int hands = 4;
            int cards = 5;
            
            card.destibuteCardsOnHands(deck.deck, hands, cards);


            /*for(int i=0; i<4; i++)
            {
                Console.WriteLine("Player " + (i + 1));
                Console.WriteLine("\n");
                for(int j=0; j<5; j++)
                {
                    Console.WriteLine(card.PlayersHands[i, j]);
                }
                Console.WriteLine("\n");
            }*/
            

            Console.ReadKey();
             
        }
    }
}
