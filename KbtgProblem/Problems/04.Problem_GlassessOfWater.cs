using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace KbtgProblem.Problems
{
    public class Problem_GlassessOfWater : IRunable
    {
        public void Run()
        {
            var answer1 = Solution(5, 8); //2
            var answer2 = Solution(4, 10); //4
            var answer3 = Solution(1, 2); // -1
            var answer4 = Solution(10, 5); //1


            Console.WriteLine($"answer1: {answer1}{Environment.NewLine}");
            Console.WriteLine($"answer2: {answer2}{Environment.NewLine}");
            Console.WriteLine($"answer3: {answer3}{Environment.NewLine}");
            Console.WriteLine($"answer4: {answer4}{Environment.NewLine}");
        }

        private int Solution(int N, int K)
        {
            //Debug.WriteLine($"{N}/{K}");
            int result = 0;
            int nn = N <= K ? N : K;
            int kk = K;//
            for (int i = 0; nn > 0; nn--)
            {
                if (nn <= kk)
                {
                    kk = kk - nn;
                    //Debug.WriteLine($"{nn}/{kk}");
                    result += 1;
                }
                if (kk <= 0) break;
            }
            if (kk > 0) result = -kk;
            //Debug.WriteLine(Environment.NewLine+ Environment.NewLine);
            return result;
        }
    }
}
