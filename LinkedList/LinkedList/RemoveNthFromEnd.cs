namespace LinkedList
{
    public static class Solution19
    {
        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head.next == null)
                return null;

            ListNode nBehindCurrent = head;
            ListNode current = head;
            int steps = 0;

            while (current.next != null)
            {
                current = current.next;
                steps++;

                if (steps == n)
                {
                    nBehindCurrent = nBehindCurrent.next;
                    steps = 0;
                }
            }

            if (head.next.next == null)
            {
                if (n == 1)
                {
                    head.next = null;
                    return head;
                }
                else if (n == 2)
                {
                    head = head.next;
                    return head;
                }
            }

            if (nBehindCurrent.next != null && nBehindCurrent.next.next != null)
                nBehindCurrent.next = nBehindCurrent.next.next;
            else
            {
                var secondLast = head;
                while (secondLast.next.next != null)
                {
                    secondLast = secondLast.next;
                }
                secondLast.next = null;
                return head;
            }

            return head;
        }
    }
}
