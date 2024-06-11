namespace Studies.DataStructures.DoublyLinkedList;

public class DoublyLinkedListNode(int data)
{
    public int Data { get; set; } = data;
    public DoublyLinkedListNode? Previous { get; set; } = null;
    public DoublyLinkedListNode? Next { get; set; } = null;
}
