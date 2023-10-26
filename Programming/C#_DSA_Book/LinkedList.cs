using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DSA_Book
{

    //Create a Node Class first
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public class LinkedList
    {
        public Node Head { get; private set; }

        // Add a new node with the given data to the end of the list
        public void Add(int data)
        {
            var newNode = new Node(data);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                var current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void Print()
        {
            var current = Head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }

    //Printing the linkedList

}