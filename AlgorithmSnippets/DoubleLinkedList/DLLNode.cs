namespace AlgorithmSnippets.DoubleLinkedList
{
    public class DLLNode<T>
    {
        public T Value;
        public DLLNode<T> Previous;
        public DLLNode<T> Next;

        public DLLNode(T value)
        {
            this.Value = value;
            this.Previous = null;
            this.Next = null;
        }
    }
}
