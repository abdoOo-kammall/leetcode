public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        List<int>l1 = new List<int>();
        l1.AddRange(nums1);
        l1.AddRange(nums2);
        l1.Sort();
        double ans = 0 ;
        int i = l1.Count /2 ;
        if (l1.Count % 2 ==0) { 
            ans = (l1[i] + l1[i-1])/2.0;
        }
        else 
        ans = l1[i]  ;
        return ans ; 
    }
}