using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class LongestValidParenthesesSolution
    {
        public int LongestValidParentheses(string s)
        {
            int length = s.Length;
            if (length < 2) return 0;
            int max = 0;
            for (int i = 0; i < length; i++)
            {
                if (max > length - i) return max;
                int leftParentheses = 0;
                int j = i;
                for (; j < length; j++)
                {
                    if (s[j] == '(') leftParentheses++;
                    else
                    {
                        leftParentheses--;
                        if (leftParentheses < 0) break;
                    }
                }
                if (((j == length && leftParentheses == 0) || leftParentheses == -1)
                    && max < j - i)
                    max = j - i;
            }
            return max;
        }

        public int LongestValidParentheses1(string s)
        {
            int length = s.Length;
            if (length < 2) return 0;
            int max = 0;
            var stack = new Stack<int>(s.Length);
            var ends = new Dictionary<int, int>(s.Length);
            for (int i = 0; i < length; i++)
            {
                if (s[i] == '(')
                {
                    stack.Push(i);
                    continue;
                }
                if (stack.Count == 0)
                    continue;
                int front = stack.Pop();
                if (ends.ContainsKey(front - 1)) front = ends[front - 1];
                if (max < i - front + 1) max = i - front + 1;
                ends[i] = front;
            }
            return max;
        }

    }
}
