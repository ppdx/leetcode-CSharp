using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    class RemoveNthNodeFromEndOfList
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            try
            {
                Helper(head, n);
                return head.next;
            }
            catch (Exception)
            {
                return head;
            }
        }

        private int Helper(ListNode head, int i)
        {
            if (head == null) return 0;
            int height = Helper(head.next, i);
            if (height==i)
            {
                head.next = head.next.next;
                throw new Exception();
            }
            return height + 1;
        }
    }
}
