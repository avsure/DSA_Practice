using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class MyLinkedList<T>
    {
        public Node<T> Head { get; set; }

        public MyLinkedList()
        {
            Head = null;
        }

        // Add a node at the end
        public void Add(T data)
        {
            Node<T> newNode = new Node<T>(data);

            if (Head == null) // if list is empty
            {
                Head = newNode;
            }
            else
            {
                Node<T> current = Head;
                while (current.Next != null) // traverse to the last node
                {
                    current = current.Next;
                }
                current.Next = newNode; // link new node
            }
        }


        // Display the list
        public void Print()
        {
            Node<T> current = Head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        public Node<T> AddAtTheBegining(Node<T> head, T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (head == null)
            {
                head = newNode;
                Head = head;
                return head;
            }
            newNode.Next = head;
            Head = newNode;
            return newNode;
        }

        public Node<T> DeleteNode(Node<T> head,T key)
        {
            if (head == null) return null;

            if (head.Data.Equals(key))
                return head.Next;  
          
            Node<T> current = head;
            while(current.Next != null && !current.Next.Data.Equals(key))
            {
                current = current.Next;
            }
            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
            return head;
        }

        public bool SerachForValue(Node<T> head, T key)
        {
            if (head == null) return false;
            if (head.Data.Equals(key)) return true;
            Node<T> current = head;
            while (current != null && !current.Data.Equals(key))
            {
                current = current.Next;
            }
            return current != null;
        } 

        public Node<T> Reverse(Node<T> head)
        { 
            Node<T> prev = null;
            Node<T> current = head;
            Node<T> next = null;

            while (current != null)
            {
                next = current.Next; // store next node
                current.Next = prev; // reverse the link
                prev = current;      // move prev to current
                current = next;      // move to next node
            }
            Head = prev;
            return prev; // new head of the reversed list
        }

        public Node<T> FindMiddle(Node<T> head)
        {
            if (head == null) return null;
            Node<T> slow = head;
            Node<T> fast = head;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;       // move slow by 1
                fast = fast.Next.Next;  // move fast by 2
            }
            return slow; // slow is now at the middle
        }

        public bool HasCycle(Node<T> head)
        {
            if (head == null) return false;

            Node<T> slow = head;
            Node<T> fast = head;
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;       // move slow by 1
                fast = fast.Next.Next;  // move fast by 2
                if (slow == fast) // cycle detected
                {
                    return true;
                }
            }
            return false; // no cycle
        }
    }
}

