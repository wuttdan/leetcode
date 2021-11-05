using KbtgProblem.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace KbtgProblem.Problems
{
    public class Problem_SwappingNode : IRunable
    {
        public void Run()
        {
            var q1 = ListNode.Create(1, 2, 3, 4, 5 );
            var answer1 = Solution(q1, 2);

            var q2 = ListNode.Create(7, 9, 6, 6, 7, 8, 3, 0, 9, 5);
            var answer2 = Solution(q2, 5);
            
            var q3 = ListNode.Create(1, 2);
            var answer3 = Solution(q3, 1);
            
            var q4 = ListNode.Create(1, 2, 3);
            var answer4 = Solution(q4, 2);

            Console.WriteLine($"answer1: {string.Join(",", answer1.ToString())}");
            Console.WriteLine($"answer2: {string.Join(",", answer2.ToString())}");
            Console.WriteLine($"answer3: {string.Join(",", answer3.ToString())}");
            Console.WriteLine($"answer4: {string.Join(",", answer4.ToString())}");
        }

        private ListNode Solution(ListNode head, int k)
        {
            if (head.next == null)
            {
                return head;
            }

            var nodeList = new List<ListNode>();
            //forward
            var node = head;
            while (node != null)
            {
                nodeList.Add(node);
                node = node.next;
            }

            int a = nodeList[k - 1].val;
            nodeList[k - 1].val = nodeList[nodeList.Count - k].val;
            nodeList[nodeList.Count - k].val = a;
            return head;
        }
    }
}



