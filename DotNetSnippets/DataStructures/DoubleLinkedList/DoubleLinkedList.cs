using System.Collections;

namespace DotNetSnippets.DataStructures.DoubleLinkedList
{
    public class DoubleLinkedList <T> : IEnumerable
    {
        private DLLNode<T> _head = null;
        private DLLNode<T> _tail = null;

        public DoubleLinkedList<T> Add(T value)
        {
            if (_head == null)
            {
                _tail = _head = new DLLNode<T>(value);
            }
            else
            {
                var newNode = new DLLNode<T>(value);

                newNode.Previous = _tail;

                _tail = _tail.Next = newNode;
            }

            return this;
        }

        public DLLNode<T> Search(T value)
        {
            DLLNode<T> current = _head;

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
            DLLNode<T> current = _head;

            //if (_head.Value.Equals(value))
            //{
            //    _head = _head.Next;

            //    if(_head.Next != null)
            //        _head.Next.Previous = null;
            //}

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
            DLLNode<T> current = _head;

            while (current != null)
            {
                yield return current.Value;

                current = current.Next;
            }
        }
    }
}
