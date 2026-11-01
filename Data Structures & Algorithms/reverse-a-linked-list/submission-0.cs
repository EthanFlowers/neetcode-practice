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
        Stack<ListNode> s = new Stack<ListNode>();
        if(head == null){
            return null;
        }
        ListNode cur = head;
        while(cur != null){
            s.Push(cur);
            cur = cur.next;
        }
        Console.WriteLine(s.Count);

        cur = s.Pop();
        Console.WriteLine(s.Count);

        ListNode ans = cur;
        while(s.Count > 0){

            ListNode a = s.Pop();
            cur.next = a;
            cur = a;
        }
        cur.next = null;        
        return ans;

        


    }
}
