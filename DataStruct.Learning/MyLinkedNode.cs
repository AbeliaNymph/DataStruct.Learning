


namespace DataStruct.Learning;

public class MyLinkedNode<T>(T value)
{
    public T Value { get; set; } = value;

    public MyLinkedNode<T>? Next { get; set; }

    public int Count {
        get {
            int acc = 1;

            for (MyLinkedNode<T> i = this; i.Next != null; i = i.Next)
            {
                acc += 1;
            }

            return acc;
        }
    }

    public override string ToString()
    {
        return $"Node({Value}) -> {(Next == null ? "None" : Next)}";
    }

    public void Append(T value)
    {
        MyLinkedNode<T> last = GetLastNode(this);
        last.Next = new(value);
    }

    private static MyLinkedNode<T> GetLastNode(MyLinkedNode<T> myLinkedNode)
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

    public void InsertBefore(int index, T value)
    {
        if (index == 0)
        {
            throw new InvalidOperationException();
        }

        if (index < 0 || index >= Count)
        {
            throw new IndexOutOfRangeException();
        }

        MyLinkedNode<T> after = GetNode(index);
        MyLinkedNode<T> before = GetNode(index - 1);

        MyLinkedNode<T> node = new(value);
        before.Next = node;
        node.Next = after;
    }

    private MyLinkedNode<T> GetNode(int index)
    {
        static MyLinkedNode<T> RecGetNode(MyLinkedNode<T> node, int index)
        {
            if (index == 0)
            {
                return node;
            }
            else
            {
                return RecGetNode(node.Next!, index - 1);
            }
        }

        return RecGetNode(this, index);
    }

    public void Delete(int index)
    {
        if (Count == 1)
        {
            throw new InvalidOperationException();
        }
        
        MyLinkedNode<T> before = GetNode(index - 1);
        MyLinkedNode<T>? after = index == Count - 1 ? null : GetNode(index + 1);

        before.Next = after;
        
    }
}
