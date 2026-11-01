public class Solution {
    public int MaxArea(int[] heights) {
        int l = 0;
        int r = heights.Length-1;
        int max_fill = 0;
        while(l<r){
            int h = Math.Min(heights[l],heights[r]);
            int w = r-l;
            int fill =  h * w;
            //Console.WriteLine($"l {l} r {r} fill {fill}");

            if(fill > max_fill){
                max_fill = fill;
            }
            if(heights[r] > heights[l]){
                l++;
            }
            else if(heights[l] > heights[r]){
                r--;
            }
            else {
                l++; r--;
            }
        }
        return max_fill;
    }
}
