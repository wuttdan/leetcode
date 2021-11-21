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
            //var prob = new Problem_TwoSum() as IRunable;
            //var prob = new Problem_SwapNodesInPairs() as IRunable;
            //var prob = (IRunable)new Problem_AddTwoNumbers();
            var prob = new Problem_OddEvenLinkedList();
            prob.Run();
        }
    }
}
