using System;
using static LinkedList.Solution2;
using static LinkedList.Solution19;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            ListNode ln = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5, null)))));
            ListNode ln2 = new ListNode(1, new ListNode(2, null));
            ListNode ln3 = new ListNode(1, new ListNode(2, new ListNode(3, null)));
            ListNode ln4 = new ListNode(1, new ListNode(2, new ListNode(3, null)));

            Console.WriteLine(PrintLinkedList(ln));
            Console.WriteLine(PrintLinkedList(RemoveNthFromEnd(ln, 2)));

            Console.WriteLine(PrintLinkedList(ln2));
            Console.WriteLine(PrintLinkedList(RemoveNthFromEnd(ln2, 2)));

            Console.WriteLine(PrintLinkedList(ln3));
            Console.WriteLine(PrintLinkedList(RemoveNthFromEnd(ln3, 1)));

            Console.WriteLine(PrintLinkedList(ln4));
            Console.WriteLine(PrintLinkedList(RemoveNthFromEnd(ln4, 2)));

            Console.WriteLine(PrintLinkedList(AddTwoNumbers(ln, ln2)));
        }



        public static string PrintLinkedList(ListNode node)
        {
            string result = "";
            var current = node;
            while (current != null)
            {
                result += $"{current.val} ";
                current = current.next;
            }
            return result;
        }

    }
}
