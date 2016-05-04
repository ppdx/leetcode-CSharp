using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class _3SumClosest
    {
        public int ThreeSumClosest(int[] nums, int target)
        {
            var result = int.MaxValue;
            var len = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i < len - 2; i++)
            {
                if (i != 0 && (i <= 0 || nums[i] == nums[i - 1])) continue;
                int left = i + 1;
                int right = len - 1;
                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum == target)
                        return target;
                    int a = result - target;
                    int a1 = sum - target;
                    result = (a >= 0 ? a : -a) > (a1 >= 0 ? a1 : -a1) ? sum : result;
                    if (sum > target)
                    {
                        while (right > 0 && nums[right] == nums[right - 1]) right--;
                        right--;
                    }
                    else
                    {
                        while (left < len - 1 && nums[left] == nums[left + 1]) left++;
                        left++;
                    }
                }
            }
            return result;
        }
    }
}
