using System;

/// <summary>
/// Generic Queue class
/// </summary>
/// <typeparam name="T">Generic Type</typeparam>
class Queue<T>
{
    public int count;

    /// <summary>
    /// Head property
    /// </summary>
    public Node head { get; set; }

    /// <summary>
    /// Tail property
    /// </summary>
    public Node tail { get; set; }

    /// <summary>
    /// Retuns the type of queue value
    /// </summary>
    /// <returns>Queue value type</returns>
    public Type CheckType() => typeof(T);

    /// <summary>
    /// Add a new Node to the Queue
    /// </summary>
    public void Enqueue(T value)
    {
        Node node = new Node(value);
        if (head == null)
        {
            head = node;
            tail = node;
        }
        else
        {
            tail.Next = node;
            tail = node;
        }
        ++count;
    }

    /// <summary>
    /// Returns the number of nodes in the Queue
    /// </summary>
    /// <returns>Count of nodes in the Queue</returns>
    public int Count() => count;

    /// <summary>
    /// Node Class
    /// </summary>
    public class Node
    {
        private T value;
        private Node next;

        /// <summary>
        /// Value property
        /// </summary>
        public T Value
        {
            get => this.value;
            set => this.value = value;
        }

        /// <summary>
        /// Node property
        /// </summary>
        public Node Next
        {
            get => this.next;
            set => this.next = value;
        }

        /// <summary>
        /// Node's class constructor
        /// </summary>
        /// <param name="value">Node value</param>
        public Node(T value) => this.value = value;
    }
}
