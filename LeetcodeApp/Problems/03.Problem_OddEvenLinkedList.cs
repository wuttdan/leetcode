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
    public class Problem_OddEvenLinkedList: IRunable
    {
        public void Run()
        {
            //var answer1 = OddEvenList(ListNode.Create(1, 2, 3, 4, 5));
            var answer2 = OddEvenList(ListNode.Create(2, 1, 3, 5, 6, 4, 7));

            //Debug.WriteLine($"{answer1.ToString()}");
            Debug.WriteLine($"{answer2.ToString()}");

        }

        public ListNode OddEvenList(ListNode head)
        {
            if (head == null) return null;
            ListNode odd = head, even = head.next, evenHead = even;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }
    }


}
