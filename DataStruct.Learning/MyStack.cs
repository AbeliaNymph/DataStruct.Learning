using System.Text;

namespace DataStruct.Learning;

public class MyStack<T>
{
    private readonly List<T> _instance = [];

    private int? _topIndex = -1;

    public MyStack(T value)
    {   _topIndex += 1;
        _instance.Add(value);
    }

    public MyStack()
    {

    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new();

        foreach (T item in _instance)
        {
            stringBuilder.Append($"{item} ");
        }

        stringBuilder.Append(']');

        return stringBuilder.ToString();
    }

    public void Push(T value)
    {
        _topIndex += 1;
        _instance.Add(value);
    }
}
