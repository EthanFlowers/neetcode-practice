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
    public bool IsValidBST(TreeNode root) {
        Stack<(TreeNode, int, int)> s = new Stack<(TreeNode, int, int)>();

        s.Push((root, int.MinValue, int.MaxValue));
        while (s.Count > 0) {
            (TreeNode curr, int min, int max) = s.Pop();
            //Console.WriteLine($"curr {curr.val} max {max} min {min}");
            if( !((curr.val > min) && (curr.val < max)) ){
                return false;
            }

            if(curr.left != null){
                s.Push( (curr.left, min, curr.val) );
            }
            if(curr.right != null){
                s.Push( (curr.right, curr.val, max) );
            }
         
        }
    //     5
    //    / \
    //   4   6
    //      / \
    //     3   7
        return true;
    }
}
