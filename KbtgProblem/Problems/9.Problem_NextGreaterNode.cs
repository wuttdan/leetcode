using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace KbtgProblem.Problems
{
    public class Problem_NextGreaterNode : IRunable
    {
        public void Run()
        {
            var q1 = ListNode.Create(2, 1, 5 );
            var answer1 = Solution(q1);

            var q2 = ListNode.Create(2, 7, 4, 3, 5);
            var answer2 = Solution(q2);

            Console.WriteLine($"answer1: [{string.Join(",", answer1.ToArray())}]");
            Console.WriteLine($"answer2: [{string.Join(",", answer2.ToArray())}]");
        }

        private int[] Solution(ListNode head)
        {
            var result = new List<int>();

            ListNode node = head, child = null;
            int childValue = 0;

            while (node != null)
            {
                child = node.next;
                childValue = 0;
                while (child != null)
                {
                    if (child.val > node.val)
                    {
                        childValue = child.val;
                        child = null;
                    }
                    else
                    {
                        child = child.next;
                    }
                }
                result.Add(childValue == 0 ? 0 : childValue);
                node = node.next;
            }

            return result.ToArray();
        }
    }
}



