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
}
