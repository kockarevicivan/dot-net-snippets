namespace DotNetSnippets.DataStructures.Queue
{
    public class QueueNode<T>
    {
        public QueueNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }
        public QueueNode<T> Next { get; set; }
    }
}
