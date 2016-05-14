using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class SearchForARange
    {
        private int[] nums;
        private int target;
        public int[] SearchRange(int[] nums, int target)
        {
            this.nums = nums;
            this.target = target;
            if (Array.BinarySearch(nums, target) < 0)
                return new[] { -1, -1 };
            return new[] { LowerBound(0, nums.Length - 1), UpperBound(0, nums.Length - 1) };
        }

        private int LowerBound(int left, int right)
        {
            if (left > right) return left;
            int center = (left + right) / 2;
            if (nums[center] < target)
                return LowerBound(center + 1, right);
            return LowerBound(left, center - 1);
        }

        private int UpperBound(int left, int right)
        {
            if (left > right) return right;
            int center = (left + right) / 2;
            if (nums[center] > target)
                return UpperBound(left, center - 1);
            return UpperBound(center + 1, right);
        }
    }
}
