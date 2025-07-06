public class Solution {
    public bool IsPerfectSquare(int num) {
        
        for (int  i = 1 ; i<=100000 ; i++) 
        {
            if ((long) (i*i) == num) return true ;
        }
        return false ;
    }
}