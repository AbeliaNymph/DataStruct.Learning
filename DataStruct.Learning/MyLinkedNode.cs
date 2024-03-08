

namespace DataStruct.Learning;

public class MyLinkedNode<T>(T value)
{
    public T Value { get; set; } = value;

    public MyLinkedNode<T>? Next { get; set; }

    public override string ToString()
    {
        return $"Node({Value}) -> {(Next == null ? "None" : Next)}";
    }

    public void Append(T value)
    {
        MyLinkedNode<T> last = GetLastNode(this);
        last.Next = new(value);
    }

    private MyLinkedNode<T> GetLastNode(MyLinkedNode<T> myLinkedNode)
    {
        if (myLinkedNode.HasNext())
        {
            return GetLastNode(myLinkedNode.Next!);
        }

        return myLinkedNode;
    }

    private bool HasNext()
    {
        return Next != null;
    }
}
