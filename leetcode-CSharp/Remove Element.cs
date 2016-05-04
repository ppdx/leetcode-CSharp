using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class RemoveElementSolution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int left = 0;
            int right = nums.Length - 1;
            while (left <= right)
            {
                while (left < nums.Length && nums[left] != val)
                    left++;
                while (right >= 0 && nums[right] == val)
                    right--;
                if (left >= right) break;
                int tmp = nums[left];
                nums[left] = nums[right];
                nums[right] = tmp;
                left++;
                right--;
            }
            return left;
        }
    }
}
