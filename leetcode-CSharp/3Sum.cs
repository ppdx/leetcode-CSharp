using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class _3Sum
    {
        public IList<IList<int>> ThreeSum(int[] nums)
        {
            var positive = new Dictionary<int, int>();
            var negative = new Dictionary<int, int>();
            int zeros = 0;
            foreach (int i in nums)
            {
                if (i > 0)
                {
                    int value;
                    if (positive.TryGetValue(i, out value))
                        positive[i] = value + 1;
                    else
                        positive[i] = 1;
                }
                else if (i < 0)
                {
                    int value;
                    if (negative.TryGetValue(i, out value))
                        negative[i] = value + 1;
                    else
                        negative[i] = 1;
                }
                else zeros++;
            }

            var result = new List<IList<int>>();
            if (zeros >= 3) result.Add(new[] { 0, 0, 0 }); // 0 0 0

            if (zeros > 0) // - 0 +
                if (negative.Count < positive.Count)
                    result.AddRange(from i in negative.Keys where positive.ContainsKey(-i) select new[] { i, 0, -i });
                else
                    result.AddRange(from i in positive.Keys where negative.ContainsKey(-i) select new[] { -i, 0, i });

            foreach (int i in positive.Keys) // - - +
            {
                foreach (int key in negative.Keys)
                {
                    if (key < -i / 2 && negative.ContainsKey(-i - key))
                    {
                        result.Add(new[] { key, -i - key, i });
                    }
                }
                if (i % 2 == 0 && negative.ContainsKey(-i / 2) && negative[-i / 2] >= 2)
                    result.Add(new[] { -i / 2, -i / 2, i });
            }

            foreach (int i in negative.Keys) // - + +
            {
                foreach (int key in positive.Keys)
                {
                    if (key > -i / 2 && positive.ContainsKey(-i - key))
                    {
                        result.Add(new[] { i, -i - key, key });
                    }
                }
                if (i % 2 == 0 && positive.ContainsKey(-i / 2) && positive[-i / 2] >= 2)
                    result.Add(new[] { i, -i / 2, -i / 2 });
            }
            return result;
        }

        public IList<IList<int>> ThreeSum2(int[] nums)
        {
            var result = new List<IList<int>>();
            var len = nums.Length;
            Array.Sort(nums);
            for (int i = 0; i < len - 2; i++)
            {
                if (i != 0 && (i <= 0 || nums[i] == nums[i - 1])) continue;
                int left = i + 1;
                int right = len - 1;
                while (left < right)
                {
                    var sum = nums[i] + nums[left] + nums[right];
                    if (sum == 0)
                    {
                        result.Add(new[] { nums[i], nums[left], nums[right] });
                        while (left < len - 1 && nums[left] == nums[left + 1]) left++;
                        while (right > 0 && nums[right] == nums[right - 1]) right--;
                        left++;
                        right--;
                    }
                    else if (sum > 0)
                    {
                        while (right > 0 && nums[right] == nums[right - 1]) right--;
                        right--;
                    }
                    else
                    {
                        while (left < len - 1 && nums[left] == nums[left + 1]) left++;
                        left++;
                    }
                }
            }
            return result;
        }
    }
}
