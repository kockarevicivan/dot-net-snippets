using System.Collections;

namespace AlgorithmSnippets.SingleLinkedList
{
    public class SingleLinkedList <T> : IEnumerable
    {
        private SLLNode<T> _head = null;
        private SLLNode<T> _tail = null;

        public SingleLinkedList<T> Add(T value)
        {
            if (_head == null)
                _tail = _head = new SLLNode<T>(value);
            else
                _tail = _tail.Next = new SLLNode<T>(value);

            return this;
        }

        public SLLNode<T> Search(T value)
        {
            SLLNode<T> current = _head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                    return current;

                current = current.Next;
            }

            return null;
        }

        public SingleLinkedList<T> Remove(T value)
        {
            SLLNode<T> current = _head;

            if (_head.Value.Equals(value))
                current = _head = _head.Next;

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
            SLLNode<T> current = _head;

            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }
    }
}
