using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures_Algorithms_Project
{
    public class MyStack<T> : IEnumerable<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
            }
        }

        private Node top;

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public MyStack()
        {
            top = null;
            Count = 0;
        }

        public void Push(T data)
        {
            // Placeholder code for Push method
            throw new NotImplementedException();
        }

        public T Pop()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            // Placeholder code for Pop method
            throw new NotImplementedException();
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Stack is empty");

            // Placeholder code for Peek method
            throw new NotImplementedException();
        }

        public void Clear()
        {
            // Placeholder code for Clear method
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node current = top;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
