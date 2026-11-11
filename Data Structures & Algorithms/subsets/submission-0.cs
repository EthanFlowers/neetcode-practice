public class Solution {
    public List<List<int>> Subsets(int[] nums) {
        
        List<List<int>> ans = new List<List<int>>();
        backtrack(nums, [], 0, ans);

        return ans;
    }

    void backtrack(int[] nums, List<int> state, int start, List<List<int>> result){
        result.Add(new List<int>(state));
        for(int i=start; i<nums.Length; i++){
            // choose
            state.Add(nums[i]);

            // explore
            backtrack(nums, state, i+1, result);
            
            // backtrack
            state.RemoveAt(state.Count-1);
        }
    }
}
