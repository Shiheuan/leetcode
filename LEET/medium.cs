using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LEET
{
    public class medium
    {
        /*You are given two non-empty linked lists representing two 
         * non-negative integers. 
         * The digits are stored in reverse order and each of 
         * their nodes contain a single digit. 
         * Add the two numbers and return it as a linked list.
         * You may assume the two numbers do not contain any leading zero, 
         * except the number 0 itself.
         */
        static bool isTen;
        static bool checkTen(ref easy.ListNode l)
        {
            if (l.val > 9)
            {
                l.val %= 10;
                isTen = true;
                
            }
            else isTen = false;
            return isTen;
        }
        public static easy.ListNode AddTwoNumbers(easy.ListNode l1, easy.ListNode l2)
        {
            {
                if (l1 == null && l2 == null)
                    if (isTen)
                    {
                        isTen = false;
                        return new easy.ListNode(1);
                    }
                    else return null;
                if (l1 == null)
                {
                    if (isTen)
                    {
                        l2.val++;
                        if (checkTen(ref l2))
                            l2.next = AddTwoNumbers(new easy.ListNode(0), l2.next);
                    }
                    return l2;
                }
                if (l2 == null)
                {
                    if (isTen)
                    {
                        l1.val++;
                        if (checkTen(ref l1))
                            l1.next = AddTwoNumbers(new easy.ListNode(0), l1.next);
                    }
                    return l1;
                }
                l1.val = (isTen)?(l1.val+l2.val+1):(l1.val+l2.val);
                checkTen(ref l1);
                l1.next = AddTwoNumbers(l1.next, l2.next);
                return l1;
            }
        }
        // others'
        public static easy.ListNode AddTwoNumbers2(easy.ListNode l1, easy.ListNode l2)
        {
            easy.ListNode head = new easy.ListNode(-1);
            easy.ListNode node = head;
            int sum = 0;
            int carry = 0;
            long count = 0;
            while (l1 != null && l2 != null)
            {

                sum = l1.val + l2.val + carry;
                carry = sum / 10;
                if (carry != 0)
                    sum = sum % 10;
                l1 = l1.next;
                l2 = l2.next;
                if (count == 0)
                {
                    head.val = sum;
                    head = node;
                    count++;
                }
                else
                {
                    node.next = new easy.ListNode(sum);
                    node = node.next;
                }
            }

            while (l1 != null)
            {
                sum = l1.val + carry;
                carry = sum / 10;
                if (carry != 0)
                    sum = sum % 10;
                node.next = new easy.ListNode(sum);
                node = node.next;
                l1 = l1.next;
            }

            while (l2 != null)
            {
                sum = l2.val + carry;
                carry = sum / 10;
                if (carry != 0)
                    sum = sum % 10;
                node.next = new easy.ListNode(sum);
                node = node.next;
                l2 = l2.next;
            }

            if (carry != 0)
            {
                node.next = new easy.ListNode(carry);
            }

            return head;
        }
    }
}
