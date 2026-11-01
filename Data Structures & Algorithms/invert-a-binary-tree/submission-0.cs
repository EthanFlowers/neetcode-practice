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
    public TreeNode InvertTree(TreeNode root) {

        if(root == null){
            return null;
        }
        TreeNode curr = root;
        TreeNode curr_ans = new TreeNode(root.val);
        TreeNode ans = curr_ans;
        //bfs
        Queue<TreeNode> q = new Queue<TreeNode>();
        Queue<TreeNode> q1 = new Queue<TreeNode>();

        q.Enqueue(root);
        q1.Enqueue(ans);

        while(q.Count > 0){
            Console.WriteLine($"q {string.Join(",",q.Select(a => a.val).ToArray())} q1 {string.Join(",",q1.Select(a => a.val).ToArray())}");

            curr = q.Dequeue();
            curr_ans = q1.Dequeue();
            Console.WriteLine(curr.val + " " + curr_ans.val);
            
            if(curr.left != null) {
                q.Enqueue(curr.left);
                curr_ans.right = new TreeNode(curr.left.val);
            }
            if(curr.right != null) {
                q.Enqueue(curr.right);
                curr_ans.left = new TreeNode(curr.right.val);
            }
            if(curr_ans.right != null){q1.Enqueue(curr_ans.right);}
            if(curr_ans.left != null){q1.Enqueue(curr_ans.left);}
        }

        return ans;

    }
}
