using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class AddTwoNumbersSolution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            var head = new ListNode(0);
            var p = head;
            int up = 0;
            while (l1 != null && l2 != null)
            {
                int sum = l1.val + l2.val + up;
                p.next = new ListNode(sum % 10);
                up = sum >= 10 ? 1 : 0;
                p = p.next;
                l1 = l1.next;
                l2 = l2.next;
            }
            while (l1 != null)
            {
                int sum = l1.val + up;
                p.next = new ListNode(sum % 10);
                up = sum >= 10 ? 1 : 0;
                p = p.next;
                l1 = l1.next;
            }
            while (l2 != null)
            {
                int sum = l2.val + up;
                p.next = new ListNode(sum % 10);
                up = sum >= 10 ? 1 : 0;
                p = p.next;
                l2 = l2.next;
            }
            if (up != 0) p.next = new ListNode(1);
            return head.next;
        }
    }
}
