using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class MergeKSortedLists
    {
        public ListNode MergeKLists(ListNode[] lists)
        {
            if (lists == null || lists.Length == 0)
                return null;
            if (lists.Length == 1) return lists[0];

            var list = lists.ToList();
            var result = new ListNode(0);
            var head = result;

            ListNode node = null;
            int index = -1;
            while(true)
            {
                node = null;
                int i = 0;
                while (i < list.Count)
                {
                    var p = list[i];
                    if (p == null)
                    {
                        list.RemoveAt(i);
                        continue;
                    }
                    else if (node == null || node.val > p.val)
                    {
                        node = p;
                        index = i;
                    }
                    i++;
                }
                if (node == null) break;
                result.next = node;
                result = result.next;
                list[index] = node.next;
            }
            return head.next;
        }
    }
}
