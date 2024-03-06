namespace DataStruct.Learning;

public class MyLinkedNode<T>(T value)
{
    public T Value { get; set; } = value;

    public MyLinkedNode<T>? Next { get; set; }
}
