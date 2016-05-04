using System;
using System.Linq;

namespace leetcode_CSharp
{
    public class LengthOfLongestSubstringSolution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0 || s.Length == 1) return s.Length;
            var d = new int[s.Length];
            d[0] = 1;
            for (int i = 1; i < s.Length; i++)
            {
                int index = -1;
                for (int j = i - 1; j >= i - d[i - 1]; j--)
                {
                    if (s[j] == s[i])
                    {
                        index = j;
                        break;
                    }
                }
                d[i] = index == -1 ? d[i - 1] + 1 : i - index;
            }
            return d.Max();
        }

        public int LengthOfLongestSubstring2(string s)
        {
            if (s.Length == 0 || s.Length == 1) return s.Length;
            var d = new bool[256];
            int max = 0;
            int p = 0;
            for (int i = 0; i < s.Length; i++)
            {
                while (d[s[i]])
                {
                    d[s[p]] = false;
                    p++;
                }
                d[s[i]] = true;
                max = Math.Max(max, i - p + 1);
            }
            return max;
        }
    }
}