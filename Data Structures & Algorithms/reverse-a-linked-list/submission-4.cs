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

public class Solution {
    public ListNode ReverseList(ListNode head) {
        ListNode curr = head;
        ListNode tmp = null;
        ListNode prev = null;
        if(head == null){
            return null;
        }
        else if(head.next == null){
            return head;
        }
        while(curr.next != null){
            tmp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = tmp;
           
        }
        curr.next = prev;
        return curr;
    }
    //a - > b
    //a <- b
    // a -> b -> c
    // a <- b <- c
}
