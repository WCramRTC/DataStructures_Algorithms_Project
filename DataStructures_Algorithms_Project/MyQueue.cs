using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructures_Algorithms_Project
{
    public class MyQueue<T> : IEnumerable<T>
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

        private Node head;
        private Node tail;

        public int Count { get; private set; }

        public bool IsEmpty => Count == 0;

        public MyQueue()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public void Enqueue(T data)
        {
            // Placeholder code for Enqueue method
            throw new NotImplementedException();
        }

        public T Dequeue()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Queue is empty");

            // Placeholder code for Dequeue method
            throw new NotImplementedException();
        }

        public T Peek()
        {
            if (IsEmpty)
                throw new InvalidOperationException("Queue is empty");

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
            Node current = head;
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
