using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class TrappingRainWater
    {
        public int Trap(int[] height)
        {
            if (height.Length < 3) return 0;
            int sum = 0;
            int max = height.Max();
            var firstMax = Array.FindIndex(height, n => n == max);
            var lastMax = Array.FindLastIndex(height, n => n == max);
            sum += CalcArea(firstMax, lastMax, height);
            for (int i = 0; i < firstMax;)
            {
                int left = height[i];
                int leftIndex = i;
                while (height[++i] <= left)
                    ;
                sum += CalcArea(leftIndex, i, height);
            }
            for (int i = height.Length - 1; i > lastMax;)
            {
                int right = height[i];
                int rightIndex = i;
                while (height[--i] <= right)
                    ;
                sum += CalcArea(i, rightIndex, height);
            }
            return sum;
        }

        private int CalcArea(int left, int right, int[] height)
        {
            int top = (height[left] <= height[right]) ? height[left] : height[right];
            int sum = 0;
            for (int i = left + 1; i < right; i++)
                sum += top - height[i];
            return sum;
        }
    }
}
