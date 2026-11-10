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
    public List<int> RightSideView(TreeNode root) {
        //bfs
     
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        TreeNode curr = null;
        List<int> ans = [];
        if(root == null){
            return ans;
        }
        while(q.Count > 0){
            int c = q.Count;
            for(int i=0; i<c; i++){
                curr = q.Dequeue();
                if(curr.left != null) {q.Enqueue(curr.left);}
                if(curr.right != null) {q.Enqueue(curr.right);}
            }
            ans.Add(curr.val);
        }
        return ans;
    }
}
