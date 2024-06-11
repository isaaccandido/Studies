using Studies.DataStructures.SinglyLinkedList;

public class SinglyLinkedListImplementation
{
    private SinglyLinkedListNode? _head = null;

    public void Add(int data)
    {
        var newNode = new SinglyLinkedListNode(data);

        if (_head == null)
        {
            _head = newNode;
            return;
        }
        else
        {
            var current = _head;

            while (current.Next != null) current = current.Next;

            current.Next = newNode;
        }
    }

    public void Remove(int data)
    {
        if (_head == null) return;

        if (_head.Data == data) _head = _head.Next;

        var current = _head;

        while (current != null && current.Next != null && current.Next.Data != data) current = current.Next;

        if (current != null && current.Next != null) current.Next = current.Next.Next;
    }

    public SinglyLinkedListNode? Find(int data)
    {
        if (_head != null && _head.Data == data) return _head;

        var current = _head;

        while (current != null && current.Next != null)
        {
            if (current.Data == data) return current;
            current = current.Next;
        }

        return null;
    }

    public void Print()
    {
        var current = _head;

        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }

        Console.WriteLine("End");
    }

    public void Clear()
    {
        _head = null;
    }
}

