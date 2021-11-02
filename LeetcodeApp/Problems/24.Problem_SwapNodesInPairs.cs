using LeetcodeApp.Commons;
using LeetcodeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Problems
{
    public class Problem_SwapNodesInPairs: IRunable
    {
        public void Run()
        {
            //Input: head = [1, 2, 3, 4]
            //Output:[2,1,4,3]
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
            var result = SwapPairs(head);
        }

        public ListNode SwapPairs(ListNode head)
        {
            return null;
        }
    }
}
