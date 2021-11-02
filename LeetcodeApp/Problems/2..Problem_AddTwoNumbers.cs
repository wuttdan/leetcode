using LeetcodeApp.Commons;
using LeetcodeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Problems
{
    public class Problem_AddTwoNumbers: IRunable
    {
        public void Run()
        {
            //Input: l1 = [2, 4, 3], l2 = [5, 6, 4]
            //Output:[7,0,8]
            //Explanation: 342 + 465 = 807.
            var l1 = ListNode.Create(2, 4, 3);
            var l2 = ListNode.Create(5, 6, 4);
            Debug.WriteLine($"{l1.ToString()}");
            Debug.WriteLine($"{l2.ToString()}");
        }

        public ListNode SwapPairs(ListNode head)
        {
            return null;
        }
    }


}
