public class Solution {
    public bool CheckPerfectNumber(int num) {
        
        long sum = 0 ; 
        for (int i = 1 ; i <= num /2 ; i++){
            if (num % i ==0) sum+= i ;
        }
        if (num == sum) return true ;
        return false ;
    }
}