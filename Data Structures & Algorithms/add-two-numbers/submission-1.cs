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
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode c1 = l1;
        ListNode c2 = l2;
        ListNode ans = new ListNode(0);
        ListNode ans_curr = ans;
        ListNode a = null;
        int r = 0;
        
        while(c1 != null || c2 != null){
            //Console.WriteLine($"c1 {c1.val} c2 {c2.val} r {r}");
            if(c1 == null){
                a = new ListNode( (c2.val + r) % 10);
                r = (c2.val + r) / 10; 
                c2 = c2.next;
            }
            else if(c2 == null){
                a= new ListNode( (c1.val + r) % 10 );
                r = (c1.val + r) / 10; 
                c1 = c1.next;

            }
            else{
                a= new ListNode( (c1.val + c2.val + r) % 10);
                r = (c1.val + c2.val) / 10; 
                c2 = c2.next;
                c1 = c1.next;
            }
            ans_curr.next = a;
            ans_curr = ans_curr.next;

        }
        if(r > 0){
            ans_curr.next = new ListNode(r);

        }
        return ans.next;
    }
}
