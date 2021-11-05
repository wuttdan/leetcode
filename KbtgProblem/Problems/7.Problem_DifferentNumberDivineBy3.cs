using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace KbtgProblem.Problems
{
    public class Problem_DifferentNumberDivineBy3 : IRunable
    {
        public void Run()
        {
            var answer1 = Solution("23");
            var answer2 = Solution("0081");
            var answer3 = Solution("022");

            Console.WriteLine($"answer1: {answer1}");
            Console.WriteLine($"answer2: {answer2}");
            Console.WriteLine($"answer3: {answer3}");
        }

        private int Solution(string S)
        {
            List<string> results = new List<string>();
            char[] quiz = S.ToCharArray();
            //for (int i = 0; i < S.Length; i++)
            for (int i = S.Length - 1; i >= 0; i--)
            {
                for (int j = 0; j < 10; j++)
                {
                    quiz[i] = j.ToString().ToCharArray()[0];
                    string temp = new string(quiz);
                    int buffer = int.Parse(temp);
                    if (buffer % 3 == 0)
                    {
                        results.Add(temp);
                    }
                }
                quiz = S.ToCharArray();
            }
            if (results.Count > 0)
            {
                var answer = results.OrderBy(x => int.TryParse(x, out int num) ? num : int.MaxValue).Distinct();
                Debug.WriteLine($"[{string.Join(",", answer.ToArray())}]");
                return answer.Count();
            }
            return 0;
        }
    }
}



