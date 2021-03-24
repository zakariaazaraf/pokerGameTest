using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerGame
{
    class Hand
    {

        Boolean sameSuit(string[,] playerHands, int playerIndex, int cards = 5)
        {
            string suitType = playerHands[playerIndex, 0].Substring(playerHands[playerIndex, 0].IndexOf("of ") + 3);

            for (int i = 1; i < cards; i++)
            {
                if (suitType != playerHands[playerIndex, i].Substring(playerHands[playerIndex, i].IndexOf("of ") + 3))
                {
                    return false;
                }
            }

            return true;
        }

        Boolean cardsInRow(string[,] playerHands, int playerIndex, int cards = 5)
        {
            try
            {

                int[] convertArray = new int[5];
                for (int i = 0; i < cards; i++)
                {   
                    // GET THE FIRST CHARACTER BEFORE " OF" STRING 
                    string StrNumber = playerHands[playerIndex, i].Substring(playerHands[playerIndex, i].IndexOf(" of"), -1);

                    convertArray[i] = int.Parse(StrNumber); // Might Throw Error 
                }

                Array.Sort(convertArray);

                // Check In Row Values
                for(int i=1; i<cards; i++)
                {
                    if(convertArray[i-1] != (convertArray[i] + 1))
                    {
                        return false;
                    }
                }

                return true;

            }
            catch
            {
                return false;
            }
        }


    }
}
