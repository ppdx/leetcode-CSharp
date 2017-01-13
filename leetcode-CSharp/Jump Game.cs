using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class Jump_Game
    {
        public bool CanJump(int[] nums)
        {
            int n = nums.Length;
            if (n < 2) return true;
            bool[] positions = new bool[n];
            positions[0] = true;
            for (int i = 0; i < n; i++)
            {
                if (!positions[i]) return false;
                if (i + nums[i] >= n) return true;
                for (int j = 1; j <= nums[i]; j++)
                {
                    positions[i + j] = true;
                    if (nums[i] <= nums[i + j] + j) break;
                }
            }
            return true;
        }
    }
}
