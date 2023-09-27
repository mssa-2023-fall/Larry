using System;
using System.IO;
using System.Numerics;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace Debugger
{   /*
    public class Program
    {
        static void Main(string[] args)
        {
            var someNode = new BinaryTreeClass();
            
        }
    }*/
    class Node
    {
        public int desiredValue { get; set; }
        public Node leftChild { get; set; }
        public Node rightChild { get; set; }
        
        public Node(int newValue)
        {
            desiredValue = newValue;

        }
    }
    // Define a BinaryTree Class:
    // Implement a BinaryTree class with a root node property and methods for inserting nodes and printing the tree.
    
    public class BinaryTreeClass
    {
         Node startNode { get; set; }

        public BinaryTreeClass()
        {
            startNode = null;
        }




        public void Insert(int storeValue)
        {
            Node begin = new Node(storeValue);

            if (startNode == null) { startNode = begin; return; }
        }




        public void Solve()
        {
            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(startNode);

            bool[] visited = new bool[100];
            
            while( queue.Count > 0 )
            {
                start
            }
        }
        

    }

}































///Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. 
///The order of the elements may be changed. 
///Then return the number of elements in nums which are not equal to val.
///Consider the number of elements in nums which are not equal to val be k,
///to get accepted, you need to do the following things:
///Change the array nums such that the first k elements of nums contain the elements which are not equal to val. 
///The remaining elements of nums are not important as well as the size of nums.
///Return k.