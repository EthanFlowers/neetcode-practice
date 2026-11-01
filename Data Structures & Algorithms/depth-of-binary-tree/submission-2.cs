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
    public int MaxDepth(TreeNode root) {
        if(root == null){
            return 0;
        }
        Stack<(TreeNode, int)> s = new Stack<(TreeNode, int)>();
        int max_count = 0;

        s.Push((root, 1));

        while(s.Count > 0){
            (TreeNode curr, int curr_count) = s.Pop();
        
            //Console.WriteLine($"curr {curr.val} count {count}");
            if(curr.left == null && curr.right == null){
                max_count = max_count < curr_count ? curr_count : max_count;
            }

            if(curr.left != null){s.Push((curr.left, curr_count+1));}
            if(curr.right != null){s.Push((curr.right, curr_count+1));}

        }

        return max_count;
    }
}
