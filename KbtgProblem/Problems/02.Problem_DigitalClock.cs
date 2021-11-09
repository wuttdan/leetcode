using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace KbtgProblem.Problems
{
    public class Problem_DigitalClock : IRunable
    {
        public void Run()
        {
            var answer1 = Solution("22:22:21", "22:22:23");//3
            var answer2 = Solution("15:15:00", "15:15:12");//1
            var answer3 = Solution("00:00:00", "23:59:59");//1

            Console.WriteLine($"answer1: {answer1}");
            Console.WriteLine($"answer2: {answer2}");
            Console.WriteLine($"answer3: {answer3}");
        }

        private int Solution(string S, string T)
        {
            int result = -1;
            try
            {
                TimeSpan start = TimeSpan.Parse(S);
                TimeSpan ended = TimeSpan.Parse(T);

                if (start >= ended)
                    throw new InvalidOperationException($"The start '{S}' should less than the ended '{T}'.");

                result = 0;
                while (start <= ended)
                {
                    var time = start.ToString(@"hh\:mm\:ss");
                    //Console.WriteLine(time);

                    var temp = time.Replace(":", string.Empty).ToCharArray();
                    var count = temp.Distinct().Count();

                    if (count > 0 && count < 3)
                    {
                        var heystack = temp.Distinct();
                        var timeFind = start.ToString(@"hh\:mm\:ss").Split(':').Where(x => x != ":");
                        if (IsContain(heystack, timeFind))
                        {
                            result += 1;
                        }
                    }
                    start = start.Add(TimeSpan.FromSeconds(1));
                }
                return result;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool IsContain(IEnumerable<char> heystack, IEnumerable<string> times)
        {
            //Console.WriteLine($"{string.Join("|", heystack)} ==> {string.Join("|", times)}");
            foreach (var hey in heystack)
            {
                foreach (var time in times)
                {
                    if (time.Contains(hey.ToString()))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        //private int Solution(string S, string T)
        //{
        //    int result = -1;
        //    try
        //    {
        //        TimeSpan start = TimeSpan.Parse(S);
        //        TimeSpan ended = TimeSpan.Parse(T);
        //
        //        if (start >= ended)
        //            throw new InvalidOperationException($"The start '{S}' should less than the ended '{T}'.");
        //
        //        result = 0;
        //        while (start <= ended)
        //        {
        //            var time = start.ToString(@"hh\:mm\:ss");
        //            Console.WriteLine(time);
        //
        //            var temp = time.Replace(":", string.Empty).ToCharArray();
        //            var count = temp.Distinct().Count();
        //
        //            if (count > 0 && count < 3)
        //                result += 1;
        //
        //            start = start.Add(TimeSpan.FromSeconds(1));
        //        }
        //        return result;
        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}
    }
}
