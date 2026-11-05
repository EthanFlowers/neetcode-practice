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
    public List<List<int>> LevelOrder(TreeNode root) {
        if(root == null){
            return [];
        }
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<List<int>> ans = [];
        q.Enqueue(root);
        while (q.Count > 0) {
            int l = q.Count;
            List<int> a = [];
            for (int i = 0; i < l; i++) {
                TreeNode curr = q.Dequeue();
                a.Add(curr.val);
                if(curr.left != null) {q.Enqueue(curr.left);}
                if(curr.right != null) {q.Enqueue(curr.right);}
            }
            ans.Add(a);
        }
        return ans;
    }
}
