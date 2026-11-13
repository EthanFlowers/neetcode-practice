public class Solution {
    List<List<int>> result;
    public List<List<int>> CombinationSum(int[] nums, int target) {
        result = [];
        Array.Sort(nums);
        backtrack(nums, 0, target, [], 0);
        return result;
    }

    void backtrack(int[] nums, int start, int target, List<int> state, int total) {
        // base case
        if (total == target) {
            // List<int> s = [..state];
            // s.Sort();
            // if (!result.Any(x => x.SequenceEqual(s))) {
                result.Add(new List<int>(state));
                return;
            }
        //}
        //.WriteLine(string.Join(",", state.ToArray()));

        // go through all paths
        for (int i = start; i < nums.Length; i++) {
            if (total + nums[i] > target) {
                return;
            }
            // choose
            state.Add(nums[i]);
            // explore
            backtrack(nums, i, target, state, total+nums[i]);
            // unchoose
            state.RemoveAt(state.Count - 1);
        }
    }
}
