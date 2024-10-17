//Find the Element of a LinkedList

using System;

public class ListNode3
{
    public int Val;
    public ListNode Next;
    public ListNode3(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}

public class FindMiddleElement
{
    public static ListNode FindMiddle(ListNode head)
    {
        if (head == null) return null;

        ListNode slow = head;
        ListNode fast = head;

        while (fast != null && fast.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;
        }
        return slow;
    }

    public static void Main()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
        ListNode middle = FindMiddle(head);
        Console.WriteLine($"Middle Element: {middle?.Val}"); // Should print 3
    }
}