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
    public int GoodNodes(TreeNode root) {
        Stack<(TreeNode, int)> s = new Stack<(TreeNode, int)>();
        TreeNode curr = null;
        int m = 0;
        int count = 0;

        s.Push((root,root.val));
        while(s.Count > 0){
            (curr, m) = s.Pop();

            int maxer = curr.val > m ? curr.val : m;
            //Console.WriteLine($"curr {curr.val} m {m} maxer {maxer}");

            if(curr.val >= m){ count++; }


            if(curr.left != null) {s.Push((curr.left, maxer));}
            if(curr.right != null) {s.Push((curr.right, maxer));}
        }

        return count;
    }
}
