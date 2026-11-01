public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> d = new Dictionary<int, int>();

        foreach(var n in nums){
            if(!d.TryAdd(n, 1)){
                d[n] = d[n] + 1;
            }
        }
        Console.WriteLine(string.Join(Environment.NewLine, d.Select(kvp => $"{kvp.Key}: {kvp.Value}")));

        var sorted = d.OrderByDescending(dic => dic.Value).Select( dic => dic.Key).Take(k).ToArray();

        return sorted;




    }
}
