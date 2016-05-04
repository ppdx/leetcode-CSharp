using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class RemoveDuplicatesFromSortedArray
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0 || nums.Length == 1) return nums.Length;
            int i = 0;
            int j = 0;
            while (j < nums.Length)
            {
                nums[i++] = nums[j];
                while (j < nums.Length - 1 && nums[j] == nums[j + 1])
                {
                    j++;
                }
                j++;
            }
            return i;
        }
    }
}
