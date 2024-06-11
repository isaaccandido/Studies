namespace Studies.DataStructures.DoublyLinkedList;

public class DoublyLinkedListImplementation
{
    private DoublyLinkedListNode? _head = null;
    private DoublyLinkedListNode? _tail = null;

    public void Add(int data)
    {
        var newNode = new DoublyLinkedListNode(data);

        if (_head == null)
        {
            _head = newNode;
            _tail = newNode;
        }
        else
        {
            _tail.Next = newNode;
            newNode.Previous = _tail;
            _tail = newNode;
        }
    }

    public void Remove(int data)
    {
        if (_head == null) return;

        var current = _head;
        while (current != null && current.Data != data)
        {
            current = current.Next;
        }

        if (current != null)
        {
            if (current.Previous != null)
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                _head = current.Next;
            }

            if (current.Next != null)
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                _tail = current.Previous;
            }
        }
    }

    public DoublyLinkedListNode? Find(int data)
    {
        var current = _head;
        while (current != null)
        {
            if (current.Data == data)
            {
                return current;
            }
            current = current.Next;
        }
        return null;
    }

    public void PrintForward()
    {
        var current = _head;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Next;
        }
        Console.WriteLine("null");
    }

    public void PrintBackward()
    {
        var current = _tail;
        while (current != null)
        {
            Console.Write(current.Data + " -> ");
            current = current.Previous;
        }
        Console.WriteLine("null");
    }
}