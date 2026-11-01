public class Solution {
    public int MaxProfit(int[] prices) {
        int max_profit = 0;
        int min_buy = prices[0];
        if(prices.Length == 1){
            return 0;
        }
        for(int i=1; i<prices.Length; i++){
            if(prices[i-1] < min_buy){
                min_buy = prices[i-1];
            }
            int profit = prices[i]-min_buy;
            if(profit > max_profit){
                max_profit=profit;
            }
        }
        return max_profit;

    }
}
