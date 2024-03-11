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
        
    }
}
