using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    class LongestCommonPrefixSolution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 0) return "";
            if (strs.Length == 1) return strs[0];
            for (int i = strs.Min(s => s.Length); i > 0; i--)
            {
                string prefix = strs[0].Substring(0, i);
                if (strs.All(s => s.StartsWith(prefix))) return prefix;
            }
            return "";
        }
    }
}
