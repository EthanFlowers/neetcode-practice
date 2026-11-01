public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        List<List<int>> ans = new List<List<int>>();
        HashSet<(int,int,int)> ans_h = new HashSet<(int,int,int)>();
        Array.Sort(nums);
        if(nums.Length < 3){
            return [];
        }
        //Console.WriteLine(string.Join(",",nums));
        for(int i=0; i<nums.Length-2; i++){
            int j = i + 1;
            int k = nums.Length-1;
            while(j<k){
                int s = nums[j] + nums[k] + nums[i];
                //.WriteLine($"i {i} j {j} k {k} s {s}");

                if(s == 0){
                    if(!ans_h.Contains((nums[i],nums[j],nums[k]))){
                        ans.Add([nums[i],nums[j],nums[k]]);
                        ans_h.Add((nums[i],nums[j],nums[k]));
                    }
                    
                    j++; k--;
                }
                else if(s > 0){
                    k--;
                }
                else if(s < 0) {
                    j++;
                }
            }
        }
        return ans;
    }
}
