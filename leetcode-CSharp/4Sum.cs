using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class _4Sum
    {
        public IList<IList<int>> FourSum(int[] nums, int target)
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();
            for (int i = 0; i < nums.Length - 3; i++)
            {
                if (i != 0 && (i <= 0 || nums[i] == nums[i - 1])) continue;
                foreach (IList<int> list in ThreeSum(nums, target - nums[i], i + 1))
                {
                    list[0] = nums[i];
                    result.Add(list);
                }
            }
            return result;
        }

        public IEnumerable<IList<int>> ThreeSum(int[] nums, int target, int begin)
        {
            var len = nums.Length;
            for (int i = begin; i < len - 2; i++)
            {
                if (i != begin && (i <= begin || nums[i] == nums[i - 1])) continue;
                int left = i + 1;
                int right = len - 1;
                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum == target)
                    {
                        yield return new[] { 0, nums[i], nums[left], nums[right] };
                        while (left < len - 1 && nums[left] == nums[left + 1]) left++;
                        while (right > begin && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum > target)
                    {
                        while (right > begin && nums[right] == nums[right - 1]) right--;
                        right--;
                    }
                    else
                    {
                        while (left < len - 1 && nums[left] == nums[left + 1]) left++;
                        left++;
                    }
                }
            }
        }

    }
}
