using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class SearchInRotatedSortedArray
    {
        public int Search(int[] nums, int target)
        {
            int length = nums.Length;
            if (length == 0) return -1;
            if (length == 1) return nums[0] == target ? 0 : -1;
            return SearchHelper(nums, 0, length - 1, target);
        }

        private int SearchHelper(int[] nums, int left, int right, int target)
        {
            if (left > right) return -1;
            if (left == right) return nums[left] == target ? left : -1;
            int center = (left + right) / 2;
            if (nums[center] == target) return center;
            if (nums[left] <= nums[center])
            {
                if (nums[left] <= target && target < nums[center])
                    return SearchHelper(nums, left, center - 1, target);
                return SearchHelper(nums, center + 1, right, target);
            }
            else // nums[left] > nums[center]
            {
                if (nums[center] < target && target <= nums[right])
                    return SearchHelper(nums, center + 1, right, target);
                return SearchHelper(nums, left, center - 1, target);
            }
        }
    }
}
