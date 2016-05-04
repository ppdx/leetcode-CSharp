using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class SwapNodesInPairs
    {
        public ListNode SwapPairs(ListNode head)
        {
            var p = new ListNode(0);
            var ret = p;
            p.next = head;
            while (p != null && p.next != null && p.next.next != null)
            {
                var a = p.next;
                var b = a.next;
                var tail = b.next;
                p.next = b;
                b.next = a;
                a.next = tail;
                p = a;
            }
            return ret.next;
        }
    }
}
