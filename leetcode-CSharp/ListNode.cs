using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_CSharp
{
    public class ListNode : IEnumerable<int>, ICloneable
    {
        protected bool Equals(ListNode other)
        {
            return val == other.val && Equals(next, other.next);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (val * 397) ^ (next?.GetHashCode() ?? 0);
            }
        }

        public int val;
        public ListNode next;
        public ListNode(int val, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }

        public override string ToString()
        {
            return "[" + string.Join(" -> ", this) + "]";
        }

        public static ListNode Builder(IEnumerable<int> enumerable)
        {
            var node = new ListNode(int.MinValue);
            var p = node;
            foreach (var item in enumerable)
            {
                p.next = new ListNode(item);
                p = p.next;
            }
            return node.next;
        }

        public static bool operator ==(ListNode node, ListNode other)
        {
            var b1 = object.Equals(node, null);
            var b2 = object.Equals(other, null);
            if (b1 && b2) return true;
            if (b1 || b2) return false;
            return node.val == other.val && node.next == other.next;
        }

        public static bool operator !=(ListNode node, ListNode other)
        {
            return !(node == other);
        }

        public ListNode Reversed()
        {
            return Builder(this.Reverse());
        }

        public override bool Equals(object obj)
        {
            var other = obj as ListNode;
            return this == other;
        }

        public IList<int> ToList()
        {
            return this.ToArray();
        }

        public ListNode Clone()
        {
            return Builder(this);
        }

        public IEnumerator<int> GetEnumerator()
        {
            var head = this;
            while (head != null)
            {
                yield return head.val;
                head = head.next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            var head = this;
            while (head != null)
            {
                yield return head.val;
                head = head.next;
            }
        }

        object ICloneable.Clone()
        {
            return Builder(this);
        }
    }

}
