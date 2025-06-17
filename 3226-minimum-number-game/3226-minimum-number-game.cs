public class Solution {
    public void swap (ref int x , ref int y) {
         int temp = x ; 
        x= y ;
        y= temp ;

    }
    public int[] NumberGame(int[] nums) {
        Array.Sort(nums);
        for (int i = 0 ; i < nums.Length ; i+=2){
                swap(ref nums[i] , ref nums[i+1] );

        }
return nums;
    }
}