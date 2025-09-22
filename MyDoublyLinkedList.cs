namespace LinkedList
{
    public class MyDoublyLinkedList<T>
    {
        public DoublyNode<T> Head {  get; set; }
        public MyDoublyLinkedList()
        {
            Head = null;
        }

        public void AddAtTheEnd(DoublyNode<T> head,T item)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(item);

            if(head == null)
            {
                head = newNode;
                Head = head;
                return;
            }

            DoublyNode<T> current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
            newNode.Prev = current;
            Head = head;
        }

        public DoublyNode<T> AddAtTheBeginning(DoublyNode<T> head, T data)
        {
            DoublyNode<T> newNode = new DoublyNode<T>(data);
            if (head == null)
            {
                head = newNode;
                Head = head;
                return head;
            }
            
            newNode.Next = head;
            head.Prev = newNode;
            Head = newNode;
            return newNode;
        }

        public void TraverseForward(DoublyNode<T> head)
        {
            if(Head == null) return;

            DoublyNode<T> current = head;
            while (current != null)
            {
                Console.Write(current.Data + " <-> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public void TraverseBackward(DoublyNode<T> head)
        {
            if (head == null) return;

            DoublyNode <T> current = head;
            while(current.Next != null)
            { 
                current = current.Next;
            }
           
            while (current != null)
            {
                Console.Write(current.Data + " <-> ");
                current = current.Prev;
            }
            Console.WriteLine("null");
        }

        public void TraverseBackwardWithTail(DoublyNode<T> tail)
        {
            DoublyNode<T> current = tail;
            while (current != null)
            {
                Console.Write(current.Data + " <-> ");
                current = current.Prev;
            }
            Console.WriteLine("null");
        }

        public void DeleteNode(DoublyNode<T> head,T key)
        {
            if(head == null) return;

            DoublyNode<T> current = head;
            while (current != null && !current.Data.Equals(key))
            {
                current = current.Next;
            }
            if (current == null) return; // Key not found

            if (current.Prev == null)
            {
                head = current.Next; // Move head if needed
                if (head != null)
                {
                    head.Prev = null;
                }   
            }
            else
            {
                current.Prev.Next = current.Next;
                if (current.Next != null)
                {
                    current.Next.Prev = current.Prev;
                }
            }
            Head = head;
        }

        public DoublyNode<T> GetTail()
        {
            DoublyNode<T> current = Head;
            if (Head == null) return null;

            while (current.Next != null)
            {
                current = current.Next;
            }
            return current;
        }

        public DoublyNode<T> GetHead()
        {
            return Head;
        }

    }
}
