using System;

namespace DotNetSnippets.DataStructures.Stack
{
    public class Stack <T>
    {
        public StackNode<T> Top { get; private set; }

        public void Push(T newValue)
        {
            if (newValue == null) throw new ArgumentException("Provided value cannot be null.");

            StackNode<T> newNode = new StackNode<T>(newValue);

            if (Top == null)
            {
                Top = newNode;
            }
            else
            {
                newNode.Next = Top;
                Top = newNode;
            }
        }

        public T Pop()
        {
            if (Top == null) return default(T);

            var currentTop = Top;

            Top = Top.Next;

            return currentTop.Value;
        }
    }
}
