using System;

namespace DotNetSnippets.DataStructures.Queue
{
    public class Queue<T>
    {
        public QueueNode<T> Head { get; private set; }

        public void Push(T newValue)
        {
            if (newValue == null) throw new ArgumentException("Provided value cannot be null.");

            QueueNode<T> newNode = new QueueNode<T>(newValue);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        public T Pop()
        {
            QueueNode<T> currentNode = Head;

            if (currentNode == null) // Queue empty.
            {
                return default(T);
            }
            else if (currentNode.Next == null) // Only one element in Queue.
            {
                Head = null;

                return currentNode.Value;
            }
            else
            {
                // Searching for the one before last one.
                while (currentNode.Next.Next != null)
                    currentNode = currentNode.Next;

                QueueNode<T> cachedNode = currentNode.Next;

                currentNode.Next = null;

                return cachedNode.Value;
            }
        }
    }
}
