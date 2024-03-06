
namespace DataStruct.Learning;

public class MyLinkedList<T>
{
    private Node<T>? _root;


    public void Append(T value)
    {
        

        static Node<T> GetLast(Node<T> root)
        {
            if (root.Next != null)
            {
                return GetLast(root.Next);
            }
            else
            {
                return root;
            }
        }

        Node<T> currentNode = new(value);

        if (_root == null)
        {
            _root = currentNode;
        }
        else 
        {
            Node<T> lastNode = GetLast(_root);
            lastNode.Next = currentNode;
        }
    }

    public override string ToString()
    {
        string rootDescription = _root == null ? "Null" : _root.ToString();
        
        return "Root -> " + rootDescription;
    }
}

class Node<T>(T value)
{
    public T Value { get; set; } = value;

    public Node<T>? Next { get; set; }

    public override string ToString()
    {
        string nextDescription = Next == null ? "Null" : Next.ToString();

        return $"Node({Value}) -> {nextDescription}";
    }
}
