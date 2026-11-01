public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l = 0;
        int r = numbers.Length-1;
        bool found = false;
        int[] ans = {-1, -1};
        while(l < r && found == false){
            //Console.WriteLine($"{l} {r}");
            if(numbers[l] + numbers[r] == target)
            {
                found = true;
                ans[0] = l+1; ans[1] = r+1;
                break;
            }
            //3, 5, 6, 8   target=8
            // else if(target - numbers[r] <= 0){
            //     r--;
            // }
            else if(target - numbers[l] < numbers[r]){
                r--;
            }
            else if(target - numbers[r] > numbers[l]){
                l++;
            }

            

        }
        return ans;
    }
}
