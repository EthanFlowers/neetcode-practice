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
    public bool HasCycle(ListNode head) {
        ListNode curr_slow = head;
        ListNode curr_fast = head != null && head.next != null ? head.next.next : null;
        
        while(curr_slow != null && curr_fast != null && curr_fast.next != null){
            curr_slow = curr_slow.next;
            curr_fast = curr_fast.next.next;

            if(curr_slow == curr_fast){
                return true;
            }
        }

        return false;

    }
}
