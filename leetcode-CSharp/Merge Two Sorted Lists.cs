using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            var result = new ListNode(0);
            var head = result;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    result.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    result.next = l2;
                    l2 = l2.next;
                }
                result = result.next;
            }
            while (l1 != null)
            {
                result.next = l1;
                result = result.next;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                result.next = l2;
                result = result.next;
                l2 = l2.next;
            }
            return head.next;
        }
    }
}
