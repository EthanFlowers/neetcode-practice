public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        long max_pile = piles.Max();

        long max = max_pile;
        long min = 1;
        long best_k = max_pile;
       
        //Console.WriteLine($"min {min} max {max} h {h} len {piles.Length}");

        while (min <= max) {
            long mid = (max + min) / 2;
           
            long a_count = 0;
            long k = mid;
           
            for (int i = 0; i < piles.Length; i++) {
                long a = (int) Math.Ceiling((double) piles[i] / (double) k);
                a_count += a;
            }
            //Console.WriteLine($"min {min} mid {mid} max {max} k {k} a_count {a_count}");
            if (a_count <= h) {
                if(k < best_k){
                    best_k = k;
                }
                max = mid - 1;
            } 
            else if (a_count > h) {
                min = mid + 1;
            }
        }
        return (int) best_k;
    }
}
