using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms_Data_Structures.Data_Structures.LinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public Node() { }
        public Node(int data, Node nextNode) {
            Data = data;
            Next = nextNode;
        }
        public void DisplayNode()
        {
            Console.Write(Data + " -> ");
        }
    }
}
