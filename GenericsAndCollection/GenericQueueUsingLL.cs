//Implement a Generic Queue Using Linked List


using System;

public class LinkedListQueue<T>
{
    private class Node
    {
        public T Value;
        public Node Next;

        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    private Node head;
    private Node tail;

    public LinkedListQueue()
    {
        head = null;
        tail = null;
    }

    public void Enqueue(T value)
    {
        Node newNode = new Node(value);
        if (tail != null)
        {
            tail.Next = newNode;
        }
        tail = newNode;
        if (head == null)
        {
            head = tail;
        }
    }

    public T Dequeue()
    {
        if (head == null) throw new InvalidOperationException("Queue is empty.");
        T value = head.Value;
        head = head.Next;
        if (head == null)
        {
            tail = null; // If the queue is now empty, set tail to null
        }
        return value;
    }

    public bool IsEmpty()
    {
        return head == null;
    }

    public static void Main()
    {
        var queue = new LinkedListQueue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        Console.WriteLine($"Dequeued Value: {queue.Dequeue()}"); // Should print 1
        Console.WriteLine($"Queue Empty: {queue.IsEmpty()}"); // Should print False
    }
}