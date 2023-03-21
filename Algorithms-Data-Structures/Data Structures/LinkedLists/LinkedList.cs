using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Structures.Data_Structures.LinkedList
{
    public class LinkedList
    {
        public Node? First { get; set; }

        //Insert - O(1)
        public void InsertFirst(int data)
        {
            Node newFirst = new Node(data, First);
            First = newFirst;
        }

        // Delete - O(1)
        public Node DeleteFirst()
        {
            Node oldFirst = First;
            First = First.Next;
            oldFirst.Next = null;
            return oldFirst;
        }

        // Iterate - O(n)
        public void DisplayList()
        {
            Node next = First;
            while (next != null)
            {
                next.DisplayNode();
                next = next.Next;
            }
            Console.WriteLine();
        }

        // Insert at the end - O(n)
        public void InsertLast(int data)
        {
            Node current = First;
            while(current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node(data, null);
            current.Next = newNode;
        }

        // Delete at the end - O(n)
        public Node DeleteLast()
        {
            Node current = First;
            while(current.Next?.Next != null)
            {
                current = current.Next;
            }
            Node oldLast = current.Next;
            current.Next = null;
            return oldLast;
        }
    }
}
