using System;
using System.IO;

namespace Grading_Students
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter tw = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int[] grades = new int[n];

            for (int gradesItr = 0; gradesItr < n; gradesItr++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine());
                grades[gradesItr] = gradesItem;
            }

            int[] result = Solution.gradingStudents(grades);

            tw.WriteLine(string.Join("\n", result));

            tw.Flush();
            tw.Close();
        }
    }
}
