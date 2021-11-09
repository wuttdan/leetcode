using KbtgProblem.Interfaces;
using System;
using System.Linq;

namespace KbtgProblem.Problems
{
    public class Problem_ArmyReport : IRunable
    {
        public void Run()
        {
            var answer1 = Solution(3, 4, 3, 0, 2, 2, 3, 0, 0);
            var answer2 = Solution(4, 2, 0);
            var answer3 = Solution(4, 4, 3, 3, 1, 0);

            Console.WriteLine($"answer1: {answer1}");
            Console.WriteLine($"answer2: {answer2}");
            Console.WriteLine($"answer3: {answer3}");
        }

        private int Solution(params int[] args)
        {
            int result = 0;
            foreach (var num in args.Distinct())
            {
                var items = args.Where(x => x == (num + 1));
                if (items.Any())
                {
                    result += args.Where(x => x == num).Count();
                }
            }
            return result;
        }
    }
}
