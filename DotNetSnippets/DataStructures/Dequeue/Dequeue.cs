using System;

namespace DotNetSnippets.DataStructures.Dequeue
{
    public class Dequeue<T>
    {
        public DequeueNode<T> Head { get; private set; }
        public DequeueNode<T> Tail { get; private set; }

        public void PushFront(T newValue)
        {
            if (newValue == null) throw new ArgumentException("Provided value cannot be null.");

            DequeueNode<T> newNode = new DequeueNode<T>(newValue);

            if (Head == null)
            {
                Head = Tail = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head.Previous = newNode;
                Head = newNode;
            }
        }

        public void PushBack(T newValue)
        {
            if (newValue == null) throw new ArgumentException("Provided value cannot be null.");

            DequeueNode<T> newNode = new DequeueNode<T>(newValue);

            if (Tail != null)
            {
                Tail.Next = newNode;
                newNode.Previous = Tail;
            }

            Tail = newNode;
        }

        public T PopFront()
        {
            if (Head == null) return default(T);

            var cachedHead = Head;

            Head = Head.Next;

            if (Head != null)
                Head.Previous = null;
            else
                Tail = null;

            return cachedHead.Value;
        }

        public T PopBack()
        {
            if (Tail == null) return default(T);

            var cachedTail = Tail;

            Tail = Tail.Previous;

            if (Tail != null)
                Tail.Next = null;
            else
                Head = null;

            return cachedTail.Value;
        }
    }
}
