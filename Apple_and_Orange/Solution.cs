using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_and_Orange
{
    public class Solution
    {
        public static string CountApplesAndOranges(int leftSideOfHouse, int rightSideOfHouse, int larrysPoisition, int bobsPosition, int[] apples, int[] oranges)
        {
            var LarrysScore = 0;
            var BobsScore = 0;

            foreach (int appleDistance in apples)
                if ((larrysPoisition + appleDistance) >= leftSideOfHouse)
                    if ((larrysPoisition + appleDistance) <= rightSideOfHouse)
                        LarrysScore++;

            foreach (int orangeDistance in oranges)
                if ((bobsPosition + orangeDistance) >= leftSideOfHouse)
                    if ((bobsPosition + orangeDistance) <= rightSideOfHouse)
                        BobsScore++;


            return LarrysScore + " " + BobsScore;
        }
    }
}
