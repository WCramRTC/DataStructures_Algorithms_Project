using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures_Algorithms_Project;

namespace DS_A_UnitTest
{
    [TestFixture]
    public class MyStackTests
    {
        [Test]
        public void Push_PushSingleItem_CountIsOne()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(42);

            Assert.AreEqual(1, stack.Count);
        }

        [Test]
        public void Push_PushMultipleItems_CountIsCorrect()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");

            Assert.AreEqual(3, stack.Count);
        }

        [Test]
        public void Pop_PopEmptyStack_ThrowsException()
        {
            MyStack<int> stack = new MyStack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Pop());
        }

        [Test]
        public void Pop_PopSingleItem_CountIsZero()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(10);
            int result = stack.Pop();

            Assert.AreEqual(0, stack.Count);
            Assert.AreEqual(10, result);
        }

        [Test]
        public void Pop_PopMultipleItems_OrderIsCorrect()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            string thirdItem = stack.Pop();
            string secondItem = stack.Pop();
            string firstItem = stack.Pop();

            Assert.AreEqual("Third", thirdItem);
            Assert.AreEqual("Second", secondItem);
            Assert.AreEqual("First", firstItem);
        }

        [Test]
        public void Peek_PeekEmptyStack_ThrowsException()
        {
            MyStack<int> stack = new MyStack<int>();

            Assert.Throws<InvalidOperationException>(() => stack.Peek());
        }

        [Test]
        public void Peek_PeekSingleItem_CountIsUnchanged()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(20);
            int result = stack.Peek();

            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(20, result);
        }

        [Test]
        public void Peek_PeekMultipleItems_OrderIsCorrect()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");

            string peekedItem = stack.Peek();

            Assert.AreEqual(3, stack.Count);
            Assert.AreEqual("C", peekedItem);
        }

        [Test]
        public void IsEmpty_EmptyStack_IsEmptyReturnsTrue()
        {
            MyStack<int> stack = new MyStack<int>();

            Assert.IsTrue(stack.IsEmpty);
        }

        [Test]
        public void IsEmpty_NonEmptyStack_IsEmptyReturnsFalse()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("X");

            Assert.IsFalse(stack.IsEmpty);
        }

        [Test]
        public void Clear_NonEmptyStack_IsEmptyReturnsTrue()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Clear();

            Assert.IsTrue(stack.IsEmpty);
            Assert.AreEqual(0, stack.Count);
        }

        [Test]
        public void GetEnumerator_EnumerateStackUsingForeach_OrderIsCorrect()
        {
            MyStack<string> stack = new MyStack<string>();
            stack.Push("First");
            stack.Push("Second");
            stack.Push("Third");

            List<string> result = new List<string>();
            foreach (var item in stack)
            {
                result.Add(item);
            }

            CollectionAssert.AreEqual(new[] { "Third", "Second", "First" }, result);
        }
    }
}
