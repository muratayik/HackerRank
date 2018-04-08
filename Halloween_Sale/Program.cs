using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Halloween_Sale
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_p = Console.ReadLine().Split(' ');
            int p = Convert.ToInt32(tokens_p[0]);
            int d = Convert.ToInt32(tokens_p[1]);
            int m = Convert.ToInt32(tokens_p[2]);
            int s = Convert.ToInt32(tokens_p[3]);
            int answer = Solution.howManyGames(p, d, m, s);
            Console.WriteLine(answer);
        }
    }
}
