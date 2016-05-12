using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class Next_Permutation
    {
        public void NextPermutation(int[] nums)
        {
            if (nums.Length < 2)
            {
                return;
            }
            int i = nums.Length - 2;
            for (; i >= 0 && nums[i] >= nums[i + 1]; i--)
                ;
            if (i == -1) Reverse(nums, 0);
            else
            {
                int j = nums.Length;
                while (nums[i] >= nums[--j]) ;
                int tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                Reverse(nums, i + 1);
            }
        }

        void Reverse(int[] nums, int i)
        {
            int j = nums.Length - 1;
            while (i < j)
            {
                int tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                i++; j--;
            }
        }
    }
}
