using LeetcodeApp.Interfaces;
using LeetcodeApp.Problems;
using System;
using System.Linq;

namespace LeetcodeApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //var problem = new Problem_TwoSum() as IRunable;
            var problem = new Problem_SwapNodesInPairs() as IRunable;
            problem.Run();
        }
    }
}
