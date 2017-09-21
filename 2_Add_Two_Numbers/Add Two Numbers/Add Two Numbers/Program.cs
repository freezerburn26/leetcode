/*

You are given two non-empty linked lists representing two non-negative integers.The digits are stored in reverse order and each of their nodes contain a single digit.Add the two numbers and return it as a linked list.

You may assume the two numbers do not contain any leading zero, except the number 0 itself.

Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
Output: 7 -> 0 -> 8



1562 / 1562 test cases passed.
Status: Accepted
Runtime: 208 ms
Submitted: 0 minutes ago


*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
}

public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        ListNode firstDigit;
        int tempSum = 0;
        int carry = 0;
        if((l1.val + l2.val) < 10)
        {
            firstDigit = new ListNode(l1.val + l2.val);
        }
        else
        {
            firstDigit = new ListNode((l1.val + l2.val)-10);
            carry = 1;
        }

        ListNode tempDigit = firstDigit;

        if((!(l1.next == null)) && (!(l2.next == null)))
        {
            while((!(l1.next == null)) && (!(l2.next == null)))
            {
                l1 = l1.next;
                l2 = l2.next;
                tempSum = l1.val + l2.val + carry;                

                if(tempSum >= 10)
                {
                    tempDigit.next = new ListNode(tempSum - 10);
                    carry = 1;
                }
                else
                {
                    tempDigit.next = new ListNode(tempSum);
                    carry = 0;
                }

                tempDigit = tempDigit.next;
            }
        }

        if(!(l1.next == null))
        {
            while(!(l1.next == null))
            {
                l1 = l1.next;
                tempSum = l1.val + carry;

                

                if (tempSum >= 10)
                {
                    tempDigit.next = new ListNode(tempSum - 10);
                    carry = 1;
                }
                else
                {
                    tempDigit.next = new ListNode(tempSum);
                    carry = 0;
                }

                tempDigit = tempDigit.next;
            }
        }

        if (!(l2.next == null))
        {
            while (!(l2.next == null))
            {
                l2 = l2.next;
                tempSum = l2.val + carry;

                

                if (tempSum >= 10)
                {
                    tempDigit.next = new ListNode(tempSum - 10);
                    carry = 1;
                }
                else
                {
                    tempDigit.next = new ListNode(tempSum);
                    carry = 0;
                }

                tempDigit = tempDigit.next;
            }
        }

        if(carry > 0)
        {
            tempDigit.next = new ListNode(carry);
        }

        return firstDigit;
    }
}



namespace Add_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            ListNode test1 = new ListNode(2);
            ListNode test2 = new ListNode(4);
            ListNode test3 = new ListNode(3);

            test1.next = test2;
            test2.next = test3;

            ListNode test4 = new ListNode(5);
            ListNode test5 = new ListNode(6);
            ListNode test6 = new ListNode(4);

            test4.next = test5;
            test5.next = test6;

            Solution test = new Solution();

            ListNode result = test.AddTwoNumbers(test1, test4);

            Console.WriteLine("Done");
        }
    }
}
