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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);
        while (s.Count > 0) {
            TreeNode curr = s.Pop();
            int l_target = Math.Min(p.val, q.val);
            int r_target = Math.Max(p.val, q.val);

            if (l_target <= curr.val && curr.val <= r_target) {
                return curr;
            } else if (curr.val > l_target) {
                s.Push(curr.left);
            } else if (curr.val < r_target)
                s.Push(curr.right);
        }
        return null;
    }
}
