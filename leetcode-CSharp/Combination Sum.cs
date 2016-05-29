using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class CombinationSumSolution
    {
        private IList<IList<int>> result;
        private int[] candidates;
        private int target;
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            Array.Sort(candidates);
            this.result = new List<IList<int>>(100);
            this.candidates = candidates;
            this.target = target;
            Dfs(0, 0, new int[] { });
            return this.result;
        }

        private void Dfs(int index, int sum, IList<int> path)
        {
            if (sum == target)
            {
                result.Add(path);
                return;
            }
            while (index < candidates.Length && candidates[index] <= target - sum)
            {
                var tmp = new List<int>(path);
                tmp.Add(candidates[index]);
                Dfs(index, sum + candidates[index], tmp);
                index++;
            }
        }
    }
}
