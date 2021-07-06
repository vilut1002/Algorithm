public class Solution {
    public int[] FinalPrices(int[] prices) {
        int[] FinalPricesTemp = new int[prices.Length];
        for(int i=0; i<prices.Length; i++){
            int discount = 0;
            for(int j=i+1; j<prices.Length; j++){
                if(prices[j]<=prices[i]){
                    discount = prices[j];
                    break;
                }
            }
            FinalPricesTemp[i] = prices[i] - discount;
        }
        return FinalPricesTemp;
    }
}