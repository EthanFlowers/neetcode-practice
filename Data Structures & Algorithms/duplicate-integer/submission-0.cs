public class Solution {
    public bool hasDuplicate(int[] nums) {
        Dictionary<int, int> d = new Dictionary<int,int>();

        foreach(int n in nums){
            if( !d.TryAdd(n,1) ){
                return true;
            }
        }
        return false;
    }
}