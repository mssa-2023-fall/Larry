using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn_LinkedList
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Creating a linkedList
            LinkedList<string> empList = new LinkedList<string>();

            //Add elements in the list
            empList.AddFirst("Rocky");
            empList.AddFirst("Mukesh");
            empList.AddFirst("John");
            empList.AddLast("Smith");
            empList.AddLast("James");

            //Display elements from the list
            Console.WriteLine("Employee Name: ");
            foreach (string str in empList)
            {
                Console.WriteLine(str);
            }


        }
    }
    //Creating a LinkedList class
    public class LinkedList
    {
        private class Node
        {
            public int Data {get; set;}
            public Node Next {get;set;}

            public Node(int data)
            {
                Data = data;
                Next = null;
            }         
        }
    }
    
    private Node head;
    
    public LinkedList()
    {
        
    }
















}