public class Solution {
    public int[] GetConcatenation(int[] nums) {
        int[] arr = new int [nums.Length * 2] ;
        int j = 0 ; 
        for(int i = 0  ; i < nums.Length *2 ; i++ ){
            arr[i] = nums[j];
            j++ ;
            if (j==nums.Length) j=0 ;


        }
        return arr;
    }
}