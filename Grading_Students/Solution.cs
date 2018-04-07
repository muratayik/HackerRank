using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading_Students
{
    public class Solution
    {
        public static int[] gradingStudents(int[] grades)
        {
            int[] result = new int[grades.Length];
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] < 38)
                    result[i] = grades[i];
                else if (grades[i] % 5 > 2)
                    result[i] = ((grades[i] / 5) + 1) * 5;
                else
                    result[i] = grades[i];
            }
            return result;

        }
    }
}
