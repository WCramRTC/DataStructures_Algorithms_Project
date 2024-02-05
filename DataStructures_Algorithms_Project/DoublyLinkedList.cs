using System;

namespace DataStructures_Algorithms_Project
{
    public class DoublyLinkedList<T>
    {
        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }
            public Node Previous { get; set; }

            public Node(T data)
            {
                Data = data;
                Next = null;
                Previous = null;
            }
        }

        private Node head;
        private Node tail;

        public int Count { get; private set; }

        public DoublyLinkedList()
        {
            head = null;
            tail = null;
            Count = 0;
        }

        public bool IsEmpty => Count == 0;

        public T First
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException("List is empty");
                // Placeholder code for First property
                throw new NotImplementedException();
            }
        }

        public T Last
        {
            get
            {
                if (IsEmpty)
                    throw new InvalidOperationException("List is empty");
                // Placeholder code for Last property
                throw new NotImplementedException();
            }
        }

        public void AddToFront(T data)
        {
            // Placeholder code for AddToFront method
            throw new NotImplementedException();
        }

        public void AddToBack(T data)
        {
            // Placeholder code for AddToBack method
            throw new NotImplementedException();
        }

        public T RemoveFirst()
        {
            if (IsEmpty)
                throw new InvalidOperationException("List is empty");
            // Placeholder code for RemoveFirst method
            throw new NotImplementedException();
        }

        public T RemoveLast()
        {
            if (IsEmpty)
                throw new InvalidOperationException("List is empty");
            // Placeholder code for RemoveLast method
            throw new NotImplementedException();
        }

        public bool Contains(T data)
        {
            // Placeholder code for Contains method
            throw new NotImplementedException();
        }

        public void Clear()
        {
            // Placeholder code for Clear method
            throw new NotImplementedException();
        }

        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= Count)
                    throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range");
                // Placeholder code for indexer
                throw new NotImplementedException();
            }
        }
    }
}
