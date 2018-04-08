using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween_Sale
{
    public class Solution
    {
        public static int howManyGames(int openingPrice, int decreaseAmount, int minimumPrice, int walletAmount)
        {
            // Return the number of games you can buy
            var result = 0;

            if (walletAmount >= openingPrice)
            {
                result = 0;
                var remainingAmount = walletAmount;
                var currentPrice = openingPrice;
                while (remainingAmount >= currentPrice)
                {
                    result++;
                    remainingAmount -= currentPrice;

                    if (currentPrice > minimumPrice && currentPrice - decreaseAmount > minimumPrice)
                        currentPrice -= decreaseAmount;
                    else
                        currentPrice = minimumPrice;
                }
            }


            return result;
        }
    }
}
