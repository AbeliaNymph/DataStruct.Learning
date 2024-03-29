﻿using DataStruct.Learning;

namespace DataStruct.UnitTest;

[TestClass]
public class MyLinkedNodeTest
{
    [TestMethod]
    public void OneElementLinkedList_ToString_DisplayOneElement()
    {
        MyLinkedNode<int> obtained = new(1);

        string expected = "Node(1) -> None";

        Assert.AreEqual(expected, obtained.ToString());
    }

    [TestMethod]
    public void OneAndTwoElementLinkedList_Append_OneTwoThree()
    {
        MyLinkedNode<int> obtained = new(1);

        obtained.Append(2);

        string expected = "Node(1) -> Node(2) -> None";

        Assert.AreEqual(expected, obtained.ToString());
    }

    [TestMethod]
    public void RangeOneToThreeElementLinkedList_Append_RangeOneToFour()
    {
        MyLinkedNode<int> obtained = new(1);

        obtained.Append(2);
        obtained.Append(3);
        obtained.Append(4);

        string expected = "Node(1) -> Node(2) -> Node(3) -> Node(4) -> None";

        Assert.AreEqual(expected, obtained.ToString());
    }

    [TestMethod]
    public void OneElement_InsertBefore_ThrowInvalidOperationException()
    {
        MyLinkedNode<int> obtained = new(1);
        Assert.ThrowsException<InvalidOperationException>(() => obtained.InsertBefore(0, 2));
    }

    [TestMethod]
    public void OneAndTwoElement_InsertBefore_OneValueAndTwo()
    {
        MyLinkedNode<int> obtained = new(1);
        obtained.Append(2);

        obtained.InsertBefore(1, 3);

        string expected = "Node(1) -> Node(3) -> Node(2) -> None";

        Assert.AreEqual(expected, obtained.ToString());
    }

    [TestMethod]
    public void RangeOneToThree_InsertBefore_OneTwoFourThree()
    {
        MyLinkedNode<int> obtained = new(1);
        obtained.Append(2);
        obtained.Append(3);

        obtained.InsertBefore(2, 4);

        string expected = "Node(1) -> Node(2) -> Node(4) -> Node(3) -> None";

        Assert.AreEqual(expected, obtained.ToString());
    }

    [TestMethod]
    public void OneElemant_Detele_ThrowInvalidOperationException()
    {
        MyLinkedNode<int> obtained = new(1);

        Assert.ThrowsException<InvalidOperationException>(() => obtained.Delete(0));
    }

    [TestMethod]
    public void TwoElement_Delete_OneElement()
    {
        MyLinkedNode<int> obtained = new(1);

        obtained.Append(2);

        obtained.Delete(1);

        string expected = "Node(1) -> None";

        Assert.AreEqual(expected, obtained.ToString());
    }

    [TestMethod]
    public void ThreeElement_Delete_TwoElement()
    {
        MyLinkedNode<int> obtained = new(1);

        obtained.Append(2);
        obtained.Append(3);

        obtained.Delete(1);

        string expected = "Node(1) -> Node(3) -> None";

        Assert.AreEqual(expected, obtained.ToString());
        
    }
}
