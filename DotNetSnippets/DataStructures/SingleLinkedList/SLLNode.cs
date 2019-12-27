namespace DotNetSnippets.DataStructures.SingleLinkedList
{
    public class SLLNode<T>
    {
        public T Value;
        public SLLNode<T> Next;

        public SLLNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
