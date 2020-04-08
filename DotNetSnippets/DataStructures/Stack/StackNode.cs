namespace DotNetSnippets.DataStructures.Stack
{
    public class StackNode<T>
    {
        public StackNode(T value)
        {
            this.Value = value;
        }

        public T Value { get; private set; }
        public StackNode<T> Next { get; set; }
    }
}
