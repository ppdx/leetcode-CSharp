using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class ReverseNodesInKGroup
    {
        public ListNode ReverseKGroup(ListNode head, int k)
        {
            var p = new ListNode(0);
            p.next = head;
            var ret = p;
            while (true)
            {
                var tail = p;
                for (int i = 0; i < k; i++)
                {
                    if (tail.next == null)
                        goto Return;
                    tail = tail.next;
                }
                var tmp = tail.next;
                tail.next = null;
                tail = tmp;
                tmp = p.next;
                p.next = Reverse(p.next);
                tmp.next = tail;
                p = tmp;
            }
        Return:
            return ret.next;
        }

        public ListNode Reverse(ListNode head)
        {
            if (head == null) return null;
            ListNode p = head;
            ListNode tail = p.next;
            p.next = null;
            while (tail != null)
            {
                var next = tail.next;
                tail.next = p;
                p = tail;
                tail = next;
            }
            return p;
        }
    }
}
