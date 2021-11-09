using KbtgProblem.Extensions;
using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbtgProblem.Problems
{
    public class Problem_SmallestInterger : IRunable
    {
        public void Run()
        {
            int[] q1 = new int[] { 1, 3, 6, 4, 1, 2 };
            int answer1 = Solution(q1);

            int[] q2 = new int[] { 1, 2, 3 };
            int answer2 = Solution(q2);

            int[] q3 = new int[] { -1, -3 };
            int answer3 = Solution(q3);

            Console.WriteLine($"answer1: {answer1}");
            Console.WriteLine($"answer2: {answer2}");
            Console.WriteLine($"answer2: {answer3}");
        }

        private int Solution(int[] A)
        {
            if (A.All(x => x < 0)) return 1;
            var range = Enumerable.Range(1, 9).ToArray();
            var answ = range.Except(A).Union(A.Except(range)).ToArray();
            return answ.FirstOrDefault();
        }
        //private int Solution(int[] A)
        //{
        //    if (A.All(x => x < 0)) return 1;
        //    var range = Enumerable.Range(1, 9).ToArray();
        //    var difference = new HashSet<int>(A);
        //    difference.SymmetricExceptWith(range);
        //    return difference.FirstOrDefault(x => x > 0);
        //}
    }
}
