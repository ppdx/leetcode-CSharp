using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class MaximumSubarray
    {
        public int MaxSubArray(int[] nums)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;
            foreach (int n in nums)
            {
                currentSum += n;
                if (maxSum < currentSum) maxSum = currentSum;
                if (currentSum < 0) currentSum = 0;
            }
            return maxSum;
        }
    }
}
