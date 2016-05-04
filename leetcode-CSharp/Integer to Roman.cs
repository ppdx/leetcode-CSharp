using System.Text;

namespace leetcode_CSharp
{
    public class IntegerToRoman
    {
        private readonly int[] _numbers = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
        private readonly string[] _romans = "M CM D CD C XC L XL X IX V IV I".Split();
        public string IntToRoman(int num)
        {
            var result = new StringBuilder();
            for (int i = 0; i < _numbers.Length;)
            {
                if (num >= _numbers[i])
                {
                    result.Append(_romans[i]);
                    num -= _numbers[i];
                }
                if (num < _numbers[i])
                    i++;
            }
            return result.ToString();
        }
    }
}
