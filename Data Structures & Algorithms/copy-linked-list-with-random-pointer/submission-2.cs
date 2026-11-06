/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;
    
    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node copyRandomList(Node head) {
        Node c1 = head;
        List<Node> c2 = [];
        Dictionary<Node, int> d = new Dictionary<Node, int>();

        if(head == null) {return null;}

        int index = 0;
        while(c1 != null){
            d.Add(c1, index);
            c2.Add(new Node(c1.val));
            index++;
            c1 = c1.next;
        }

        c1 = head;
        for(int i=0; i<c2.Count; i++){
            c2[i].next = i+1 < c2.Count ? c2[i+1] : null;
            c2[i].random = c1.random == null ? null : c2[d[c1.random]];
            c1 = c1.next;
        }
        return c2[0];


    }
}
