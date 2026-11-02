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
    public bool IsBalanced(TreeNode root) {
        return geth(root) == -1 ? false : true;
    }
    int geth(TreeNode root){
        if(root == null) {
            return 0;
        }
        int l = geth(root.left);
        if(l == -1) return -1;
        int r = geth(root.right);
        if(r == -1) return -1;
        return Math.Abs(r-l) <= 1 ? Math.Max(l, r)+1 : -1;
    }

}
