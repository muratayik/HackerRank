using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3D_Surface_Area
{
    public class Solution
    {
        public static int surfaceArea(int[][] A)
        {
            var result = 0;
            var height = A.Length;
            var width = A[0].Length;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0)
                        result += A[i][j];
                    else if (A[i][j] > A[i][j - 1])
                        result += A[i][j] - A[i][j - 1];
                }

                for (int j = width - 1; j >= 0; j--)
                {
                    if (j == width - 1)
                        result += A[i][j];
                    else if (A[i][j] > A[i][j + 1])
                        result += A[i][j] - A[i][j + 1];
                }
            }

            for (int j = 0; j < width; j++)
            {
                for (int i = 0; i < height; i++)
                {
                    if (i == 0)
                        result += A[i][j];
                    else if (A[i][j] > A[i - 1][j])
                        result += A[i][j] - A[i - 1][j];
                }

                for (int i = height - 1; i >= 0; i--)
                {
                    if (i == height - 1)
                        result += A[i][j];
                    else if (A[i][j] > A[i + 1][j])
                        result += A[i][j] - A[i + 1][j];
                }
            }

            result += (height * width * 2);

            return result;
        }
    }
}
