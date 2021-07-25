public class Solution {
    public int MajorityElement(int[] nums) {
        for(int i=1; i<nums.Length; i++){
            int number = nums[i], j=i-1;
            while (j >= 0&&nums[j]>number) {
                nums[j + 1] = nums[j];
                j--;
            }
            nums[j + 1] = number;
        }
        int idx = (int)Math.Truncate((double)nums.Length/2);
        return nums[idx];
    }
}