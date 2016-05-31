using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class FirstMissingPositiveSolution
    {
        public int FirstMissingPositive(int[] nums)
        {
            int len = nums.Length;
            if (len == 0) return 1;
            bool hasLen = false;
            for (int i = 0; i < len; i++)
            {
                if (nums[i] == len) hasLen = true;
                if (nums[i] <= 0 || nums[i] >= len) nums[i] = 0;
            }

            const int mask = 0x40000000;
            const int unmask = 0x3fffffff;
            foreach (int n in nums)
                nums[n & unmask] |= mask;

            for (int i = 1; i < len; i++)
                if ((nums[i] & mask) == 0) return i;
            return hasLen ? len + 1 : len;
        }
    }
}
