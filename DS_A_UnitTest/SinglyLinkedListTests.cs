using NUnit.Framework;
using System;
using DataStructures_Algorithms_Project;

namespace DS_A_UnitTest;

[TestFixture]
public class SinglyLinkedListTests
{
    [Test]
    public void Constructor_EmptyList_IsEmpty()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        Assert.IsTrue(list.IsEmpty);
        Assert.AreEqual(0, list.Count);
    }

    [Test]
    public void AddToFront_SingleItem_ListNotEmpty()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddToFront(5);
        Assert.IsFalse(list.IsEmpty);
        Assert.AreEqual(1, list.Count);
    }

    [Test]
    public void AddToFront_MultipleItems_InCorrectOrder()
    {
        SinglyLinkedList<string> list = new SinglyLinkedList<string>();
        list.AddToFront("C");
        list.AddToFront("B");
        list.AddToFront("A");

        Assert.AreEqual("A", list.First);
        Assert.AreEqual("B", list[1]);
        Assert.AreEqual("C", list[2]);
    }

    [Test]
    public void RemoveFirst_EmptyList_ThrowsException()
    {
        SinglyLinkedList<double> list = new SinglyLinkedList<double>();
        Assert.Throws<InvalidOperationException>(() => list.RemoveFirst());
    }

    [Test]
    public void RemoveFirst_SingleItem_ListIsEmpty()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddToFront(10);
        list.RemoveFirst();
        Assert.IsTrue(list.IsEmpty);
        Assert.AreEqual(0, list.Count);
    }

    [Test]
    public void RemoveFirst_MultipleItems_CorrectItemRemoved()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddToFront(3);
        list.AddToFront(2);
        list.AddToFront(1);

        int removedItem = list.RemoveFirst();
        Assert.AreEqual(1, removedItem);
        Assert.AreEqual(2, list.First);
    }

    [Test]
    public void Contains_ExistingItem_ReturnsTrue()
    {
        SinglyLinkedList<string> list = new SinglyLinkedList<string>();
        list.AddToFront("Apple");
        list.AddToFront("Banana");
        list.AddToFront("Cherry");

        Assert.IsTrue(list.Contains("Banana"));
    }

    [Test]
    public void Contains_NonExistingItem_ReturnsFalse()
    {
        SinglyLinkedList<int> list = new SinglyLinkedList<int>();
        list.AddToFront(10);
        list.AddToFront(20);
        list.AddToFront(30);

        Assert.IsFalse(list.Contains(5));
    }

    [Test]
    public void Clear_ListNotEmpty_IsEmpty()
    {
        SinglyLinkedList<char> list = new SinglyLinkedList<char>();
        list.AddToFront('A');
        list.AddToFront('B');
        list.Clear();

        Assert.IsTrue(list.IsEmpty);
        Assert.AreEqual(0, list.Count);
    }
}
