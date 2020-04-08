namespace DotNetSnippets.DataStructures.DoubleLinkedList
{
    public class DoubleLinkedListNode<T>
    {
        public T Value;
        public DoubleLinkedListNode<T> Previous;
        public DoubleLinkedListNode<T> Next;

        public DoubleLinkedListNode(T value)
        {
            this.Value = value;
            this.Previous = null;
            this.Next = null;
        }
    }
}
