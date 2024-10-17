//Reverse a Linked List
using System;
public class ListNode
{
    public int Val;
    public ListNode Next;
    public ListNode(int val = 0, ListNode next = null)
    {
        Val = val;
        Next = next;
    }
}

public class ReverseLinkedList
{
    public static ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode current = head;

        while (current != null)
        {
            ListNode nextTemp = current.Next;
            current.Next = prev;
            prev = current;
            current = nextTemp;
        }
        return prev;
    }

    public static void Main()
    {
        ListNode head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4))));
        Console.WriteLine("Original List: 1 -> 2 -> 3 -> 4");
        ListNode reversedHead = ReverseList(head);
        Console.Write("Reversed List: ");
        PrintList(reversedHead);
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