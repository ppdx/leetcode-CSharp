using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class StringToIntegerAtoi
    {
        public int MyAtoi(string str)
        {
            int i = 0;
            for (; i < str.Length && str[i] == ' '; i++)
                ;
            int sign = i != str.Length && str[i] == '-' ? -1 : 1;
            if (i != str.Length && (str[i] == '-' || str[i] == '+')) i++;
            long num = 0;
            if (i != str.Length && char.IsDigit(str[i]))
            {
                num = sign * (str[i] - '0');
                i++;
            }
            for (; i < str.Length && char.IsDigit(str[i]); i++)
            {
                num = num*10 + sign*(str[i] - '0');

                if (num < int.MinValue) return int.MinValue;
                if (num > int.MaxValue) return int.MaxValue;
            }
            return (int)num;
        }
    }
}
