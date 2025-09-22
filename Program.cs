using LinkedList;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Singly Linked List

        Console.WriteLine("Singly Linked List Operations:");
        var linkedList = new MyLinkedList<int>();

        linkedList.Add(10);
        linkedList.Add(20);
        linkedList.Add(30);
        linkedList.Add(40);

        Console.WriteLine("Initial List:");
        linkedList.Print();

        Console.WriteLine("Adding 50 at the beginning:");
        linkedList.AddAtTheBegining(linkedList.Head, 50);
        linkedList.Print();

        Console.WriteLine("Reversing the list:");
        linkedList.Reverse(linkedList.Head);
        linkedList.Print();

        Console.WriteLine("Has Cycle testing...");
        Console.WriteLine("Has Cycle:" + linkedList.HasCycle(linkedList.Head).ToString());

        Console.WriteLine("Deleting node with value 20:");
        linkedList.DeleteNode(linkedList.Head, 20);
        linkedList.Print();

        Console.WriteLine("Serach for 30:" + linkedList.SerachForValue(linkedList.Head, 30));

        var middle = linkedList.FindMiddle(linkedList.Head);
        Console.WriteLine("Middle Node:" + (middle != null ? middle.Data.ToString() : "null"));

        Console.WriteLine("Singly Linked List - End");

        #endregion

        #region Doubly Linked List

        Console.WriteLine("\nDoubly Linked List Operations:");
        var list = new MyDoublyLinkedList<int>();

        list.AddAtTheEnd(list.GetHead(), 11);
        list.AddAtTheEnd(list.GetHead(), 12);
        list.AddAtTheEnd(list.GetHead(), 13);

        Console.WriteLine("Initial Doubly Linked List:");
        list.TraverseForward(list.GetHead());

        Console.WriteLine("Traverse Backward from Head:");
        list.TraverseBackward(list.GetHead());

        Console.WriteLine("Traverse Backward from Tail:");
        list.TraverseBackwardWithTail(list.GetTail());

        Console.WriteLine("Adding nodes at the beginning:");
        list.AddAtTheBeginning(list.GetHead(), 10);
        list.AddAtTheBeginning(list.GetHead(), 9);
        list.AddAtTheBeginning(list.GetHead(), 8);

        list.TraverseForward(list.GetHead());

        Console.ReadLine();

        #endregion

    }
}