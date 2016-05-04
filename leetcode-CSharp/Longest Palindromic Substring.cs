using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class LongestPalindromicSubstring
    {
        public string LongestPalindrome(string s)
        {
            int len = s.Length;
            int maxLen = 0;
            int maxLeft = 0;

            // no center
            for (int left = 0, right = 1; right < len; left++, right++)
            {
                int l = Math.Min(len - right, left + 1);
                int i = 0;
                for (; i < l && s[left - i] == s[right + i]; i++)
                    ;
                if (2 * i > maxLen)
                {
                    maxLen = 2 * i;
                    maxLeft = left - i + 1;
                }
            }

            // center
            for (int center = 0; center < len; center++)
            {
                int l = Math.Min(center + 1, len - center);
                int i = 1;
                for (; i < l && s[center - i] == s[center + i]; i++)
                    ;
                if (2 * i - 1 > maxLen)
                {
                    maxLen = 2 * i - 1;
                    maxLeft = center - i + 1;
                }
            }
            return s.Substring(maxLeft, maxLen);
        }
    }
}
