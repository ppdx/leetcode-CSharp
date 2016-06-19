using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class JumpGameII
    {
        public int Jump(int[] nums)
        {
            int len = nums.Length;
            if (len <= 1) return 0;
            var jumps = Enumerable.Repeat(int.MaxValue, len).ToArray();
            jumps[0] = 0;
            for (int i = 0; i < len - 1; i++)
            {
                int max = Math.Min(i + nums[i] + 1, len);
                int jump = jumps[i] + 1;
                for (int j = i; j < max; j++)
                {
                    if (jump < jumps[j])
                        jumps[j] = jump;
                }
            }
            return jumps.Last();
        }
    }
}
