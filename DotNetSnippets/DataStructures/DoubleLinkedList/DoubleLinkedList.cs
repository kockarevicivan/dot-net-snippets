using System.Collections;

namespace DotNetSnippets.DataStructures.DoubleLinkedList
{
    public class DoubleLinkedList <T> : IEnumerable
    {
        public DoubleLinkedListNode<T> Head { get; private set; }
        public DoubleLinkedListNode<T> Tail { get; private set; }

        public DoubleLinkedList<T> Add(T value)
        {
            if (Head == null)
            {
                Tail = Head = new DoubleLinkedListNode<T>(value);
            }
            else
            {
                var newNode = new DoubleLinkedListNode<T>(value);

                newNode.Previous = Tail;

                Tail = Tail.Next = newNode;
            }

            return this;
        }

        public DoubleLinkedListNode<T> Search(T value)
        {
            DoubleLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                    return current;

                current = current.Next;
            }

            return null;
        }

        public DoubleLinkedList<T> Remove(T value)
        {
            DoubleLinkedListNode<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    if(current.Previous != null)
                        current.Previous.Next = current.Next;

                    if (current.Next != null)
                        current.Next.Previous = current.Previous;
                }

                current = current.Next;
            }

            return this;
        }

        public IEnumerator GetEnumerator()
        {
            DoubleLinkedListNode<T> current = Head;

            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }
    }
}
