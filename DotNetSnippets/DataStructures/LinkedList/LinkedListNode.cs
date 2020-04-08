namespace DotNetSnippets.DataStructures.SingleLinkedList
{
    public class LinkedListNode<T>
    {
        public T Value;
        public LinkedListNode<T> Next;

        public LinkedListNode(T value)
        {
            this.Value = value;
            this.Next = null;
        }
    }
}
