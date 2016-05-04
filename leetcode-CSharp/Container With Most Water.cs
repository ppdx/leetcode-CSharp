using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class ContainerWithMostWater
    {
        public int MaxArea(int[] height)
        {
            int left = 0, right = height.Length - 1;
            int maxArea = 0;
            while (left < right)
            {
                maxArea = Math.Max(maxArea,
                    Math.Min(height[left], height[right]) * (right - left));
                if (height[left] < height[right])
                    left++;
                else
                    right--;
            }
            return maxArea;
        }
    }
}
