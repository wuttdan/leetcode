using KbtgProblem.Extensions;
using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbtgProblem.Problems
{
    public class Problem_BinaryGap : IRunable
    {
        //https://app.codility.com/programmers/lessons/1-iterations/binary_gap/
        public void Run()
        {
            var q = new List<int>
            {
                //1041,
                //32,,
                110,
                328,
                51712,
                20
            };
            foreach(int i in q)
            {
                Debug.WriteLine($"answer {q.IndexOf(i)}: {Solution(i)}");
            }
        }

        public int Solution(int N)
        {
            string binary = Convert.ToString(N, 2);
            Debug.Write($"{N}-{binary}");
            string[] temps = binary.Split('1');
            if (temps.Count() >= 3)
            {
                var result = temps.Where(x => !x.Contains("1")).OrderByDescending(x => x.Length).FirstOrDefault();
                return result.Length;
            }
            return 0;
        }
    }

}
