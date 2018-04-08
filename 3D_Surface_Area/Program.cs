using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Surface_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_H = Console.ReadLine().Split(' ');
            int H = Convert.ToInt32(tokens_H[0]);
            int W = Convert.ToInt32(tokens_H[1]);
            int[][] A = new int[H][];
            for (int A_i = 0; A_i < H; A_i++)
            {
                string[] A_temp = Console.ReadLine().Split(' ');
                A[A_i] = Array.ConvertAll(A_temp, Int32.Parse);
            }
            int result = Solution.surfaceArea(A);
            Console.WriteLine(result);
        }
    }
}
