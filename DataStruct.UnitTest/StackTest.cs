using DataStruct.Learning;

namespace DataStruct.UnitTest;

[TestClass]
public class StackTest
{

    [TestMethod]
    public void EmptyStack_Create_IsEmpty()
    {
        MyStack<int> obtained = new();

        string expected = "]";

        Assert.AreEqual(expected, obtained.ToString());

    }

    [TestMethod]
    public void OneElement_ToString_IsOneElement()
    {
        MyStack<int> obtained = new(1);

        string expected = "1 ]";

        Assert.AreEqual(expected, obtained.ToString());
    }

    [TestMethod]
    public void EmptyElement_Push_OneElement()
    {
        MyStack<int> obtained = new();

        obtained.Push(1);

        string expected = "1 ]";

        Assert.AreEqual(expected, obtained.ToString());
    }

    [TestMethod]
    public void EmptyElement_Pop_ThrowInvalidOperationException()
    {
        MyStack<int> obtained = new();

        Assert.ThrowsException<InvalidOperationException>(() => obtained.Pop());
    }

    [TestMethod]
    public void OneElement_Pop_ReturnThisElement()
    {
        MyStack<int> obtained = new();

        obtained.Push(1);

        Assert.AreEqual(1, obtained.Pop());
        Assert.AreEqual("]", obtained.ToString());
    }

    
}
