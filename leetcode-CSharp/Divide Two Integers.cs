using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class DivideTwoIntegers
    {
        public int Divide(int dividend, int divisor)
        {
            if (divisor == 0) return int.MaxValue;
            if (divisor == 1) return dividend;
            if (divisor == -1) return dividend == int.MinValue ? int.MaxValue : -dividend;
            if (divisor == int.MinValue) return dividend == int.MinValue ? 1 : 0;
            if (dividend == 0) return 0;
            int sign = Math.Sign(dividend) == Math.Sign(divisor) ? 1 : -1;
            int bits = 30;
            int result = 0;
            if (dividend == int.MinValue)
            {
                result += 1;
                dividend += Math.Abs(divisor);
            }
            divisor = Math.Abs(divisor);
            dividend = Math.Abs(dividend);
            while (dividend >= divisor)
            {
                for (int i = bits; i >= 0; i--)
                {
                    var v = divisor << i;
                    if ((divisor == v >> i) && dividend >= v)
                    {
                        result += 1 << i;
                        dividend -= v;
                        bits = i - 1;
                        break;
                    }
                }
            }
            return sign == -1 ? -result : result;
        }
    }
}
