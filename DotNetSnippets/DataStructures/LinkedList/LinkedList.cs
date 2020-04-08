using System.Collections;

namespace DotNetSnippets.DataStructures.SingleLinkedList
{
    public class LinkedList <T> : IEnumerable
    {
        public LinkedListNode<T> Head { get; private set; }
        public LinkedListNode<T> Tail { get; private set; }

        public LinkedList<T> Add(T value)
        {
            if (Head == null)
                Tail = Head = new LinkedListNode<T>(value);
            else
                Tail = Tail.Next = new LinkedListNode<T>(value);

            return this;
        }

        public LinkedListNode<T> Search(T value)
        {
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                    return current;

                current = current.Next;
            }

            return null;
        }

        public LinkedList<T> Remove(T value)
        {
            LinkedListNode<T> current = Head;

            if (Head.Value.Equals(value))
                current = Head = Head.Next;

            while (current?.Next != null)
            {
                if (current.Next.Value.Equals(value))
                    current.Next = current.Next.Next;

                current = current.Next;
            }

            return this;
        }

        public IEnumerator GetEnumerator()
        {
            LinkedListNode<T> current = Head;

            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }
    }
}
