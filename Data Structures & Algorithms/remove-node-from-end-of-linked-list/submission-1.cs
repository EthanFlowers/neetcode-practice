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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode curr = head;
        int length = 0;

        if(head.next == null && n == 1){
            return null;
        }
        while(curr != null){
            curr = curr.next;
            length++;
        }

        curr = head;
        for(int i=0; i<length-n-1; i++){
            curr = curr.next;
        }
        Console.WriteLine($"a {length-n-1}");
        if((length-n-1) < 0){
            head = curr.next;
        }
        else{
            curr.next = curr.next != null ? curr.next.next : null;
        }
        
        
        return head;

    }
}
