public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int k = 0 ; 
        for(int i = 0 ; i< nums.Length -2 ; i++) {

            if ((nums[i] == nums[i+1]) && (nums[i+1] != nums[i+2]) || (nums[i]!=nums[i+1]))  { //1 2 2 
                nums[k]= nums[i];
                k++;
            }
        }
        if (nums.Length > 1 ){
        nums[k] = nums[nums.Length-2] ;
        k++;
        nums[k] = nums[nums.Length-1] ; }
        return k+1 ;
    }
}