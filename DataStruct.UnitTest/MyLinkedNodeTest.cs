using DataStruct.Learning;

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
}
