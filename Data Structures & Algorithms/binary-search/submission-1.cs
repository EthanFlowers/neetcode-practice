public class Solution {
    public int Search(int[] nums, int target) {
        int mid = nums.Length/2;
        int l = 0;
        int r = nums.Length-1;
        int count = 0;
        while(l < r){
            //Console.WriteLine($"l {l} mid {mid} r {r} ");
           
            if(nums[mid] == target){
                break;
            }
            else if(nums[mid] > target){
                r = mid - 1;
            }
            else if(nums[mid] < target){
                l = mid + 1;
            }
            mid = ((r-l)/2) + l;
            //count++;
            
        }
        if(nums[mid] == target){
            return mid;
        }
        return -1;
    }
}
