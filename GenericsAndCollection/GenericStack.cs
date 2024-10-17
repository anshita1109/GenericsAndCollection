//Implement a generic Stack

using System;

public class Stack<T>
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

    private Node top;

    public void Push(T value)
    {
        Node newNode = new Node(value) { Next = top };
        top = newNode;
    }

    public T Pop()
    {
        if (top == null) throw new InvalidOperationException("Stack is empty.");
        T value = top.Value;
        top = top.Next;
        return value;
    }

    public bool IsEmpty()
    {
        return top == null;
    }

    public static void Main()
    {
        var stack = new Stack<int>();
        stack.Push(18);
        stack.Push(65);
        stack.Push(76);
        Console.WriteLine($"Popped Value: {stack.Pop()}"); 
        Console.WriteLine($"Stack Empty: {stack.IsEmpty()}");
    }
}