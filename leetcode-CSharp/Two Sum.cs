using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class TwoSumSolution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int rest = target - nums[i];
                if (dict.ContainsKey(rest))
                    return new int[] { dict[rest], i };
                dict[nums[i]] = i;
            }
            return null;
        }
    }
}
