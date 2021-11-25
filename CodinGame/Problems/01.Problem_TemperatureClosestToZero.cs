using CodinGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodinGame.Problems
{
    public class Problem_TemperatureClosestToZero : IRunable
    {
        public void Run()
        {
            var answer1 = Solution("5", "1 -2 -8 4 5");//1
            var answer2 = Solution("3", "-12 -5 -137");//-5
            var answer3 = Solution("6", "42 -5 12 21 5 24");//5
            var answer4 = Solution("6", "42 5 12 21 -5 24");//5
            var answer5 = Solution("10", "-5 -4 -2 12 -40 4 2 18 11 5");//2
            var answer6 = Solution("0", "");//0

            Debug.WriteLine($"answer1: {answer1}");
            Debug.WriteLine($"answer2: {answer2}");
            Debug.WriteLine($"answer3: {answer3}");
            Debug.WriteLine($"answer4: {answer4}");
            Debug.WriteLine($"answer5: {answer5}");
            Debug.WriteLine($"answer6: {answer6}");
        }

        private int Solution(string n, string temperatures)
        {
            if(n == "0" && string.IsNullOrEmpty(temperatures)) return 0;

            var dict = temperatures.Split(' ')
                .Select(x => int.Parse(x))
                .OrderBy(x => x)
                .ToArray();
            var positive = dict.Where(x => x > 0).ToArray();
            var negative = dict.Where(x => x < 0).ToArray();

            if (positive.Length > 0)
            {
                return positive.FirstOrDefault();
            }

            return negative.OrderByDescending(x => x).FirstOrDefault();
        }
    }
}
