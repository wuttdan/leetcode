using System;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // csharp_style_prefer_range_operator = true
            string sentence1 = "the quick brown fox";
            var sub1 = sentence1[0..^4];
            var sub3 = sentence1[0..3];

            // csharp_style_prefer_range_operator = false
            string sentence2 = "the quick brown fox";
            var sub2 = sentence2.Substring(0, sentence2.Length - 4);
        }
    }
}
