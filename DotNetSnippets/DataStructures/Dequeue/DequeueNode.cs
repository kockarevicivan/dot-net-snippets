namespace DotNetSnippets.DataStructures.Dequeue
{
    public class DequeueNode<T>
    {
        public DequeueNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }
        public DequeueNode<T> Next { get; set; }
        public DequeueNode<T> Previous { get; set; }
    }
}
