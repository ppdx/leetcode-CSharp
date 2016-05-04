using System;

namespace leetcode_CSharp
{
    public class MedianOfTwoSortedArrays
    {
        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int count = nums1.Length + nums2.Length;
            if (count % 2 == 1) return FindKthItem(nums1, nums2, count / 2 + 1);
            return (FindKthItem(nums1, nums2, count / 2)
                    + FindKthItem(nums1, nums2, count / 2 + 1)) / 2.0;
        }

        public int FindKthItem(int[] nums1, int[] nums2, int k)
        {
            int s1 = 0, e1 = nums1.Length;
            int s2 = 0, e2 = nums2.Length;

            while (true)
            {
                if (e1 - s1 > e2 - s2)
                {
                    int[] tmp = nums1;
                    nums1 = nums2;
                    nums2 = tmp;
                    int tmp1 = s1;
                    s1 = s2;
                    s2 = tmp1;
                    int tmp2 = e1;
                    e1 = e2;
                    e2 = tmp2;
                }

                if (e1 - s1 == 0) return nums2[k - 1 + s2];
                if (k == 1) return nums1[s1] <= nums2[s2] ? nums1[s1] : nums2[s2];

                int n = e1 - s1 > k / 2 ? k / 2 : e1 - s1;
                int a = nums1[n - 1 + s1];
                int b = nums2[s2 + k - n - 1];
                if (a == b)
                {
                    return a;
                }
                else if (a > b)
                {
                    e1 = s1 + n;
                    s2 = s2 + k - n;
                    k = n;
                }
                else
                {
                    s1 = s1 + n;
                    e2 = s2 + k - n;
                    k -= n;
                }
            }
        }
    }
}