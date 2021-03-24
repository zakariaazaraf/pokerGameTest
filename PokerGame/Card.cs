using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Card
    {
        public string[,] PlayersHands;

        public void destibuteCardsOnHands(string[] deck, int hands, int cards)
        {
            PlayersHands = new string [hands, cards];

            int currentDeck = 0;
            for(int i=0; i<hands; i++)
            {
                for(int j=0; j<cards; j++)
                {
                    PlayersHands[i, j] = deck[currentDeck];
                    currentDeck++;
                }
            }
        }
    }
}
