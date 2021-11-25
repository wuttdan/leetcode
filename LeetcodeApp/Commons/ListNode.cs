using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Commons
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public IEnumerable<int> GetValues()
        {
            List<int> list = new List<int>();
            ListNode temp = this;
            while (temp != null)
            {
                list.Add(temp.val);
                temp = temp.next;
            }
            return list;
        }

        public override string ToString()
        {
            var values = GetValues();
            return "[" + string.Join(",", values.ToArray()) + "]";
        }

        public static ListNode Create(params int[] nums)
        {
            var list = new List<ListNode>();
            for (int i = 0; i < nums.Length; i++)
            {
                list.Add(new ListNode(nums[i]));
                if (i > 0)
                {
                    list[i-1].next = list[i];
                }
            }
            Debug.WriteLine($"ToListNode: {list[0].ToString()}");
            return list[0];
        }
    }
}
