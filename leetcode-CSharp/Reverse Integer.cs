using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class ReverseInteger
    {
        public int Reverse(int x)
        {
            if (x == int.MinValue) goto error;
            int sign = Math.Sign(x);
            x = Math.Abs(x);
            int result = 0;
            while (x != 0)
            {
                var tmp = result * 10 + x % 10;
                if (result != (tmp - x % 10) / 10)
                    goto error;
                result = tmp;
                x /= 10;
            }
            if (result != int.MaxValue || sign != -1)
                return sign * result;
        error:
            return 0;
        }
    }
}
