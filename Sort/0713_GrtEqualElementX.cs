public class Solution {
    public int SpecialArray(int[] nums) {
        //정렬 후 INDEX 비교
        for(int i=1; i<nums.Length; i++){
            int curvalue=nums[i], j = i-1;
            while(j>=0 && curvalue<nums[j]){
              int tmp = nums[j];
              nums[j]=nums[j+1];
              nums[j+1] = tmp;
              j--;
              }
        }
        int unique = -1;
        if(nums.Length <= nums[0] && nums.Length >0){
            unique = nums.Length;            
        }
        for(int i=1; i<nums.Length; i++){
            if(nums.Length - i <= nums[i] && nums.Length - i > nums[i-1] ){
                unique = nums.Length - i;
            }
        }
        return unique;
    }
}