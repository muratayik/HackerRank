using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    public class Solution
    {
        public static string Kangaroo(int locationOfFirstKangaroo, int speedOfFirstKangaroo, int locationOfSecondKangaroo, int speedOfSecondKangaroo)
        {
            var result = "NO";

            //If first kangaroo is not faster than second, answer is definitely NO
            if (speedOfFirstKangaroo > speedOfSecondKangaroo)
            {
                var differenceBetweenLocations = locationOfSecondKangaroo - locationOfFirstKangaroo;
                var differenceBetweenSpeeds = speedOfSecondKangaroo - speedOfFirstKangaroo;
                //If difference of locations is divisible by difference of speeds than answer is YES
                if (differenceBetweenLocations % differenceBetweenSpeeds == 0)
                    result = "YES";
            }

            return result;
        }
    }
}
