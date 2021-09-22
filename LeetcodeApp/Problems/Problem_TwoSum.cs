using LeetcodeApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetcodeApp.Problems
{
    public class Problem_TwoSum: IRunable
    {
        public void Run()
        {
            //var dictionary = array.Select((value, index) => new { value, index })
            //           .ToDictionary(pair => pair.value, pair => pair.index);

            var nums = Enumerable.Range(1, 10000).ToArray();
            var expected = 19999;

            var results = TwoSum(nums, expected);

            Console.WriteLine(results);
        }

        public int[] TwoSum(int[] nums, int target)
        {
            int[] results = new int[] { 0, 0 };

            for (int i = 0; i < nums.Length; i++)
            {
                var dict = nums.Where(x => nums[i] + x == target)
                               .Select((value, index) => new { value, index })
                               .ToDictionary(pair => pair.value, pair => pair.index);
                Console.WriteLine(dict);
                //for (int j = 0; j < nums.Length; j++)
                //{
                //    Console.WriteLine($"Loop {i}, {j}");
                //    if (i != j && nums[i] + nums[j] == target)
                //    {
                //        results[0] = i;
                //        results[1] = j;
                //        return results;
                //    }
                //}
            }

            return results;
        }
    }
}
