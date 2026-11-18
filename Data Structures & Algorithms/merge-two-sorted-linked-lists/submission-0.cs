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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {

        ListNode curr1 = list1;
        ListNode curr2 = list2;
        ListNode ans = new ListNode(0);
        ListNode ans_curr = ans;
        while(curr1 != null && curr2 != null){
            if(curr1.val < curr2.val){
                ans_curr.next = curr1;
                curr1 = curr1.next;
            }
            else{
                ans_curr.next = curr2;
                curr2 = curr2.next;
            }
            ans_curr = ans_curr.next;
           
        }
        if(curr1 != null){
            ans_curr.next = curr1;
        }
        else if(curr2 != null){
            ans_curr.next = curr2;
        }

        return ans.next;
    }
}