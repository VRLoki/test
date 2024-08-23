using System;

/// <summary>
/// Represents a queue of type T.
/// </summary>
/// <typeparam name="T">Type of data stored.</typeparam>
public class Queue<T>
{
    private Node head;
    private Node tail;
    private int count;

    /// <summary>
    /// Returns the queue's type.
    /// </summary>
    /// <returns>The queue's type</returns>
    public Type CheckType() => typeof(T);

    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        internal T value = default(T);
        internal Node next = default(Node);

        /// <summary>
        /// Constructor for the node.
        /// </summary>
        public Node(T input) => value = input;
    }

    /// <summary>
    /// Adds a node to the queue.
    /// </summary>
    /// <param name="value"></param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
            head = newNode;
        else
        {
            Node node = head;
            while (node.next != null)
                node = node.next;
            node.next = newNode;
        }
        tail = newNode;
        count++;
    }

    /// <summary>
    /// Gets the number of nodes in the queue.
    /// </summary>
    /// <returns>Number of nodes in the queue.</returns>
    public int Count() => count;

    /// <summary>
    /// Deletes the first node and returns its value.
    /// </summary>
    /// <returns>The value of the node.</returns>
    public T Dequeue()
    {
        T value;

        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        value = head.value;
        head = head.next;
        if (head == null)
            tail = null;
        count--;
        return value;
    }

    /// <summary>
    /// Returns the value of the first node.
    /// </summary>
    /// <returns>The value of the first node.</returns>
    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        return head.value;
    }
}
