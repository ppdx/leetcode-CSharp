using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class SearchInsertPosition
    {
        public int SearchInsert(int[] nums, int target)
        {
            int length = nums.Length;
            if (length == 0) return 0;
            if (length == 1) return nums[0] >= target ? 0 : 1;
            int left = 0, right = length - 1;
            while (left <= right)
            {
                int center = (left + right) / 2;
                if (nums[center] == target) return center;
                if (nums[center] < target) left = center + 1;
                else right = center - 1;
            }
            return left;
        }
    }
}
