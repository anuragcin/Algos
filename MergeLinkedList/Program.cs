using System;

namespace MergeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge LinkedList");

            ListNode l1first = new ListNode(1);
            ListNode l1second = new ListNode(2);
            ListNode l1third = new ListNode(4);
            ListNode l1 = new ListNode(0);
            l1 = l1first;
            l1first.next = l1second;
            l1second.next = l1third;


            ListNode l2first = new ListNode(1);
            ListNode l2second = new ListNode(3);
            ListNode l2third = new ListNode(4);
            ListNode l2 = new ListNode(0);
            l2 = l2first;
            l2first.next = l2second;
            l2second.next = l2third;


            ListNode result =MergeTwoLists(l1, l2);

            while (result!=null)
            {
                Console.Write(result.val +" -> ");
                result = result.next;
            }

            Console.ReadLine();

        }

        
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null || l2 == null) return l1 ?? l2;

            if (l1.val <= l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }
        
    }
    
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val,ListNode next=null)
        { 
            this.val = val;
            this.next = next;
        }
    }
}
