using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures_Algorithms_Project;

namespace DS_A_UnitTest
{
    [TestFixture]
    public class MyQueueTests
    {
        [Test]
        public void Enqueue_EnqueueSingleItem_CountIsOne()
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(42);

            Assert.AreEqual(1, queue.Count);
        }

        [Test]
        public void Enqueue_EnqueueMultipleItems_CountIsCorrect()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");

            Assert.AreEqual(3, queue.Count);
        }

        [Test]
        public void Dequeue_DequeueEmptyQueue_ThrowsException()
        {
            MyQueue<int> queue = new MyQueue<int>();

            Assert.Throws<InvalidOperationException>(() => queue.Dequeue());
        }

        [Test]
        public void Dequeue_DequeueSingleItem_CountIsZero()
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(10);
            int result = queue.Dequeue();

            Assert.AreEqual(0, queue.Count);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Dequeue_DequeueMultipleItems_OrderIsCorrect()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            string firstItem = queue.Dequeue();
            string secondItem = queue.Dequeue();
            string thirdItem = queue.Dequeue();

            Assert.AreEqual("First", firstItem);
            Assert.AreEqual("Second", secondItem);
            Assert.AreEqual("Third", thirdItem);
        }

        [Test]
        public void Peek_PeekEmptyQueue_ThrowsException()
        {
            MyQueue<int> queue = new MyQueue<int>();

            Assert.Throws<InvalidOperationException>(() => queue.Peek());
        }

        [Test]
        public void Peek_PeekSingleItem_CountIsUnchanged()
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(20);
            int result = queue.Peek();

            Assert.AreEqual(1, queue.Count);
            Assert.AreEqual(20, result);
        }

        [Test]
        public void Peek_PeekMultipleItems_OrderIsCorrect()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("A");
            queue.Enqueue("B");
            queue.Enqueue("C");

            string peekedItem = queue.Peek();

            Assert.AreEqual(3, queue.Count);
            Assert.AreEqual("A", peekedItem);
        }

        [Test]
        public void IsEmpty_EmptyQueue_IsEmptyReturnsTrue()
        {
            MyQueue<int> queue = new MyQueue<int>();

            Assert.IsTrue(queue.IsEmpty);
        }

        [Test]
        public void IsEmpty_NonEmptyQueue_IsEmptyReturnsFalse()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("X");

            Assert.IsFalse(queue.IsEmpty);
        }

        [Test]
        public void Clear_NonEmptyQueue_IsEmptyReturnsTrue()
        {
            MyQueue<int> queue = new MyQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Clear();

            Assert.IsTrue(queue.IsEmpty);
            Assert.AreEqual(0, queue.Count);
        }


        [Test]
        public void GetEnumerator_EnumerateQueueUsingForeach_OrderIsCorrect()
        {
            MyQueue<string> queue = new MyQueue<string>();
            queue.Enqueue("First");
            queue.Enqueue("Second");
            queue.Enqueue("Third");

            List<string> result = new List<string>();
            foreach (var item in queue)
            {
                result.Add(item);
            }

            CollectionAssert.AreEqual(new[] { "First", "Second", "Third" }, result);
        }
    }

}