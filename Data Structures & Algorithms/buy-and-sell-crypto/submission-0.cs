public class Solution {
    public int MaxProfit(int[] prices) {
        int max_profit = 0;

        for(int i=0; i<prices.Length; i++){
            for(int x=i+1; x<prices.Length; x++){
                int profit = prices[x] - prices[i];
                
                if(profit > max_profit) {
                    max_profit = profit;
                }
            }
        }
        return max_profit;
    }
}
