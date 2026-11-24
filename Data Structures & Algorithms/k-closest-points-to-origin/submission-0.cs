public class Solution {
    public int[][] KClosest(int[][] points, int k) {
        PriorityQueue<int[], double> minHeap = new PriorityQueue<int[], double>();

        int[][] ans = new int[k][];

        foreach(var p in points){
            minHeap.Enqueue(p, calcDistance(p[0], p[1]));
        }
        Console.WriteLine(minHeap.Count);
        for(int i=0; i<k; i++){
            ans[i] = minHeap.Dequeue();
        }

        return ans;
    }
    private double calcDistance(int x, int y){
        return (double) Math.Sqrt(Math.Pow(x,2) + Math.Pow(y,2));
    }
}
