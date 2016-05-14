using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class CountAndSaySolution
    {
        public string CountAndSay(int n)
        {
            var state = "1";
            while (--n > 0)
            {
                var next = new StringBuilder(state.Length * 2);
                for (int i = 0; i < state.Length; i++)
                {
                    int count = 1;
                    while (i < state.Length - 1 && state[i] == state[i + 1])
                    {
                        count++;
                        i++;
                    }
                    next.Append(count);
                    next.Append(state[i]);
                }
                state = next.ToString();
            }
            return state;
        }
    }
}
