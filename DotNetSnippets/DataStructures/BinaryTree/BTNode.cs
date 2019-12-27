namespace DotNetSnippets.DataStructures.BinaryTree
{
    public class BTNode<T>
    {
        public T Value;
        public BTNode<T> Left;
        public BTNode<T> Right;

        public BTNode(T value)
        {
            this.Value = value;
            this.Left = null;
            this.Right = null;
        }
    }
}
