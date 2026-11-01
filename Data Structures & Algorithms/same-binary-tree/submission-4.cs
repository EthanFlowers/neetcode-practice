/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsSameTree(TreeNode p, TreeNode p1) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        Queue<TreeNode> q1 = new Queue<TreeNode>();

        if(p1 == null && p == null){
            return true;
        }
        else if((p1 == null && p != null) || (p1 != null && p == null)){
            return false;
        }

        q.Enqueue(p);
        q1.Enqueue(p1);

        while(q.Count > 0 && q1.Count > 0){
            TreeNode c = q.Dequeue();
            TreeNode c1 = q1.Dequeue();

            if(c.val != c1.val || 
            (c.left == null && c1.left != null) ||  
            (c.left != null && c1.left == null) || 
            (c.right != null && c1.right == null) ||
            (c.right == null && c1.right != null)) {
                return false;
            }

            if(c.left != null){q.Enqueue(c.left);}
            if(c.right != null){q.Enqueue(c.right);}
            if(c1.left != null){q1.Enqueue(c1.left);}
            if(c1.right != null){q1.Enqueue(c1.right);}
        }
        if(q.Count != q1.Count){
            return false;
        }

        return true;
    }
}
