using System.Collections;
using System.Security.Cryptography.X509Certificates;
/**
* Definition for singly-linked list.
* public class ListNode {
*     public int val;
*     public ListNode next;
*     public ListNode(int val=0, ListNode next=null) {
*         this.val = val;
*         this.next = next;
*     }
* }
*/
public class ReverseLinkedList
{
 /*   public LinkedListNode ReverseList(ListNode head)
    {
        
        return new LinkedListNode(null);
    }*/
}
public static class ReverseLinkedLists
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node(int value)
        {
            Value = value;
            Next = null; // next is initially null until linked to another node
        }
    }
    public class SinglyLinkedList
    {
        private Node head; //the head is a reference to the first node in the list

        public SinglyLinkedList()
        {
            head = null; //Initially, the list is empty, so head is null
        }
        public void Add(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null) //if next is not null, move to the next value
                {
                    current = current.Next;
                }
                current.Next = newNode; //because its null, the value will be the next node
            }
        }


        public static void ReverseListsOutput()
        {

        }
    }
}