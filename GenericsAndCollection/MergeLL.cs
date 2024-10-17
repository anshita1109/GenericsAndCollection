//Merge two sorted linkedlist
using System;

public class ListNode1
{
    public int Val;
    public ListNode Next;
    public ListNode1(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}

public class MergeTwoSortedLinkedLists
{
    public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        if (l1 == null) return l2;
        if (l2 == null) return l1;

        ListNode dummy = new ListNode(0);
        ListNode tail = dummy;

        while (l1 != null && l2 != null)
        {
            if (l1.Val < l2.Val)
            {
                tail.Next = l1;
                l1 = l1.Next;
            }
            else
            {
                tail.Next = l2;
                l2 = l2.Next;
            }
            tail = tail.Next;
        }

        tail.Next = l1 ?? l2;
        return dummy.Next;
    }

    public static void Main()
    {
        ListNode l1 = new ListNode(1, new ListNode(2, new ListNode(4)));
        ListNode l2 = new ListNode(1, new ListNode(3, new ListNode(4)));
        ListNode mergedHead = MergeTwoLists(l1, l2);
        Console.Write("Merged List: ");
        PrintList(mergedHead);
    }

    private static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.Val + (head.Next != null ? " -> " : "\n"));
            head = head.Next;
        }
    }
}