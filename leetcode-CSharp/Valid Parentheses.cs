using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class ValidParentheses
    {
        public bool IsValid(string s)
        {
            var stack = new List<char>(s.Length);
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                    stack.Add(c);
                else
                {
                    char ret;
                    switch (c)
                    {
                        case ')':
                            ret = '(';
                            break;
                        case ']':
                            ret = '[';
                            break;
                        case '}':
                            ret = '{';
                            break;
                        default:
                            throw new ArgumentException();
                    }
                    if (stack.Count != 0 && stack.Last() == ret)
                        stack.RemoveAt(stack.Count - 1);
                    else
                        return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
