using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEET
{
    public class medium
    {
        /*
         * 
         */
        public static easy.ListNode AddTwoNumbers(easy.ListNode l1, easy.ListNode l2)
        {
            l1.val += l2.val;
            bool isTen = l1.val >= 10;
            if (l1.next == null && l2.next == null) return l1;
            if (l1.next == null)
            {
                l1.next = AddTwoNumbers(new easy.ListNode(0), l2.next);
                return l1;
            }
            if (l2.next == null)
            {
                l1.next = AddTwoNumbers(l1.next, new easy.ListNode(0));
                return l1;
            }
            l1.next = AddTwoNumbers(l1.next, l2.next);
            return l1;
        }
    }
}
