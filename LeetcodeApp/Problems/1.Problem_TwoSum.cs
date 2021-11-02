using LeetcodeApp.Extensions;
using LeetcodeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Problems
{
    public class Problem_TwoSum: IRunable
    {
        public void Run()
        {
            //1
            var nums1 = new int[] { 3, 2, 4 };
            var expected1 = 6;
            var results1 = TwoSum(nums1, expected1);

            //2
            var nums2 = new int[] { 3, 3 };
            var expected2 = 6;
            var results2 = TwoSum(nums2, expected2);

            ////3
            var nums3 = Enumerable.Range(1, 10000).ToArray();
            var expected3 = 19999;
            var results3 = TwoSum(nums3, expected3);

            Debug.WriteLine($"1. results>> {results1[0]} {results1[1]}");
            Debug.WriteLine($"2. results>> {results2[0]} {results2[1]}");
            Debug.WriteLine($"3. results>> {results3[0]} {results3[1]}");
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            var complement = 0;
            for (var i = 0; i < nums.Length; i++)
            {
                complement = target - nums[i];
                var index = 0;
                if (complement > 0 && dict.TryGetValue(complement, out index))
                {
                    return new int[] { index, i };
                }
                if (dict.ContainsKey(nums[i]) == false)
                {
                    dict.Add(nums[i], i);
                }
            }
            return null;
        }
    }
}
