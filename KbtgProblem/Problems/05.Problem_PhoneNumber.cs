using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KbtgProblem.Problems
{
    public class Problem_PhoneNumber : IRunable
    {
        public void Run()
        {
            var a1 = new[] { "pim", "pom"};
            var b1 = new[] { "999999999", "777888999" };
            var answer1 = Solution(a1, b1, "88999");//pom

            var a2 = new[] { "sander", "amy", "ann", "michael" };
            var b2 = new[] { "123456789", "234567890", "789123456", "123123123" };
            var answer2 = Solution(a2, b2, "1");//ann

            var a3 = new[] { "adam", "eva", "leo" };
            var b3 = new[] { "121212121", "111111111", "444555666"};
            var answer3 = Solution(a3, b3, "112");//NO CONTACT

            Console.WriteLine($"answer1: {answer1}");
            Console.WriteLine($"answer2: {answer2}");
            Console.WriteLine($"answer3: {answer3}");
        }

        private string Solution(string[] A, string[] B, string P)
        {
            string result = "NO CONTACT";

            var phones = B.Where(x => x.Contains(P))
                        .Select(x => {
                            var index = Array.IndexOf(B, x);
                            return A[index];
                        })
                        .OrderBy(x => x.Length)
                        .ToList();

            if (phones != null && phones.Count() > 0)
            {
                return phones.FirstOrDefault();
            }

            return result;
        }
    }
}



