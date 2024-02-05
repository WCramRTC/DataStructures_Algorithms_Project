using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructures_Algorithms_Project;

namespace DS_A_UnitTest
{
    [TestFixture]
    public class DoublyLinkedListTests
    {
        [Test]
        public void Constructor_EmptyList_IsEmpty()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            Assert.IsTrue(list.IsEmpty);
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void AddToFront_SingleItem_ListNotEmpty()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddToFront(5);
            Assert.IsFalse(list.IsEmpty);
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public void AddToFront_MultipleItems_InCorrectOrder()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.AddToFront("C");
            list.AddToFront("B");
            list.AddToFront("A");

            Assert.AreEqual("A", list.First);
            Assert.AreEqual("B", list[1]);
            Assert.AreEqual("C", list[2]);
        }

        [Test]
        public void AddToBack_SingleItem_ListNotEmpty()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddToBack(10);
            Assert.IsFalse(list.IsEmpty);
            Assert.AreEqual(1, list.Count);
        }

        [Test]
        public void AddToBack_MultipleItems_InCorrectOrder()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.AddToBack("A");
            list.AddToBack("B");
            list.AddToBack("C");

            Assert.AreEqual("A", list.First);
            Assert.AreEqual("B", list[1]);
            Assert.AreEqual("C", list[2]);
        }

        [Test]
        public void RemoveFirst_EmptyList_ThrowsException()
        {
            DoublyLinkedList<double> list = new DoublyLinkedList<double>();
            Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
        }

        [Test]
        public void RemoveFirst_SingleItem_ListIsEmpty()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddToFront(10);
            list.RemoveFirst();
            Assert.IsTrue(list.IsEmpty);
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void RemoveFirst_MultipleItems_CorrectItemRemoved()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddToFront(3);
            list.AddToFront(2);
            list.AddToFront(1);

            int removedItem = list.RemoveFirst();
            Assert.AreEqual(1, removedItem);
            Assert.AreEqual(2, list.First);
        }

        [Test]
        public void RemoveLast_EmptyList_ThrowsException()
        {
            DoublyLinkedList<char> list = new DoublyLinkedList<char>();
            Assert.Throws<InvalidOperationException>(() => list.RemoveLast());
        }

        [Test]
        public void RemoveLast_SingleItem_ListIsEmpty()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddToFront(10);
            list.RemoveLast();
            Assert.IsTrue(list.IsEmpty);
            Assert.AreEqual(0, list.Count);
        }

        [Test]
        public void RemoveLast_MultipleItems_CorrectItemRemoved()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddToFront(1);
            list.AddToFront(2);
            list.AddToFront(3);

            int removedItem = list.RemoveLast();
            Assert.AreEqual(1, removedItem);
            Assert.AreEqual(2, list.Last);
        }

        [Test]
        public void Contains_ExistingItem_ReturnsTrue()
        {
            DoublyLinkedList<string> list = new DoublyLinkedList<string>();
            list.AddToFront("Apple");
            list.AddToFront("Banana");
            list.AddToFront("Cherry");

            Assert.IsTrue(list.Contains("Banana"));
        }

        [Test]
        public void Contains_NonExistingItem_ReturnsFalse()
        {
            DoublyLinkedList<int> list = new DoublyLinkedList<int>();
            list.AddToFront(10);
            list.AddToFront(20);
            list.AddToFront(30);

            Assert.IsFalse(list.Contains(5));
        }

        [Test]
        public void Clear_ListNotEmpty_IsEmpty()
        {
            DoublyLinkedList<char> list = new DoublyLinkedList<char>();
            list.AddToFront('A');
            list.AddToFront('B');
            list.Clear();

            Assert.IsTrue(list.IsEmpty);
            Assert.AreEqual(0, list.Count);
        }
    }
}