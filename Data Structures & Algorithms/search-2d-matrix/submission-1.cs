public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int l = 0;
        int r = matrix.Length;
        int row = -1;
        int c = 0;
        while (l <= r) {
            int mid = (r + l) / 2;
            Console.WriteLine($"r {r} l {l} mid {mid}");
            if(matrix[mid][0] == target){
                return true;
            }
            // target is higher than this row, but row is max
            else if(matrix[mid][0] < target && mid + 1 >= matrix.Length){
                row = mid;
                break;
            }
            // target is between this row and row+1 it is current row
            else if(matrix[mid][0] < target && matrix[mid+1][0] > target){
                row = mid;
                break;
            }
            // target is lower than this row
            else if(matrix[mid][0] > target){
                r = mid -1;
            }
            else {
                l = mid + 1;
            }
        }
        if(row == -1){
            return false;
        }

        int inner_l = 0;
        int inner_r = matrix[row].Length-1;
        c = 0;
        while (inner_l <= inner_r) {
            int mid = (inner_l+inner_r)/2;
            Console.WriteLine($"in_r {inner_r} in_l {inner_l} mid {mid}");

            if(matrix[row][mid] == target){
                return true;
            }
            // middle is less than target, 
            else if(matrix[row][mid] < target){
                inner_l = mid + 1;
            }
            else if(matrix[row][mid] > target){
                inner_r = mid - 1;
            }
        }
        return false;
    }
}
