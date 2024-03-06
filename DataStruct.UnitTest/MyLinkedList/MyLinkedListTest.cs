using System.Text;
using DataStruct.Learning;

namespace DataStruct.UnitTest;

[TestClass]
public class MyLinkedListTest
{

    [TestMethod]
    public void OneTwoThree_Append_OneConnectTwoConnectThreeConnectNull()
    {
        MyLinkedList<int> ll = new();

        ll.Append(1);
        ll.Append(2);
        ll.Append(3);

        string expected = "Root -> Node(1) -> Node(2) -> Node(3) -> Null";

        Assert.AreEqual(expected, ll.ToString());

    }

    [TestMethod]
    public void NoElement_ToString_isEmptyNode()
    {
        MyLinkedList<int> ll = new();

        Assert.AreEqual("Root -> Null", ll.ToString());
    }
}
