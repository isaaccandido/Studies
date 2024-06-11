namespace Studies.DataStructures.SinglyLinkedList;

public class SinglyLinkedListNode(int data)
{
    public int Data { get; set; } = data;
    public SinglyLinkedListNode? Next { get; set; } = null;
}
