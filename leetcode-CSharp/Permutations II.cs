using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class PermutationsII
    {
        public IList<IList<int>> PermuteUnique(int[] nums)
        {
            Array.Sort(nums);
            int len = Enumerable.Range(1, nums.Length).Aggregate((a, b) => a * b);
            var res = new List<IList<int>>(len);
            for (;;)
            {
                res.Add((int[])nums.Clone());
                if (!NextPermutation(nums)) break;
            }
            return res;

        }

        bool NextPermutation(int[] nums)
        {
            if (nums.Length < 2)
            {
                return false;
            }
            int i = nums.Length - 2;
            for (; i >= 0 && nums[i] >= nums[i + 1]; i--)
                ;
            if (i == -1)
            {
                Reverse(nums, 0);
                return false;
            }
            else
            {
                int j = nums.Length;
                while (nums[i] >= nums[--j]) ;
                int tmp = nums[i];
                nums[i] = nums[j];
                nums[j] = tmp;
                Reverse(nums, i + 1);
                return true;
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
