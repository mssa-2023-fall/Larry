namespace LeetCode_Debugger { }
/*{
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
  
    public class Solution
    {
        public class Solution
        {
            public ListNode MergeTwoLists(ListNode list1, ListNode list2)
            {
                ListNode resultNode = new ListNode();
                ListNode temp = resultNode;

                while (list1 != null || list2 != null)
                {
                    if(list1.val > list2.val)
                    {
                        resultNode.next = list2;
                        list2 = list2.next;
                    }
                    else
                    {
                        resultNode.next = list1;
                        list1 = list1.next;
                    }
                    if(list1 != null)
                    {
                        resultNode.next = list1;
                    }
                    else 
                    {
                        resultNode.next = list2;
                    }

                }
                return temp.next;
            }
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
 



/*
You are given the heads of two sorted linked lists list1 and list2.

Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.

Return the head of the merged linked list.

Input: list1 = [1,2,4], list2 = [1,3,4]
Output: [1,1,2,3,4,4]
*/

/*
 * 1->2->4
 * 1->3->4
 * 1->1->2->3->
 * 
 * 
 * 
 * 
 * 
 */
