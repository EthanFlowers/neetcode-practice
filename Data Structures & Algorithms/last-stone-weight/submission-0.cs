public class Solution {
    public int LastStoneWeight(int[] stones) {
        PriorityQueue<int, int> q = new PriorityQueue<int, int>();


        for(int i=0; i<stones.Length; i++){
            q.Enqueue(-stones[i], -stones[i]);
        }

        //List<int> s = new List(stones);

        while(q.Count > 1){
            int x = q.Dequeue();
            int y = q.Dequeue();

            if(x < y){
                q.Enqueue(x-y, x-y);
            }
        }
        q.Enqueue(0,0);
        return Math.Abs(q.Peek());
    }
}
